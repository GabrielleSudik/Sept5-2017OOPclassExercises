using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept5_2017OOPclassExercises
{
    class Dog
    {

        //fields

        private int hairLength;
        private int height;
        private int runningSpeed;
        private int weight;

        //properties

        public int HairLength { get; set; }
        public int Height { get; set; }
        public int RunningSpeed { get; set; }
        public int Weight { get; set; }

        //constructors

        public Dog()
        {
            this.hairLength = 1;
            this.height = 18;
            this.runningSpeed = 4;
            this.weight = 25;
        }

        public Dog(int hairLength, int height, int runningSpeed, int weight)
        {
            this.hairLength = hairLength;
            this.height = height;
            this.runningSpeed = runningSpeed;
            this.weight = weight;
        }

        //methods

            public void Run()
        {
            Console.WriteLine($"That dog runs only {this.runningSpeed} miles an hour. How disappointing.");
        }

        public void Bark()
        {
            Console.WriteLine($"Dogs of {this.height} inches are unable to bark. How sad.");
        }

        public void Potty()
        {
            Console.WriteLine($"Your dumb {this.weight} pound dog just pooped all over the carpet!");
        }

        public void Cuddle()
        {
            Console.WriteLine($"No one wants to cuddle a dog with hair {this.hairLength} inches long. Ugh.");
        }

    }
}
