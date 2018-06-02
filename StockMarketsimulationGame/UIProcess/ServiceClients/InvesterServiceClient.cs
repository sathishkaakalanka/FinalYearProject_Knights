using InvestorserviceHost;
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
    public class InvesterServiceClient : ServiceProxyBase<IInvestorService>
    {
        public InvesterServiceClient(string serviceEndPointUri, string serviceEndPointConfig)
            : base(serviceEndPointUri, serviceEndPointConfig)
        {
        }
    }
}
