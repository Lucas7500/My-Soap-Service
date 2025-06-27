using System.ServiceModel;

namespace My_Soap_Service.Manual.Client.Contracts
{
    [ServiceContract]
    public interface IValidationService
    {
        [OperationContract]
        bool ValidateEmail(string email);

        [OperationContract]
        bool ValidateCPF(string cpf);

        [OperationContract]
        bool ValidateCNPJ(string cnpj);
    }
}
