using My_Soap_Service.Generated.Client.MySoapServiceReference;
using My_Soap_Service.Manual.Client.Utils;
using System;

namespace My_Soap_Service.Generated.Client
{
    public class Program
    {
        public static void Main()
        {
            var searchClient = new SearchServiceClient();
            var validationClient = new ValidationServiceClient();

            var companyEmailExample = "contato@petrobras.com.br";
            var personEmailExample = "lucas.moreira@email.com";
            var cnpjExample = "01.838.723/0001-27";
            var cpfExample = "000.111.222-33";

            // Validation
            var companyEmailValidation = validationClient.ValidateEmail(companyEmailExample);
            var personEmailValidation = validationClient.ValidateEmail(personEmailExample);
            var cnpjValidation = validationClient.ValidateCNPJ(cnpjExample);
            var cpfValidation = validationClient.ValidateCPF(cpfExample);

            // Search
            var companyEmailSearch = searchClient.SearchCompanyByEmail(companyEmailExample);
            var personEmailSearch = searchClient.SearchPersonByEmail(personEmailExample);
            var cnpjSearch = searchClient.SearchByCNPJ(cnpjExample);
            var cpfSearch = searchClient.SearchByCPF(cpfExample);

            Console.WriteLine($"Validation Response to Company Email {companyEmailExample}: {companyEmailValidation}\n");
            Console.WriteLine($"Validation Response to Person Email {personEmailExample}: {personEmailValidation}\n");
            Console.WriteLine($"Validation Response to CNPJ {cnpjExample}: {cnpjValidation} \n");
            Console.WriteLine($"Validation Response to CPF {cpfExample}: {cpfValidation} \n");

            Console.WriteLine($"Search Response to Company Email {companyEmailExample}: {ReponseUtils.Format(companyEmailSearch)}\n");
            Console.WriteLine($"Search Response to Person Email {personEmailExample}: {ReponseUtils.Format(personEmailSearch)}\n");
            Console.WriteLine($"Search Response to CNPJ {cnpjExample}: {ReponseUtils.Format(cnpjSearch)} \n");
            Console.WriteLine($"Search Response to CPF {cpfExample}: {ReponseUtils.Format(cpfSearch)} \n");

            searchClient.Close();
            validationClient.Close();

            Console.ReadKey();
        }
    }
}
