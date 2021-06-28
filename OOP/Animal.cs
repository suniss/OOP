using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private double weight;



        public string Name
        {
            get { return name; }
            set { value = name; }
        }
        public int Age
        {
            get { return age; }
            set { value = age; }
        }
        public double Weight
        {
            get { return weight; }
            set { value = weight; }
        }

        public Animal()
        {
        }
        public Animal(string nam, int ag, double weg)
        {
            Name = nam;
            Age = ag;
            Weight = weg;
        }
        //public abstract void DoSound();

       public virtual string Stats()
        {
            return "This is animal: " + Name +
                "\nAnimalweights: " + Weight +
                "\nAnd this animal is " + Age + "years old";
        }

        //F13. Bird
        // F14.Animal
        //F9 . Hästen inherit från Animal inte Dog
        //F10  Class Aninal
        //F13 Alla djuren är inte inheret class abstract DoSound
        //F11 Varför är polymorfism viktigt : Polymorfism kan definiera en gränsnitt och kan har flera implementeringar
        //F12 Hur kan polymorfism förändra och förbättra kod via en bra struktur?
        //- A: polymorfism gör att du kan skriva program som bearbetar objekt som delar samma superklass (antingen direkt eller indirekt) som om de alla är objekt i superklassen; detta kan förenkla programmeringen
        //F 13 Skillnad melan abstract och interface är : abstract kan man skapa method som subclass kan implementera men inferface kan bara define funktion men kan inte implementera

    }


}

