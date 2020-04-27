using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Server.Model
{
 //   [KnownType(typeof(Utilizator))]
    [DataContract]

    public class Angajat : Utilizator
    {

        public Angajat(int id, string username, string nume, string prenume, string nrTelefon, string email, string password) : base(id, username, nume, prenume, nrTelefon, email, password)
        {
            tip = "angajat";
        }

    }

}
