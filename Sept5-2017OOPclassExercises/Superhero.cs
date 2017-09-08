using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept5_2017OOPclassExercises
{
    //four fields relating to superheros
    //four properties
    //three constructors
    //two + methods -- one decreases health, one increases health 

    class Superhero
    {
        //fields

        private string alterEgo;
        private int currentPower;
        private int maxPower;
        private int numberOfBattles;




        //properties

        public string AlterEgo
        {
            get { return this.alterEgo; }
            set { this.alterEgo = value; }
        }

        public int CurrentPower
        {
            get { return this.currentPower; }
            set { this.currentPower = value; }
        }

        public int MaxPower
        {
            get { return this.maxPower; }
        }

        public int NumberOfBattles
        {
            get { return this.numberOfBattles; }
        }

        //constructors

        public Superhero()
        {
            this.alterEgo = "Bag Lady";
            this.currentPower = 6;
            this.maxPower = 6;
            this.numberOfBattles = 0;
        }

        public Superhero(string alterEgo)
        {
            //this.alterEgo = "Butterfly Man";
            this.currentPower = 10;
            this.maxPower = 10;
            this.numberOfBattles = 0;
        }

        //methods

        public void FightEvil()
        {
            if(this.currentPower < 2)
            {
                Console.WriteLine("I'm too tired to fight. I need sleep.");
            }

            else
            {
                this.numberOfBattles += 1;
                this.currentPower -= 2;
                Console.WriteLine($"That battle was tough. My current power is {currentPower}.");
            }
        }

        public void Sleep()
        {
            Console.WriteLine("I just took a nap and now I feel great. I'm at max power!");
            this.currentPower = maxPower;
        }

        public void NextLevel()
        {
            if (numberOfBattles % 3 == 0) //let's only let level up every 3rd battle
            {
                this.maxPower += 5;  //increases max power by 5
                this.currentPower = maxPower;  //sets current power to max power
                Console.WriteLine("Congrats, you just leveled up!");
            }

            else
            {
                Console.WriteLine("You can't level up yet. Need more battles.");
            }
        }
    }
}
