using System.Collections.Generic;

namespace My_Soap_Service.Service.Data
{
    public static class CompanyData
    {
        public static List<Company> All => new List<Company>
        {
            new Company { Name = "Petrobras S.A.", Email = "contato@petrobras.com.br", CNPJ = "33.000.167/0001-01", Situation = "Ativa" },
            new Company { Name = "Vale S.A.", Email = "relacionamento@vale.com", CNPJ = "33.592.510/0001-54", Situation = "Ativa" },
            new Company { Name = "Ambev S.A.", Email = "sac@ambev.com.br", CNPJ = "07.526.557/0001-00", Situation = "Ativa" },
            new Company { Name = "Magazine Luiza S.A.", Email = "suporte@magazineluiza.com.br", CNPJ = "47.960.950/0001-21", Situation = "Ativa" },
            new Company { Name = "Itaú Unibanco S.A.", Email = "contato@itau.com.br", CNPJ = "60.701.190/0001-04", Situation = "Ativa" },
            new Company { Name = "Banco do Brasil S.A.", Email = "atendimento@bb.com.br", CNPJ = "00.000.000/0001-91", Situation = "Ativa" },
            new Company { Name = "Eletrobras", Email = "info@eletrobras.gov.br", CNPJ = "00.001.180/0001-26", Situation = "Ativa" },
            new Company { Name = "BRF S.A.", Email = "sac@brf-br.com", CNPJ = "01.838.723/0001-27", Situation = "Ativa" },
            new Company { Name = "Localiza Rent a Car S.A.", Email = "cliente@localiza.com", CNPJ = "16.670.085/0001-55", Situation = "Ativa" },
            new Company { Name = "Natura Cosméticos S.A.", Email = "contato@natura.com.br", CNPJ = "71.673.990/0001-77", Situation = "Ativa" }
        };

        public class Company
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string CNPJ { get; set; }
            public string Situation { get; set; }
        }
    }
}
