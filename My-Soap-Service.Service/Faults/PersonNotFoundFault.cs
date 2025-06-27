using System.Runtime.Serialization;

namespace My_Soap_Service.Service.Faults
{
    [DataContract]
    public class PersonNotFoundFault
    {
        [DataMember]
        public string Message { get; set; }
    }
}
