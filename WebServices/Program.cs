using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WebServices.Services;

namespace WebServices
{
    class Program
    {

        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(CalculatorService));
            serviceHost.Open();

            foreach (ServiceEndpoint endpoint in serviceHost.Description.Endpoints)
            {
                Console.WriteLine(endpoint.Address.Uri);
            }

            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
