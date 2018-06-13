using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WebServices.Interfaces;

namespace WebServices.Services
{
    public class NotificationService : INotificationService
    {
        public async Task RegisterForNotification(string parameter)
        {
            Notify notification = new Notify();
            notification.callback = OperationContext.Current.GetCallbackChannel<IClientCallBackService>();

            await notification.SendNotify();
        }
    }

    public class Notify
    {
        public IClientCallBackService callback = null;
        public async Task SendNotify()
        {
            Random p = new Random();
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(5000);
                try
                {
                    callback.NotifyClient("Call number: " + i);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
