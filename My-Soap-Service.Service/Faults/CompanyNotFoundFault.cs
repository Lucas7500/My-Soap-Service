using System.Runtime.Serialization;

namespace My_Soap_Service.Service.Faults
{
    [DataContract]
    public class CompanyNotFoundFault
    {
        [DataMember]
        public string Message { get; set; }
    }
}
