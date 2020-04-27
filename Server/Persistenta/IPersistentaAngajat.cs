using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Data;
using Server.Model;
namespace Server.Persistenta
{
    [ServiceContract]
    public interface IPersistentaAngajat
    {

        [OperationContract]
        void addAnimal(Animal a);
        [OperationContract]
        void updateAnimal(int id, Animal a);
        [OperationContract]
        void deleteAnimal(int id);
    }
}
