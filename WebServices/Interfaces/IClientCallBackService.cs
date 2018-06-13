using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebServices.Interfaces
{
    public interface IClientCallBackService
    {
        [OperationContract(IsOneWay =true)]
        void NotifyClient(string notification);
    }
}
