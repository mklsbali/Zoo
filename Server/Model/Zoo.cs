using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Model
{
    public class Zoo
    {
        private List<Utilizator> utilizatori;//contine si administartorii
        private List<Animal> animale;


        public Zoo()
        {
            utilizatori = new List<Utilizator>();
            animale = new List<Animal>();

        }
        public Zoo(List<Animal> animale, List<Utilizator> utilizatori)
        {
            this.animale = animale;
            this.utilizatori = utilizatori;
        }
        public List<Utilizator> getUtilizatori()
        {
            return utilizatori;
        }
        public void setUtilizatori(List<Utilizator> utilizatori)
        {
            this.utilizatori = utilizatori;
        }
        public List<Animal> getAnimale()
        {
            return animale;
        }
        public void setAnimale(List<Animal> animale)
        {
            this.animale = animale;
        }
        public void adaugareAnimal(Animal a)
        {
            if (a != null)
                animale.Add(a);
        }
        public bool contineAnimal(Animal a)
        {
            foreach(Animal animal in animale)
            {
                if (animal.getAnimal().Equals(a.getAnimal()))
                    return true;
            }
            return false;
        }
        public void adaugareUtilizator(Utilizator u)
        {
            utilizatori.Add(u);
        }


    }
}
