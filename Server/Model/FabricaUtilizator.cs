using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class FabricaUtilizator
    {
        public Utilizator obtineUtilizator(string tip, int id, string nume, string prenume, string nrTelefon, string email, string username, string password)
        {
            if (tip == null)
                return null; ;
            if (tip.CompareTo("angajat") == 0)
                return new Angajat(id, nume, prenume, nrTelefon, email, username, password);
            else if (tip.CompareTo("administrator") == 0)
                return new Administrator(id, nume, prenume, nrTelefon, email, username, password);
            else
                return null;

        }
    }
}
