using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    public class Animal
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
            //this.Money = SaveOrRecover.DataToRecover_Animal["Money"];
        }

        public void Animal_Save(int SavePrbHealth, int SavePrbHygene, int SavePrbEnergy, int SavePrbHappyiness)
         {
             SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(SavePrbHealth));
             SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(SavePrbHygene));
             SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(SavePrbEnergy));
             SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(SavePrbHappyiness));
        }

        public void Animations(string Animation)
        {
            switch(Animation)
            {
                case "Idle":
                    {
                        break;
                    }
                case "Walk":
                    {
                        this.Happiness = this.Happiness + 3;
                        this.Energy = this.Energy - 3;
                        this.Hygene = this.Hygene - 3;
                        break;
                    }
                case "Happy":
                    {
                        this.Happiness = this.Happiness + 1;
                        break;
                    }
                case "Eat":
                    {
                        this.Health = this.Health + 2;
                        break;
                    }
                case "Dead":
                    {
                        break;
                    }
                case "Shower":
                    {
                        this.Hygene = this.Hygene + 2;
                        break;
                    }
                case "Brush":
                    {
                        this.Hygene = this.Hygene + 1;
                        break;
                    }
                case "Sleep":
                    {
                        this.Energy = 100;
                        break;
                    }
                case "Nap":
                    {
                        this.Energy = this.Energy + 2;
                        break;
                    }
                case "House_Backgroud":
                    {
                        break;
                    }
                case "Street_Backgroud":
                    {
                        break;
                    }
            }
            
        }

    }
}
