﻿using System;
using System.ComponentModel.Composition;
using PostSharp.Patterns.Contracts;
using ThreatsManager.Interfaces;
using ThreatsManager.Interfaces.Extensions;
using ThreatsManager.Interfaces.ObjectModel;
using ThreatsManager.Interfaces.ObjectModel.ThreatsMitigations;
using ThreatsManager.Utilities;

namespace ThreatsManager.Extensions.StatusInfoProviders
{
    [Export(typeof(IStatusInfoProviderExtension))]
    [ExportMetadata("Id", "9F9FC6E2-466D-4156-8BE7-E28ECC364E03")]
    [ExportMetadata("Label", "Unique Mitigation Counter Status Info Provider")]
    [ExportMetadata("Priority", 36)]
    [ExportMetadata("Parameters", null)]
    [ExportMetadata("Mode", ExecutionMode.Simplified)]
    public class UniqueMitigationCounter : IStatusInfoProviderExtension
    {
        private IThreatModel _model;

        public event Action<string, string> UpdateInfo;

        public void Initialize([NotNull] IThreatModel model)
        {
            if (_model != null)
            {
                Dispose();
            }

            _model = model;
            _model.ThreatEventAdded += ThreatEventAdded;
            _model.ThreatEventAddedToEntity += ThreatEventAdded;
            _model.ThreatEventAddedToDataFlow += ThreatEventAdded;
            _model.ThreatEventRemoved += ThreatEventRemoved;
            _model.ThreatEventRemovedFromEntity += ThreatEventRemoved;
            _model.ThreatEventRemovedFromDataFlow += ThreatEventRemoved;
        }

        public string CurrentStatus =>
            $"Unique Mitigations: {_model.UniqueMitigations}";

        public string Description => "Counter of the unique Mitigations which have been applied.\nThis counter will count a single instance even if the same Mitigation has been applied to multiple Threat Events.";

        private void ThreatEventAdded([NotNull] IThreatEventsContainer container, [NotNull] IThreatEvent threatEvent)
        {
            threatEvent.ThreatEventMitigationAdded += Update;
            threatEvent.ThreatEventMitigationRemoved += Update;
            UpdateInfo?.Invoke(this.GetExtensionId(), CurrentStatus);
        }

        private void ThreatEventRemoved([NotNull] IThreatEventsContainer container, [NotNull] IThreatEvent threatEvent)
        {
            threatEvent.ThreatEventMitigationAdded -= Update;
            threatEvent.ThreatEventMitigationRemoved -= Update;
            UpdateInfo?.Invoke(this.GetExtensionId(), CurrentStatus);
        }

        private void Update(IThreatEventMitigationsContainer container, IThreatEventMitigation mitigation)
        {
            UpdateInfo?.Invoke(this.GetExtensionId(), CurrentStatus);
        }

        public override string ToString()
        {
            return "Unique Mitigation Counter";
        }
 
        public void Dispose()
        {
            _model.ThreatEventAdded -= ThreatEventAdded;
            _model.ThreatEventAddedToEntity -= ThreatEventAdded;
            _model.ThreatEventAddedToDataFlow -= ThreatEventAdded;
            _model.ThreatEventRemoved -= ThreatEventRemoved;
            _model.ThreatEventRemovedFromEntity -= ThreatEventRemoved;
            _model.ThreatEventRemovedFromDataFlow -= ThreatEventRemoved;
            _model = null;
        }
    }
}
