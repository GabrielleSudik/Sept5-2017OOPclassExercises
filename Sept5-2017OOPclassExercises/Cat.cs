using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept5_2017OOPclassExercises
{
    class Cat
    {
        //these are fields. ie - descriptors
        //every cat will have these fields
        private string name;
        private string furColor;
        private int furLength;
        private bool isMale;
        private int age;
        private bool isHungry;
        //they are private so random schmucks don't have access to them.

        //properties
        //these are public
        //allows code outside the class to access fields
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

            public string FurColor
        {
            get { return this.furColor; }
            set { this.furColor = value; }
        }

        public int Age
        {
            get { return this.age; }
            //we won't use "set" here
            //not needed. sometimes you want set but no get.
        }
            //etc...

        //constructor:
            //this is the default constructor
        public Cat()
        {
            this.name = "Mittens";
            //if other names aren't set, the name will be Mittens
        }

            //this is an overloaded constructor:
            //it needs parameters
            //it doesn't need them for every field, tho
            //you can have more, so long as they have parameters
            //you'll need to specify the parameters when you create an instance using this constructor

        public Cat(string name, string furColor, int furLength, int age, bool isMale)
        {
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;

            //the this.thing part refer to the fields.
            //the other side of the = is passed from the parameters when a version of cat is created

        }

        public Cat(string name)
            //so this constructor will need the name only when an instance is created
        {
            this.name = name;
        }

        public Cat(int furLength)
        {
            this.furLength = furLength;
        }

        //public Cat(string furColor) //here's a thing:
        //    //because you already have one overloaded method with one string, 
        //    //you can't have another one with just one string.
        //    //you need two strings or a string and an int or whatever.
        //    //it's because the program won't know which string you're dealing with
        //    //this applies to any single type of variable
        //{
        //    this.furColor = furColor;
        //}

        //here is your own thought:
        //maybe good practice to have the default constructor,
        //and at least one other constructor will accept all parameters
        //because that will allow the greatest flexibility
        //although you'll have to define all parameters for each instance.

        //some programs use constructors to acquire things we need vs things we want
        //like, amazon needs your address. phone is optional.
    }
}
