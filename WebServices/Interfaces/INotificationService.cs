using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WebServices.Interfaces
{
    [ServiceContract(CallbackContract = typeof(IClientCallBackService))]
    public interface INotificationService
    {
        [OperationContract(IsOneWay = true)]
        Task RegisterForNotification(string parameter);
    }
}
