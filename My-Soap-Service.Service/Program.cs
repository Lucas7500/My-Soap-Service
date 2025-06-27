using My_Soap_Service.Service.Contracts;
using My_Soap_Service.Service.Services;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace My_Soap_Service
{
    public class Program
    {
        public static void Main()
        {
            var baseAddress = new Uri("http://localhost:8080/MySoapService");

            using (var host = new ServiceHost(typeof(MySoapService), baseAddress))
            {
                host.AddServiceEndpoint(typeof(IValidationService), new WSHttpBinding(), "Validation");
                host.AddServiceEndpoint(typeof(ISearchService), new WSHttpBinding(), "Search");

                var smb = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                };

                host.Description.Behaviors.Add(smb);

                host.Open();

                Console.WriteLine("Serviço SOAP rodando em: " + baseAddress);
                Console.WriteLine("WSDL disponível em: " + baseAddress + "?wsdl");
                
                Console.WriteLine("Endpoints:");
                foreach (var endpoint in host.Description.Endpoints)
                {
                    Console.WriteLine($" - {endpoint.Name}: {endpoint.Address}");
                }

                Console.WriteLine("Pressione qualquer tecla para encerrar...");
                Console.ReadKey();

                host.Close();
            }
        }
    }
}
