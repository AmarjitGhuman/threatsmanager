﻿using System;
using System.ComponentModel.Composition;
using System.Drawing;
using ThreatsManager.Interfaces;
using ThreatsManager.Interfaces.Extensions;
using ThreatsManager.Interfaces.Extensions.Actions;
using ThreatsManager.Interfaces.ObjectModel;
using ThreatsManager.Interfaces.ObjectModel.ThreatsMitigations;
using Shortcut = ThreatsManager.Interfaces.Extensions.Shortcut;

namespace ThreatsManager.AutoThreatGeneration.Actions
{
    [Export(typeof(IContextAwareAction))]
    [ExportMetadata("Id", "C2029A88-0E8E-49F1-A9DF-3FEFAF5582CB")]
    [ExportMetadata("Label", "Apply Mitigation Association Rule to Threat Event Context Aware Action")]
    [ExportMetadata("Priority", 35)]
    [ExportMetadata("Parameters", null)]
    [ExportMetadata("Mode", ExecutionMode.Simplified)]
    public class ApplyMitigationAssociationRules : IIdentityContextAwareAction, IDesktopAlertAwareExtension
    {
        public Scope Scope => Scope.ThreatEvent;
        public string Label => "Apply Mitigation Association Rules";
        public string Group => "ItemActions";
        public Bitmap Icon => null;
        public Bitmap SmallIcon => null;
        public Shortcut Shortcut => Shortcut.None;

        public event Action<string> ShowMessage;
        public event Action<string> ShowWarning;

        public bool Execute(object item)
        {
            bool result = false;

            if (item is IIdentity identity)
                result = Execute(identity);

            return result;
        }

        public bool Execute(IIdentity identity)
        {
            if (identity is IThreatEvent threatEvent)
            {
                if (threatEvent.ApplyMitigations())
                    ShowMessage?.Invoke("Mitigations associated successfully.");
                else
                {
                    ShowWarning?.Invoke("No Mitigation has been associated.");
                }

            }

            return true;
        }
    }
}