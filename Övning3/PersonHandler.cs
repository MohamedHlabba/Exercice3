﻿using System;
using System.Collections.Generic;
using System.Drawing;
using Console = Colorful.Console;

namespace Övning3
{
  public  class PersonHandler
    {

      public   List<Person> personers { get; set; }

        public PersonHandler()
        {
            personers = new List<Person>();
        }


        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person p = new Person(age, fname, lname, height, weight);
            return p;
        }
        public List<Person> SavePerson(Person p)
            
        {
            
            personers.Add(p);
           
            return personers;
        }  

        public List<String>GetAllPersons()
        {
            List<String> result = new List<String>();
           
                foreach (Person em in personers)
                {
                    result.Add("[First Name] :" +em.FName +" [last name] : "+em.LName +" [Age] : "+em.Age + " [Height] : "+em.Height+" [Weight] : "+em.Weight);
                }
                return result;
            }

       
        public List<String> FetchByName(string lname)
        {
            List<String> res = new List<String>();
            //List<Person> persons = new List<Person>();
            foreach (Person em in personers)
            {
                if(em.LName==lname)
                
                    res.Add("[First Name] :" + em.FName + " [last name] : " + em.LName + " [Age] : " + em.Age + " [Height] : " + em.Height + " [Weight] : " + em.Weight);
            }
           
            return res;

        }




    }



    
}
