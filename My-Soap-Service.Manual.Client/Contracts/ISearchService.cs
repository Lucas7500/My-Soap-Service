using My_Soap_Service.Manual.Client.Faults;
using My_Soap_Service.Manual.Client.Responses;
using System.ServiceModel;

namespace My_Soap_Service.Manual.Client.Contracts
{
    [ServiceContract]
    public interface ISearchService
    {
        [OperationContract]
        [FaultContract(typeof(PersonNotFoundFault))]
        PersonResponse SearchPersonByEmail(string email);

        [OperationContract]
        [FaultContract(typeof(PersonNotFoundFault))]
        PersonResponse SearchByCPF(string cpf);

        [OperationContract]
        [FaultContract(typeof(CompanyNotFoundFault))]
        CompanyResponse SearchCompanyByEmail(string email);

        [OperationContract]
        [FaultContract(typeof(CompanyNotFoundFault))]
        CompanyResponse SearchByCNPJ(string cnpj);
    }
}
