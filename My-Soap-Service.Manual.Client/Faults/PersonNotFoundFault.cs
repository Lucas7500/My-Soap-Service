using System.Runtime.Serialization;

namespace My_Soap_Service.Manual.Client.Faults
{
    [DataContract]
    public class PersonNotFoundFault
    {
        [DataMember]
        public string Message { get; set; }
    }
}
