using PersonData.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonData
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FindPerson" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FindPerson.svc or FindPerson.svc.cs at the Solution Explorer and start debugging.
    public class FindPerson : IFindPerson
    {
        List<Person> somePeople = new List<Person>
        {
            new Person("Michael", "Masa", "Starstreet 23rd"),
            new Person("John", "Cena", "Longstreet 21st"),
            new Person("Pablo", "Picasso", "Artstreet 15th"),
            new Person("Emily", "May", "Grunwaldzka 3rd"),
            new Person("Rachel", "Green", "Colourfullstreet 44th")
        };

        Person IFindPerson.FindPersonBySurname(string surname)
        {
            return somePeople.FirstOrDefault(p => p.Surname == surname);
        }
    }
}
