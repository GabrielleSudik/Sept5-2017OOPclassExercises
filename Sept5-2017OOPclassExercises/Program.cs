﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept5_2017OOPclassExercises
{
    class Program

        //something basic:
        //() indicates that something is a method
        //eg, Console.WriteLine() is a method
        //eureka

        //classes contain:
        //fields (variables that belong to the class)
        //properties (like fields but allow access to fields)
        //methods (what they do, repeatable and reusable code)
        //constructors
        
        //Cat mittens = new Cat();

    //to create a new class: right click second tier down off to the right
    //click add, scroll down, select class, name it.
    //it'll be in a different tab

    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();  //uses default constructor
            Cat cat2 = new Cat("Neko", "black", 1, 4, false); //using other constructor
                                                              //hovering on () will show what you need to pass

            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Name);

            cat1.Name = "Snowy"; //this changes the name
            cat2.Name = "Lance"; //same

            cat1.FurColor = "grey";

            Console.WriteLine(cat1.Name);
            Console.WriteLine(cat2.Name);

            Console.WriteLine(cat1.FurColor);

            Console.WriteLine(cat1.Age); //we will get 0 because we don't set it, so default is 0.
            Console.WriteLine(cat2.Age);

            Cat cat3 = new Sept5_2017OOPclassExercises.Cat("Billy");

            Console.WriteLine(cat3.Name);

            Console.ReadLine();
        }
    }
}
