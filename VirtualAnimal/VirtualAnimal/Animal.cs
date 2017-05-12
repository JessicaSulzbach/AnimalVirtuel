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
        private int _hygene;
        private int _energy;
        private int _health;
        private int _happiness;
        private double _money;
        private DataRecovery _saveOrRecover;

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
        public DataRecovery SaveOrRecover
        {
            get { return _saveOrRecover; }
            set { _saveOrRecover = value; }
        }

        // Constructor
        public Animal()
        {
            SaveOrRecover = new DataRecovery();
            Animal_Recover();
        }

        // Methods
        public void Animal_Recover()
        {
            SaveOrRecover.FileReader("Save_Animal.txt");
            this.Health = SaveOrRecover.DataToRecover_Animal["Health"];
            this.Hygene = SaveOrRecover.DataToRecover_Animal["Hygene"];
            this.Energy = SaveOrRecover.DataToRecover_Animal["Energy"];
            this.Happiness = SaveOrRecover.DataToRecover_Animal["Happiness"];
        }

        public void Animal_Save(int SavePrbHealth, int SavePrbHygene, int SavePrbEnergy, int SavePrbHappyiness)
         {
             SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(SavePrbHealth));
             SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(SavePrbHygene));
             SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(SavePrbEnergy));
             SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(SavePrbHappyiness));
        }

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
