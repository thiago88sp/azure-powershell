// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Management.Compute.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [Cmdlet("Add", "AzureRmVmssSshPublicKey", SupportsShouldProcess = true)]
    [OutputType(typeof(PSVirtualMachineScaleSet))]
    public partial class AddAzureRmVmssSshPublicKeyCommand : Microsoft.Azure.Commands.ResourceManager.Common.AzureRMCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public PSVirtualMachineScaleSet VirtualMachineScaleSet { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 1,
            ValueFromPipelineByPropertyName = true)]
        public string Path { get; set; }

        [Parameter(
            Mandatory = false,
            Position = 2,
            ValueFromPipelineByPropertyName = true)]
        public string KeyData { get; set; }

        protected override void ProcessRecord()
        {
            if (ShouldProcess("VirtualMachineScaleSet", "Add"))
            {
                Run();
            }
        }

        private void Run()
        {
            // VirtualMachineProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetVMProfile();
            }

            // OsProfile
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile = new Microsoft.Azure.Management.Compute.Models.VirtualMachineScaleSetOSProfile();
            }

            // LinuxConfiguration
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration = new Microsoft.Azure.Management.Compute.Models.LinuxConfiguration();
            }

            // Ssh
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.Ssh == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.Ssh = new Microsoft.Azure.Management.Compute.Models.SshConfiguration();
            }

            // PublicKeys
            if (this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.Ssh.PublicKeys == null)
            {
                this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.Ssh.PublicKeys = new List<Microsoft.Azure.Management.Compute.Models.SshPublicKey>();
            }

            var vPublicKeys = new Microsoft.Azure.Management.Compute.Models.SshPublicKey();

            vPublicKeys.Path = this.MyInvocation.BoundParameters.ContainsKey("Path") ? this.Path : null;
            vPublicKeys.KeyData = this.MyInvocation.BoundParameters.ContainsKey("KeyData") ? this.KeyData : null;
            this.VirtualMachineScaleSet.VirtualMachineProfile.OsProfile.LinuxConfiguration.Ssh.PublicKeys.Add(vPublicKeys);
            WriteObject(this.VirtualMachineScaleSet);
        }
    }
}

