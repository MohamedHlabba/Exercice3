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
       
            return ("Name : " +Namn + " Vikt : " +Vikt + " Ålder :" +Ålder);
        }

        
        public Animal(string name,int ålder,double vikt)
        {
            Namn = name;
            Ålder = ålder;
            Vikt=vikt;
        }

    }

    class Dog : Animal
    {

        private string race;
        public string Race { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("The dog said : haw haw ! ");
        }
        public override string Stats()
        {
            return base.Stats()+(" Race : " +Race);
        }

        public string Eat()
        {
            return "  "+Namn+ " love to eat : Cooked Chicken and turkey meat. Bacon. Peanut butter";

        }

        public Dog (string race , string name,int ålder,double vikt):base(name, ålder,  vikt)
        {
            Race = race;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;
            
        }
    }

    class Horse : Animal
    {

        private string color;
        public String Color { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The horse said : Neigh !");
        }

        public override string Stats()
        {
            return base.Stats()+("Color : "+Color);
        }

        public Horse(string color,string name,int ålder,double vikt):base(name, ålder, vikt)
        {
            Color = color;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;


        }
    }

    class Hedgehog : Animal
    {

        private int nbrofspikes;
        public int NbrOfSpikes { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The Hedgehog said Oink oink");
        }

        public override string Stats()
        {
            return base.Stats()+("NbrOfSpikes : " +NbrOfSpikes);
        }

        public  Hedgehog(int nbrofspikes,string name,int ålder,double vikt):base(name,ålder,vikt)
        {
            NbrOfSpikes = nbrofspikes;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;
        }
    }

    class Worm : Animal
    {

        private bool ispoisonous;
        public bool IsPoisonous { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The worm said : Hisss !");
        }

        public override string Stats()
        {
            return base.Stats()+("IsPoisonous :" +IsPoisonous);
        }

        public Worm(bool ispoisonous,string name, int ålder,double vikt):base (name,ålder,vikt)
        {
            IsPoisonous = ispoisonous;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;

        }

    }
    class Bird : Animal
    {
        private string wingspan;
        public string WingSpan { get; set; }

        public override void DoSound()
        {
            Console.WriteLine("Te bird said :Tiw Tiw");
        }
        public override string Stats()
        {
            return base.Stats()+("WingSpan : " +WingSpan);
        }

        public Bird(string wingspan ,string name, int ålder, double vikt) :base(name,ålder,vikt)
        {
            WingSpan = wingspan;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;

        }
    }
    class Wolf : Animal
    {
        private string size;
        public string Size { get; set; }
        public override void DoSound()
        {
            Console.WriteLine("The wolf said : Awooooo!");
        }
        public override string Stats()
        {
            return base.Stats()+(" Size : " +Size);
        }
        public Wolf(string size,string name,int ålder,double vikt):base(name,ålder,vikt)
        {
            Size = size;
            Namn = name;
            Ålder = ålder;


        }
    }

    class Pelican​ : Bird

    {
        private string halspåse;
        public string Halspåse { get; set; }

        public override string Stats()
        {
            return base.Stats()+("Halspåse : "+Halspåse);
        }

        public override void DoSound()
        {
            base.DoSound();
        }

        public Pelican(string halspåse,string wingspan,string name,int ålder,double vikt):base(wingspan,name,ålder,vikt)
        {
            Halspåse = halspåse;
            WingSpan = wingspan;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;

        }

    }

    class Flamingo​ : Bird

    {
        private string domän;
        public string Domän { get; set; }

        public override string Stats()
        {
            return base.Stats()+(" Domän :" +Domän);
        }
        public override void DoSound()
        {
            base.DoSound();
        }
        public Flamingo(string domän, string wingspan, string name, int ålder, double vikt) : base(wingspan, name, ålder, vikt)

        {
            Domän = domän;
            WingSpan = wingspan;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;
        }
    }


    class Swan​ : Bird

    {
        private string family;
        public string Family { get; set; }

        public override string Stats()
        {
            return base.Stats()+("Family: "+Family);
        }
        public override void DoSound()
        {
            base.DoSound();
        }
        public Swan(string family ,string wingspan, string name, int ålder, double vikt) : base(wingspan, name, ålder, vikt)

        {
            Family = family;
            WingSpan = wingspan;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;
        }
    }

    interface IPerson 
    {

        string Talk();
        
   
    
    }


    class WolfMan : Wolf, IPerson
    {
        public string Talk() => "Hello i'm a man , yes i'm a real person i can talk "; 
       
        public WolfMan(string size,string name,int ålder,double vikt):base(size,name,ålder,vikt)
        {
            Size = size;
            Namn = name;
            Ålder = ålder;
            Vikt = vikt;

        }
    }

    //13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
    // vi bör lägga det nya attribut i Bird(Fåglar) klass

    //14.F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    //I djur klassen(Animal)
}


