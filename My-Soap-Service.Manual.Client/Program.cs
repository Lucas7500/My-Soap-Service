using My_Soap_Service.Manual.Client.Contracts;
using My_Soap_Service.Manual.Client.Utils;
using System;
using System.ServiceModel;

namespace My_Soap_Service.Manual.Client
{
    public class Program
    {
        public static void Main()
        {
            var binding = new WSHttpBinding();
            var validationServiceAddress = new EndpointAddress("http://localhost:8080/MySoapService/Validation");
            var searchServiceAddress = new EndpointAddress("http://localhost:8080/MySoapService/Search");

            var searchServiceFactory = new ChannelFactory<ISearchService>(binding, searchServiceAddress);
            var validationServiceFactory = new ChannelFactory<IValidationService>(binding, validationServiceAddress);
            
            var searchServiceProxy = searchServiceFactory.CreateChannel();
            var validationServiceProxy = validationServiceFactory.CreateChannel();

            var companyEmailExample = "relacionamento@vale.com";
            var personEmailExample = "bruno.martins@email.com";
            var cnpjExample = "07.526.557/0001-00";
            var cpfExample = "999.888.777-66";

            // Validation
            var companyEmailValidation = validationServiceProxy.ValidateEmail(companyEmailExample);
            var personEmailValidation = validationServiceProxy.ValidateEmail(personEmailExample);
            var cnpjValidation = validationServiceProxy.ValidateCNPJ(cnpjExample);
            var cpfValidation = validationServiceProxy.ValidateCPF(cpfExample);

            // Search
            var companyEmailSearch = searchServiceProxy.SearchCompanyByEmail(companyEmailExample);
            var personEmailSearch = searchServiceProxy.SearchPersonByEmail(personEmailExample);
            var cnpjSearch = searchServiceProxy.SearchByCNPJ(cnpjExample);
            var cpfSearch = searchServiceProxy.SearchByCPF(cpfExample);

            Console.WriteLine($"Validation Response to Company Email {companyEmailExample}: {companyEmailValidation}\n");
            Console.WriteLine($"Validation Response to Person Email {personEmailExample}: {personEmailValidation}\n");
            Console.WriteLine($"Validation Response to CNPJ {cnpjExample}: {cnpjValidation} \n");
            Console.WriteLine($"Validation Response to CPF {cpfExample}: {cpfValidation} \n");

            Console.WriteLine($"Search Response to Company Email {companyEmailExample}: {ReponseUtils.Format(companyEmailSearch)}\n");
            Console.WriteLine($"Search Response to Person Email {personEmailExample}: {ReponseUtils.Format(personEmailSearch)}\n");
            Console.WriteLine($"Search Response to CNPJ {cnpjExample}: {ReponseUtils.Format(cnpjSearch)} \n");
            Console.WriteLine($"Search Response to CPF {cpfExample}: {ReponseUtils.Format(cpfSearch)} \n");

            (searchServiceProxy as IClientChannel)?.Close();
            (validationServiceProxy as IClientChannel)?.Close();

            Console.ReadKey();
        }
    }
}