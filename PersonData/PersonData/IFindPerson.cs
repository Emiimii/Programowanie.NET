using PersonData.Models;
using System.ServiceModel;

namespace PersonData
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFindPerson" in both code and config file together.
    [ServiceContract]
    public interface IFindPerson
    {
        [OperationContract]
        Person FindPersonBySurname(string surname);
    }
}
