using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
    abstract class Animal
    {
        private string namn;
        private double vikt;
        private int ålder;

        public int Ålder { get; set; }
        public string Namn { get; set; }

        public double Vikt { get; set; }


        public abstract void DoSound();

        public virtual string Stats()
        {
       
            return ("Name " +Namn+ " Vikt "+Vikt +" Ålder " +Ålder);
        }

        
        public Animal()
        {

        }

    }

    class Dog : Animal
    {

        private string race;
        public string Race { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Haw haw");
        }
        public override string Stats()
        {
            return base.Stats()+(" Race " +Race);
        }
    }

    class Horse : Animal
    {

        private string color;
        public String Color { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Neigh");
        }

        public override string Stats()
        {
            return base.Stats()+("Color"+Color);
        }
    }

    class Hedgehog : Animal
    {

        private int nbrofspikes;
        public int NbrOfSpikes { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Oink oink");
        }

        public override string Stats()
        {
            return base.Stats()+("NbrOfSpikes : "+NbrOfSpikes);
        }
    }

    class Worm : Animal
    {

        private bool ispoisonous;
        public bool IsPoisonous { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Hiss");
        }

        public override string Stats()
        {
            return base.Stats()+("IsPoisonous"+IsPoisonous);
        }
    }
    class Bird : Animal
    {
        private string wingspan;
        public string WingSpan { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Tiw Tiw");
        }
        public override string Stats()
        {
            return base.Stats()+("WingSpan : "+WingSpan);
        }
    }
    class Wolf : Animal
    {
        private string size;
        public string Size { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("Awooooo");
        }
        public override string Stats()
        {
            return base.Stats()+(" Size"+Size);
        }
    }

    class Pelican​ : Bird

    {
        private string halspåse;
        public string Halspåse { get; set; }

        public override string Stats()
        {
            return base.Stats()+("Halspåse"+Halspåse);
        }

        public override void DoSound()
        {
            base.DoSound();
        }

    }

    class Flamingo​ : Bird

    {
        private string domän;
        public string Domän { get; set; }

        public override string Stats()
        {
            return base.Stats()+(" Domän :"+Domän);
        }
        public override void DoSound()
        {
            base.DoSound();
        }
    }


    class Swan​ : Bird

    {
        private string family;
        public string Family { get; set; }

        public override string Stats()
        {
            return base.Stats()+("Family"+Family);
        }
        public override void DoSound()
        {
            base.DoSound();
        }
    }

    interface IPerson 
    {

        void Talk();
        
   
    
    }


    class WolfMan : Wolf, IPerson
    {
        public void Talk()
        {
            Console.WriteLine(" waaaaaaa");
        }
        
    }

    //13. Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, ivilken klass bör vi lägga det?
    // vi bör lägga det nya attribut i Bird klass

    //14.F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    //I djur klassen
}


