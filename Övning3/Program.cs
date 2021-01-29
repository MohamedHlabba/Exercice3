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


            try
            {

                var p1 = personHandler.CreatePerson(31, "Mohamed", "Hlabba", 178, 82);
                var p2 = personHandler.CreatePerson(25, "Amine", "Berkk", 180, 90);
                var p3 = personHandler.CreatePerson(63, "Sihem", "Darine", 190, 90);
                var p4 = personHandler.CreatePerson(70, "Mary", "kevinn", 166, 75);

                var p5 = personHandler.CreatePerson(20, "George", "Magnum", 192, 99);
                personHandler.SetAge(p5, 28);
                personHandler.SavePerson(p1);
                personHandler.SavePerson(p2);
                personHandler.SavePerson(p3);
                personHandler.SavePerson(p4);
                personHandler.SavePerson(p5);


                personHandler.DeletePerson(p2);


            }

            catch (Exception exception)
            {

                Console.WriteLine("Message:" + exception.Message, Color.Red);
                Console.WriteLine("Stack Trace" + exception.StackTrace);
            }


            finally
            {


                foreach (String resultat in personHandler.GetAllPersons())
                {
                    Console.WriteLine(resultat, Color.YellowGreen);
                    Console.WriteLine("***************************************************************");
                }

                foreach (String res in personHandler.FetchByLastName("Darine"))
                {

                    Console.WriteLine(res);
                    Console.WriteLine("***************************************************************");
                }


            } 

 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

            List<Animal> animals = new List<Animal>();

            Bird bird = new Bird(" grå wingspan", "Canarrii",1,0.004);
           

            Flamingo flamingo = new Flamingo("South Africa", "Yellow", "flamingoos", 1, 5);
           
            



            Wolf wolf = new Wolf("Big","Lobbo",3,70);
         
            
            Dog dog1 = new Dog("Labrador","Layka",2,35);
            Dog dog2 = new Dog("Chiwawa", "Luna", 1,3);
            Dog dog3 = new Dog("Husky","Beau",3,28);


            animals.Add(dog1);
            animals.Add(dog2);
            animals.Add(dog3);
            animals.Add(wolf);
            animals.Add(flamingo);
            animals.Add(bird);
            

            WolfMan wolfman = new WolfMan("Big","The wolfman",5,100); 
            animals.Add(wolfman);

            foreach (Animal animal in animals)
            {
              string b= animal.Stats();
               Console.WriteLine(b,Color.Cyan);
              
                animal.DoSound();
                Console.WriteLine("************************************************************");
                

                //7
                if (animal is IPerson)
                {
                   IPerson man = (IPerson)animal;
                   Console.WriteLine(man.Talk());
                }
                

            }

            List<Dog> dogs = new List<Dog>();
            Horse horse = new Horse("Beige", "Bouras", 5, 300);


            ///9.F Det funkar inte eftersom dog och horse are inte på samma typ.
            ///10.F För att lösa det här måste listan vara av typ Animal så på så sätt kan vi lagra alla sorter av  djur
            //dogs.Add(horse);



            //foreach (Animal a in animals)

            //{
            //    if (a is Dog)
                  
            //    Console.WriteLine(a.Stats(),Color.Red);
               
            //    ////16.Jag kommer inte åt Eat()metoden 17.eftersom den är specifik bara för dogs klass
            //    //********** Console.WriteLine(a.eat);************
               
            //}

            ///18.Ett säkert sätt är att casta animal till dog
           foreach (Animal a in animals)
                if (a is Dog)
                {
                    Dog dog = (Dog)a;
                    Console.WriteLine(dog.Stats(), Color.Red);
                    
                     Console.WriteLine(dog.Eat());
               }








            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            List<UserError> userErrors = new List<UserError>();

            NumericInputError numericInputError = new NumericInputError();
            TextInputError textInputError = new TextInputError();

            MyfirstClass class1 = new MyfirstClass();
            MySecondClass class2 = new MySecondClass();
            MyThirdClass class3 = new MyThirdClass();


            userErrors.Add(numericInputError);
            userErrors.Add(textInputError);
            
            
            userErrors.Add(class1);
            userErrors.Add(class2);
            userErrors.Add(class3);


            foreach(UserError ue in userErrors)
            {
               
                Console.WriteLine(ue.UEMessage(),Color.RosyBrown);

            }
            
            


            



///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            

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
