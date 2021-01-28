using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;

namespace Övning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Person> persons = new List<Person>();
           //Person p = new Person();
           PersonHandler personHandler = new PersonHandler();

           var p1 =personHandler.CreatePerson(31,"Mohamed","Hlabba",178,82);
           var p2=  personHandler.CreatePerson(25,"Amine","Berkk",180,90);
           var p3=  personHandler.CreatePerson(63, "Sihem", "Darine", 190, 90);
            
            personHandler.SavePerson(p1);
            personHandler.SavePerson(p2);
            personHandler.SavePerson(p3);
            personHandler.GetAllPersons();

            foreach (String resultat in personHandler.GetAllPersons())
            {
                Console.WriteLine(resultat,Color.YellowGreen);
                Console.WriteLine("***************************************************************");
            }

            foreach (String res in personHandler.FetchByName("Hlabba")) 
            {
               
                Console.WriteLine(res);
            }
            //////////////////////////////////////////////////////////////////////



            List<Animal> animals = new List<Animal>();

            Bird bird = new Bird();
            bird.Namn = "Canarrii";
            bird.Vikt =0.004 ;
            bird.Ålder = 1;
            bird.WingSpan = " grå wingspan";

            Flamingo flamingo = new Flamingo();
            flamingo.Namn = "";
            flamingo.Vikt = 5;
            flamingo.Ålder = 1;
            flamingo.WingSpan = "Yellow";
            flamingo.Domän = "South ";
            



            Wolf wolf = new Wolf();
            wolf.Namn = "Lobbo";
            wolf.Vikt = 70;
            wolf.Ålder = 3;
            wolf.Size = "Big";
            
            Dog dog = new Dog();
            dog.Race= "Labrador";
            dog.Namn="Layka";
            dog.Vikt = 35;
            dog.Ålder = 2;

            animals.Add(dog);
            animals.Add(wolf);
            animals.Add(flamingo);
            animals.Add(bird);

            //public List<String> affichemplyee()
            //{
            //    List<String> result = new List<String>();
            //    foreach (Employe em in employes)
            //    {
            //        result.Add("employe name " + em.name + " employee salary : " + em.Salary);
            //    }
            //    return result;
            //}


            foreach (Animal a in animals)
            {
              string b= a.Stats();
               Console.WriteLine(b);
               a.DoSound();
                
                //if(a  is Person)
                //    {
                //     (a)WolfMan;
                //    }
                

            }



            //var t = dog.Stats();
            //System.Console.WriteLine(t);

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////


            List<UserError> userErrors = new List<UserError>();
            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();
            userErrors.Add(numericInputError);
            userErrors.Add(textInputError);

            foreach(UserError ue in userErrors)
            {
                //ue.UEMessage();
                Console.WriteLine(ue.UEMessage(),Color.RosyBrown);

            }





            

            //Console.WriteLine("Enter person Firstname");
            // var name =Console.ReadLine();
            //Console.WriteLine("Enter person lastname ");
            //var lstname = Console.ReadLine();
            //personHandler.CreatePerson(30,"ahmed","aymen",177,81);

            // personHandler.FetchByName("aymen");





            // var p = personHandler.CreatePerson(23,"Nermine","faaa",165,65);




            //try
            //{
            //    personHandler.SetAge(p, 0);
            //    p.LName = "";
            //    p.FName = "M";
            //    p.Age = 0;


            //Console.WriteLine("First name is : " + p.FName + " Last name is : " + p.LName + " and Age is : " + p.Age);

            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine("Message:" + exception.Message, Color.Red);
            //    Console.WriteLine("Stack Trace" + exception.StackTrace);

            //}

            //Console.Read();

        }
    }
}
