using System.Runtime.Serialization;

namespace My_Soap_Service.Manual.Client.Faults
{
    [DataContract]
    public class CompanyNotFoundFault
    {
        [DataMember]
        public string Message { get; set; }
    }
}
