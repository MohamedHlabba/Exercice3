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
            //personHandler.SavePerson(personHandler.CreatePerson(31, "Mohamed", "Hlabba", 178, 82));
            personHandler.SavePerson(personHandler.CreatePerson(31, "Mohamed", "Hlabba", 178, 82));
            personHandler.SavePerson(p2);
            personHandler.SavePerson(p3);
            personHandler.GetAllPersons();

            foreach (String resultat in personHandler.GetAllPersons())
            {
                Console.WriteLine(resultat,Color.YellowGreen);
                System.Console.WriteLine("***************************************************************");
            }

            foreach (String res in personHandler.FetchByName("Hlabba"))
            {
               // var res = personHandler.FetchByName("Be");
                System.Console.WriteLine(res);
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
