using My_Soap_Service.Service.Contracts;
using My_Soap_Service.Service.Data;
using My_Soap_Service.Service.Faults;
using My_Soap_Service.Service.Responses;
using My_Soap_Service.Service.Utils;
using My_Soap_Service.Service.Utils.CpfCnpj;
using System.Linq;
using System.ServiceModel;

namespace My_Soap_Service.Service.Services
{
    public class MySoapService : IValidationService, ISearchService
    {
        public PersonResponse SearchPersonByEmail(string email)
        {
            var person = PersonData.All.FirstOrDefault(p => p.Email == email);

            if (person == null)
            {
                var faultDetail = new PersonNotFoundFault { Message = "Person not found with the given Email." };
                var faultReason = new FaultReason("Not found");

                throw new FaultException<PersonNotFoundFault>(faultDetail, faultReason);
            }

            return new PersonResponse
            {
                Name = person.Name,
                Email = person.Email,
                CPF = person.CPF,
                Situation = person.Situation
            };
        }

        public PersonResponse SearchByCPF(string cpf)
        {
            var person = PersonData.All.FirstOrDefault(p => StringUtils.Unformat(p.CPF) == StringUtils.Unformat(cpf));

            if (person == null)
            {
                var faultDetail = new PersonNotFoundFault { Message = "Person not found with the given CPF." };
                var faultReason = new FaultReason("Not found");

                throw new FaultException<PersonNotFoundFault>(faultDetail, faultReason);
            }

            return new PersonResponse
            {
                Name = person.Name,
                Email = person.Email,
                CPF = person.CPF,
                Situation = person.Situation
            };
        }

        public CompanyResponse SearchCompanyByEmail(string email)
        {
            var company = CompanyData.All.FirstOrDefault(p => p.Email == email);

            if (company == null)
            {
                var faultDetail = new CompanyNotFoundFault { Message = "Company not found with the given Email." };
                var faultReason = new FaultReason("Not found");

                throw new FaultException<CompanyNotFoundFault>(faultDetail, faultReason);
            }

            return new CompanyResponse
            {
                Name = company.Name,
                Email = company.Email,
                CNPJ = company.CNPJ,
                Situation = company.Situation
            };
        }

        public CompanyResponse SearchByCNPJ(string cnpj)
        {
            var company = CompanyData.All.FirstOrDefault(p => StringUtils.Unformat(p.CNPJ) == StringUtils.Unformat(cnpj));

            if (company == null)
            {
                var faultDetail = new CompanyNotFoundFault { Message = "Company not found with the given CNPJ." };
                var faultReason = new FaultReason("Not found");

                throw new FaultException<CompanyNotFoundFault>(faultDetail, faultReason);
            }

            return new CompanyResponse
            {
                Name = company.Name,
                Email = company.Email,
                CNPJ = company.CNPJ,
                Situation = company.Situation
            };
        }

        public bool ValidateEmail(string email)
        {
            return ValidationUtils.IsValidEmail(email);
        }

        public bool ValidateCNPJ(string cnpj)
        {
            return ValidationUtils.IsValidCnpj(cnpj);
        }

        public bool ValidateCPF(string cpf)
        {
            return ValidationUtils.IsValidCpf(cpf);
        }
    }
}
