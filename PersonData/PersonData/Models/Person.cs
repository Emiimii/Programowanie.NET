using System.Runtime.Serialization;

namespace PersonData.Models
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Surname;
        [DataMember]
        public string Address;
        public Person(string name, string surname, string address)
        {
            this.Name = name;
            this.Surname = surname;
            this.Address = address;
        }
    }
}