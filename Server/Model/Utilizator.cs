using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace Server.Model
{
    [KnownType(typeof(Administrator))]
    [KnownType(typeof(Angajat))]
    [DataContract]
    public class Utilizator
    {
        [DataMember]
        protected string tip;
        [DataMember]
        protected int id;
        [DataMember]
        protected string nume;
        [DataMember]
        protected string prenume;
        [DataMember]
        protected string nrTelefon;
        [DataMember]
        protected string email;
        [DataMember]
        protected string username;
        [DataMember]
        protected string password; 
        public Utilizator()
        {
            tip = "";
            id = 0;
            nume = "Razvan";
            prenume = "Vasile";
            nrTelefon = "0744556677";
            email = "example@email.com";
            username = "username";
            password = "yourPassword";

        }
        public Utilizator(int id, string nume, string prenume, string nrTelefon, string email, string username, string password)
        {
            this.id = id;
            this.username = username;
            this.nume = nume;
            this.prenume = prenume;
            this.nrTelefon = nrTelefon;
            this.email = email;
            this.password = password;
        }
        public Utilizator(string nume, string prenume)
        {
            this.nume = nume;
            this.prenume = prenume;
        }
        public void setNume(string nume)
        {
            this.nume = nume;
        }
        public void setPrenume(string prenume)
        {
            this.prenume = prenume;
        }
        public void setNrTelefon(string nrTelefon)
        {
            this.nrTelefon = nrTelefon;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getNume()
        {
            return nume;
        }
        public string getPrenume()
        {
            return prenume;
        }
        public string getNrTelefon()
        {
            return nrTelefon;
        }
        public string getEmail()
        {
            return email;
        }
        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public int getID()
        {
            return id;
        }
        public void setUsername(string username)
        {
            this.username = username;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getTip()
        {
            return tip;
        }


    }
}
