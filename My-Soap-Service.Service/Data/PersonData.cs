using System.Collections.Generic;

namespace My_Soap_Service.Service.Data
{
    public static class PersonData
    {
        public static List<Person> All => new List<Person>
        {
            new Person { Name = "Lucas Moreira", Email = "lucas.moreira@email.com", CPF = "123.456.789-09", Situation = "Ativo" },
            new Person { Name = "Ana Clara Souza", Email = "ana.souza@email.com", CPF = "987.654.321-00", Situation = "Ativo" },
            new Person { Name = "João Pedro Lima", Email = "joao.p.lima@email.com", CPF = "111.222.333-44", Situation = "Inativo" },
            new Person { Name = "Mariana Silva", Email = "mariana.silva@email.com", CPF = "555.666.777-88", Situation = "Ativo" },
            new Person { Name = "Felipe Rocha", Email = "felipe.rocha@email.com", CPF = "999.888.777-66", Situation = "Ativo" },
            new Person { Name = "Beatriz Castro", Email = "beatriz.castro@email.com", CPF = "444.555.666-77", Situation = "Ativo" },
            new Person { Name = "Ricardo Alves", Email = "ricardo.alves@email.com", CPF = "333.222.111-00", Situation = "Suspenso" },
            new Person { Name = "Carla Mendes", Email = "carla.mendes@email.com", CPF = "222.333.444-55", Situation = "Ativo" },
            new Person { Name = "Bruno Martins", Email = "bruno.martins@email.com", CPF = "666.777.888-99", Situation = "Baixado" },
            new Person { Name = "Letícia Duarte", Email = "leticia.duarte@email.com", CPF = "000.111.222-33", Situation = "Ativo" }
        };

        public class Person
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string CPF { get; set; }
            public string Situation { get; set; }
        }
    }
}
