﻿using System;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using PostSharp.Patterns.Contracts;
using ThreatsManager.Interfaces;
using ThreatsManager.Interfaces.Extensions;
using ThreatsManager.Interfaces.ObjectModel;
using ThreatsManager.Interfaces.ObjectModel.ThreatsMitigations;
using ThreatsManager.Utilities;

namespace ThreatsManager.Extensions.StatusInfoProviders
{
    [Export(typeof(IStatusInfoProviderExtension))]
    [ExportMetadata("Id", "3A188FDC-1DED-489D-B3E3-B046B9E0501C")]
    [ExportMetadata("Label", "High Severity Threat Event by Type Counter Status Info Provider")]
    [ExportMetadata("Priority", 46)]
    [ExportMetadata("Parameters", null)]
    [ExportMetadata("Mode", ExecutionMode.Simplified)]
    public class HighByTypeThreatEventCounter : IStatusInfoProviderExtension
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
            _model.ThreatEventAdded += Update;
            _model.ThreatEventAddedToEntity += Update;
            _model.ThreatEventAddedToDataFlow += Update;
            _model.ThreatEventRemoved += Update;
            _model.ThreatEventRemovedFromEntity += Update;
            _model.ThreatEventRemovedFromDataFlow += Update;

            var modelTe = _model.ThreatEvents?.ToArray();
            if (modelTe?.Any() ?? false)
            {
                foreach (var te1 in modelTe)
                {
                    // ReSharper disable once SuspiciousTypeConversion.Global
                    ((INotifyPropertyChanged)te1).PropertyChanged += OnPropertyChanged;
                }
            }
        }

        private void OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (sender is IThreatEvent)
            {
                if (e.PropertyName == "Severity") UpdateInfo?.Invoke(this.GetExtensionId(), CurrentStatus);
            }
        }

        public string CurrentStatus =>
            $"High by Type: {_model.CountThreatEventsByType((int)DefaultSeverity.High)}";

        public string Description => "Counter of the Threat Events by Type which have been categorized as High Severity.\nThis counter counts as a single instance all Threat Events belonging to the same Threat Type having High as top Severity.";

        private void Update([NotNull] IThreatEventsContainer container, [NotNull] IThreatEvent threatEvent)
        {
            // ReSharper disable once SuspiciousTypeConversion.Global
            ((INotifyPropertyChanged)threatEvent).PropertyChanged += OnPropertyChanged;
            UpdateInfo?.Invoke(this.GetExtensionId(), CurrentStatus);
        }

        public override string ToString()
        {
            return "High Severity Threat Event by Type Counter";
        }
  
        public void Dispose()
        {
            _model.ThreatEventAdded -= Update;
            _model.ThreatEventAddedToEntity -= Update;
            _model.ThreatEventAddedToDataFlow -= Update;
            _model.ThreatEventRemoved -= Update;
            _model.ThreatEventRemovedFromEntity -= Update;
            _model.ThreatEventRemovedFromDataFlow -= Update;
            _model = null;
        }
    }
}