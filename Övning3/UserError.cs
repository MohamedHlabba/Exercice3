using System;
using System.Collections.Generic;
using System.Text;

namespace Övning3
{
  abstract  class  UserError
    {

       public  abstract string UEMessage();


    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            string message ="you tried to use a numeric input in a text only field.This fired an error !";
            return message;
        } 
    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            string message = "You tried to use a text input in a numeric field.This fired an error !";
            return message;
        }
    }


    class MyfirstClass : UserError
    {
        public override string UEMessage()
        {
            string message = "You tried to";
            return message;
        }
    }



    class MySecondClass : UserError
    {
        public override string UEMessage()
        {
            string message = "";
            return message;
        }
    }
    class MyThirdClass : UserError
    {
        public override string UEMessage()
        {
            throw new NotImplementedException();
        }
    }
}
