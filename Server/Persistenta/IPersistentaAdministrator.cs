using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel;
using System.Data;
using Server.Model;
namespace Server.Persistenta
{
    [ServiceContract]
    public interface IPersistentaAdministrator
    {
        [OperationContract]
        void addAngajat(Utilizator u);
        [OperationContract]
        void updateAngajat(int id, Utilizator u);
        [OperationContract]
        void deleteAngajat(int id);
        [OperationContract]
        DataSet actualizareAngajati();

    }
}
