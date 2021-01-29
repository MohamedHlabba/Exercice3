using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
   public  class Person
    {
        private string fName;
        private string lName;
        private int age;
        private double height;
        private double weight;

        public int Age

        {
            get =>age ;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Age cannot be null !!!!!!");
                }
                
                age = value;

            }
        }

       




        public string FName
        {
            get => fName;

            set
            {
               if (value.Length <2 || value.Length >10)
                {
                    
                    throw new ArgumentOutOfRangeException("Firstname is  on wrong format");
                   
                }
               
                fName = value;


            }

        }
        public string LName
        {
            get => lName;

            set
            {
                if (value.Length < 3 || value.Length > 15)
                {

                    
                    throw new ArgumentOutOfRangeException("Lastname is  on wrong format");

                }

                lName = value;


            }

        }





        //public string LName


        //{
        //    get => lName;

        //    set
        //    {
        //        if (value.Length < 3 || value.Length >15)
        //        {
        //            throw new ArgumentException("The format of the last name is not valid ");
        //            //throw new ArgumentOutOfRangeException("Last name cannot be that long !");

        //        }
        //        lName = value;

        //    }
        //}

        public double Height { get; set; }
        public double Weight { get; set; }



        public Person(int age, string fname, string lname, double height, double weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Height = height;
            Weight = weight;
    }
        public Person()
        { 
        
        }

        public override string ToString()
        {
            return "Age : " +Age+ " FirstName :"+FName+"LastName : "+LName+  "Height : " +Height+"  Weight"+Weight ;
        }



    }



}

    

