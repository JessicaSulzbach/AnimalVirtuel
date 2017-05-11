using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    class Animal
    {
        //Variables
        private int _hygene = 100;
        private int _energy = 100;
        private int _health = 100;
        private int _happiness = 100;
        private double _money;
        
        // Properties 
        public int Hygene
        {
            get { return _hygene; }
            set { _hygene = value; }
        }
        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }
        public int Happiness
        {
            get { return _happiness; }
            set { _happiness = value; }
        }
        public double Money
        {
            get { return _money; }
            set { _money = value; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        // Constructor
        public Animal()
        {

        }

        // Methods
        public void Animations(int nbAnimation)
        {
            switch(nbAnimation)
            {
                case 0:
                    {
                        break;
                    }
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        break;
                    }
                case 3: 
                    {
                        break;
                    }
                case 4:
                    {
                        break;
                    }
                case 5:
                    {
                        break;
                    }
            }
        }
    }
}
