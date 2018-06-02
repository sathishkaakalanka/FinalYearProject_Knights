
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace UIProcess.ServiceClients
{
    public class Endpoint
    {
        public string GetEndPointUri(string endPointName, out string bindingConfigName)
        {
            ClientSection clientSection = (ClientSection)ConfigurationManager.GetSection("system.serviceModel/client");
            string address = "";
            string configName = "";
            for (int i = 0; i < clientSection.Endpoints.Count; i++)
            {
                if (clientSection.Endpoints[i].Name == endPointName)
                {
                    address = clientSection.Endpoints[i].Address.ToString();
                    configName = clientSection.Endpoints[i].BindingConfiguration.ToString();
                }
            }
            bindingConfigName = configName;
            return address;
        }
    }
}
