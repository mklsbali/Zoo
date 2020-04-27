using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace Server.Model
{
    [DataContract]
    public class Animal
    {
        [DataMember]
        private int id;
        [DataMember]
        private string animal;
        [DataMember]
        private string specie;
        [DataMember]
        private string zonaHabitat;
        [DataMember]
        private string tipAlimentatie;
        [DataMember]
        private string tipLocomotie;
        [DataMember]
        private string zonaGradinaZoologica;
        public Animal()
        {
            id = 0;
            animal = "animal";
            specie = "specie";
            zonaHabitat = "zona habitat";
            tipAlimentatie = "tip alimentatie";
            tipLocomotie = "tip locomotie";
            zonaGradinaZoologica = "zona gradina zoologica";
        }
        public Animal(int id, string animal, string specie, string zonaHabitat, string tipAlimentatie, string tipLocomotie, string zonaGradinaZoologica)
        {
            this.id = id;
            this.animal = animal;
            this.specie = specie;
            this.zonaHabitat = zonaHabitat;
            this.tipAlimentatie = tipAlimentatie;
            this.tipLocomotie = tipLocomotie;
            this.zonaGradinaZoologica = zonaGradinaZoologica;
        }
        public Animal(string animal, string specie, string zonaHabitat, string tipAlimentatie, string tipLocomotie, string zonaGradinaZoologica)
        {
            this.animal = animal;
            this.specie = specie;
            this.zonaHabitat = zonaHabitat;
            this.tipAlimentatie = tipAlimentatie;
            this.tipLocomotie = tipLocomotie;
            this.zonaGradinaZoologica = zonaGradinaZoologica;
        }
        public void setSpecie(string specie)
        {
            this.specie = specie;
        }
        public void setZonaHabitat(string zonaHabitat)
        {
            this.zonaHabitat = zonaHabitat;
        }
        public void setTipAlimentatie(string tipAlimentatie)
        {
            this.tipAlimentatie = tipAlimentatie;
        }
        public void setTipLocomotie(string tipLocomotie)
        {
            this.tipLocomotie = tipLocomotie;
        }
        public void setZonaGradinaZoologica(string zona)
        {
            zonaGradinaZoologica = zona;
        }
        public int getID()
        {
            return id;
        }
        public string getSpecie()
        {
            return specie;
        }
        public string getZonaHabitat()
        {
            return zonaHabitat;
        }
        public string getTipAlimentatie()
        {
            return tipAlimentatie;
        }
        public string getTipLocomotie()
        {
            return tipLocomotie;
        }
        public string getZonaGradinaZoologica()
        {
            return zonaGradinaZoologica;
        }
        public void setAnimal(string animal)
        {
            this.animal = animal;
        }
        public string getAnimal()
        {
            return animal;
        }
    }
}
