using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server.Model;
using System.ServiceModel;
using System.Data;
namespace Server.Persistenta
{ 
    [ServiceContract]
    public interface IPersistentaUtilizator
    {
        [OperationContract]
        DataSet actuaizareAngajati();
        [OperationContract]
        DataSet vizualizareAnimale();
        [OperationContract]
        DataSet filtrareDupaZonaHabitat(string zona);
        [OperationContract]
        DataSet filtrareDupaTipLocomotie(string tip);
        [OperationContract]
        DataSet filtrareDupaTipAlimentatie(string tip);
        [OperationContract]
        DataSet filtrareDupaZonaZoo(string zona);
        [OperationContract]
        DataSet cautareDupaSpecie(string specie);

    }
}
