﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Microsoft.Azure.Commands.Network.Models
{
    public class PSApplicationGateway : PSTopLevelResource
     {
         public PSApplicationGatewaySku Sku { get; set; }

         public List<PSApplicationGatewayIPConfiguration> GatewayIPConfigurations { get; set; }

         public List<PSApplicationGatewaySslCertificate> SslCertificates { get; set; }

         public List<PSApplicationGatewayFrontendIPConfiguration> FrontendIPConfigurations { get; set; }

         public List<PSApplicationGatewayFrontendPort> FrontendPorts { get; set; }

         public List<PSApplicationGatewayBackendAddressPool> BackendAddressPools { get; set; }

         public List<PSApplicationGatewayBackendHttpSettings> BackendHttpSettingsCollection { get; set; }

         public List<PSApplicationGatewayHttpListener> HttpListeners { get; set; }

         public List<PSApplicationGatewayRequestRoutingRule> RequestRoutingRules { get; set; }

         public string OperationalState { get; private set; }

         public string ProvisioningState { get; set; }

         [JsonIgnore]
         public string GatewayIpConfigurationsText
         {
             get { return JsonConvert.SerializeObject(GatewayIPConfigurations, Formatting.Indented); }
         }

         [JsonIgnore]
         public string SslCertificatesText
         {
             get { return JsonConvert.SerializeObject(SslCertificates, Formatting.Indented); }
         }

         [JsonIgnore]
         public string FrontendIpConfigurationsText
         {
             get { return JsonConvert.SerializeObject(FrontendIPConfigurations, Formatting.Indented); }
         }

         [JsonIgnore]
         public string FrontendPortsText
         {
             get { return JsonConvert.SerializeObject(FrontendPorts, Formatting.Indented); }
         }

         [JsonIgnore]
         public string BackendAddressPoolsText
         {
             get { return JsonConvert.SerializeObject(BackendAddressPools, Formatting.Indented); }
         }

         [JsonIgnore]
         public string BackendHttpSettingsCollectionText
         {
             get { return JsonConvert.SerializeObject(BackendHttpSettingsCollection, Formatting.Indented); }
         }

         [JsonIgnore]
         public string HttpListenersText
         {
             get { return JsonConvert.SerializeObject(HttpListeners, Formatting.Indented); }
         }

         [JsonIgnore]
         public string RequestRoutingRulesText
         {
             get { return JsonConvert.SerializeObject(RequestRoutingRules, Formatting.Indented); }
         }
     }
}
