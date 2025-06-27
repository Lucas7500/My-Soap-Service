using System.Runtime.Serialization;

namespace My_Soap_Service.Manual.Client.Responses
{
    [DataContract]
    public class CompanyResponse
    {
        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public string Email { get; set; }
        
        [DataMember]
        public string CNPJ { get; set; }
        
        [DataMember]
        public string Situation { get; set; }
    }
}
