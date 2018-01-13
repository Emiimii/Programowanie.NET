using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebServices1
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IWyszukiwanie” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IWyszukiwanie
    {
        [OperationContract]
        void WgNazwiska();
    }
}
