/****************************************************************************
 * Author       : Jessica Sulzbach
 * Class        : I.In-P4B
 * Project      : TPI
 * Name         : Animal
 * Description  :
 * Last modified: 23.05.2017
 ****************************************************************************/
using System;
using System.Collections.Generic;
using System.Drawing;
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
        private string name;
        private int age;
        private DataRecovery _saveOrRecover;
        private List<Image> _anim;
        private int numImage;
        private Dictionary<int, double> gifts = new Dictionary<int, double>();

        public List<Image> Anim
        {
            get { return _anim; }
            set { _anim = value; }
        }

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

        public int NumImage
        {
            get { return numImage; }
            set { numImage = value; }
        }

        public Dictionary<int, double> Gifts
        {
            get { return gifts; }
            set { gifts = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Name
        {
            get{ return name; }
            set{ name = value; }
        }

        // Constructor
        public Animal()
        {
            SaveOrRecover = new DataRecovery();
            Anim = new List<Image>();
            AnimalRecover();
        }

        // Methods
        public void AnimalRecover()
        {
            SaveOrRecover.FileReader("Save_Animal.txt");
            this.Health = SaveOrRecover.DataToRecover_Animal["Health"];
            this.Hygene = SaveOrRecover.DataToRecover_Animal["Hygene"];
            this.Energy = SaveOrRecover.DataToRecover_Animal["Energy"];
            this.Happiness = SaveOrRecover.DataToRecover_Animal["Happiness"];
            this.Money = SaveOrRecover.DataToRecover_Animal["Money"];

            SaveOrRecover.FileReader("Animal_Age_Name.txt");
            this.Age=Convert.ToInt32(SaveOrRecover.SeperateData[1]);
            this.Name = SaveOrRecover.SeperateData[0];
        }

        public void AnimalSave(int Save)
        {
            SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(Save));
        }

        public void Animations(string Animation)
        {
            switch (Animation)
            {
                case "Idle":
                    {
                        NumImage = 0;
                        this.Anim.Clear();
                        for (int i = 0; i <= 2; i++)
                        {
                            string ImageName = "Idle" + i;
                            this.Anim.Add((Image)Properties.Resources.ResourceManager.GetObject(ImageName, Properties.Resources.Culture));
                        }
                        break;
                    }
                case "Walk":
                    {
                        Gifts.Clear();
                        Random rSec = new Random();
                        Random r = new Random();
                        int numberOfGifts = r.Next(1, 6);

                        for (int i = 0; i < numberOfGifts; i++)
                        {
                            int key = rSec.Next(1, 26);
                            if (!Gifts.ContainsKey(key))
                            {
                                Gifts.Add(key, r.Next(5, 51));
                            }
                            else
                            {
                                i--;
                            }
                        }

                        NumImage = 0;
                        this.Anim.Clear();
                        this.Anim.Add(Properties.Resources.walk0);
                        this.Anim.Add(Properties.Resources.walk1);

                        if (this.Happiness + 30 > 100)
                        {
                            this.Happiness = 100;
                        }
                        else
                        {
                            this.Happiness = this.Happiness + 30;
                        }
                        if (this.Hygene - 30 < 0)
                        {
                            this.Hygene = 0;
                        }
                        else
                        {
                            this.Hygene = this.Hygene - 30;
                        }
                        if (this.Energy - 30 < 0)
                        {
                            this.Energy = 0;
                        }
                        else
                        {
                            this.Energy = this.Energy - 30;
                        }
                        break;
                    }
                case "Happy":
                    {
                        NumImage = 0;
                        this.Anim.Clear();
                        for (int i = 0; i <= 8; i++)
                        {
                            string ImageName = "Happy" + i;
                            this.Anim.Add((Image)Properties.Resources.ResourceManager.GetObject(ImageName, Properties.Resources.Culture));
                        }
                        if (this.Happiness + 20 > 100)
                        {
                            this.Happiness = 100;
                        }
                        else
                        {
                            this.Happiness = this.Happiness + 20;
                        }
                        break;
                    }
                case "Eat":
                    {
                        NumImage = 0;
                        this.Anim.Clear();
                        this.Anim.Add(Properties.Resources.Eat1);
                        this.Anim.Add(Properties.Resources.Eat2);
                        if (this.Health + 40 > 100)
                        {
                            this.Health = 100;
                        }
                        else
                        {
                            this.Health = this.Health + 40;
                        }
                        break;
                    }
                case "Dead":
                    {
                        break;
                    }
                case "Shower":
                    {
                        NumImage = 0;
                        this.Anim.Clear();
                        for (int i = 0; i <= 7; i++)
                        {
                            string ImageName = "Shower" + i;
                            this.Anim.Add((Image)Properties.Resources.ResourceManager.GetObject(ImageName, Properties.Resources.Culture));
                        }
                        if (this.Hygene + 40 > 100)
                        {
                            this.Hygene = 100;
                        }
                        else
                        {
                            this.Hygene = this.Hygene + 40;
                        }
                        break;
                    }
                case "Brush":
                    {
                        NumImage = 0;
                        Anim.Clear();
                        this.Anim.Add(Properties.Resources.brush0);
                        this.Anim.Add(Properties.Resources.brush1);

                        if (this.Hygene + 20 > 100)
                        {
                            this.Hygene = 100;
                        }
                        else
                        {
                            this.Hygene = this.Hygene + 20;
                        }
                        break;
                    }
                case "Sleep":
                    {
                        NumImage = 0;
                        this.Anim.Clear();
                        for (int i = 0; i <= 18; i++)
                        {
                            string ImageName = "Sleep_Nap" + i;
                            this.Anim.Add((Image)Properties.Resources.ResourceManager.GetObject(ImageName, Properties.Resources.Culture));
                        }
                        this.Energy = 100;
                        break;
                    }
                case "Nap":
                    {
                        NumImage = 0;
                        this.Anim.Clear();
                        for (int i = 0; i <= 18; i++)
                        {
                            string ImageName = "Sleep_Nap" + i;
                            this.Anim.Add((Image)Properties.Resources.ResourceManager.GetObject(ImageName, Properties.Resources.Culture));
                        }
                        if (this.Energy + 40 > 100)
                        {
                            this.Energy = 100;
                        }
                        else
                        {
                            this.Energy = this.Energy + 40;
                        }
                        break;
                    }
                case "Death":
                    {
                        this.Anim.Clear();
                        for (int i = 0; i <= 4; i++)
                        {
                            string ImageName = "death" + i;
                            this.Anim.Add((Image)Properties.Resources.ResourceManager.GetObject(ImageName, Properties.Resources.Culture));
                        }
                        break;
                    }
                case "Born":
                    {
                        this.Anim.Clear();
                        for (int i = 0; i <= 8; i++)
                        {
                            string ImageName = "Born" + i;
                            this.Anim.Add((Image)Properties.Resources.ResourceManager.GetObject(ImageName, Properties.Resources.Culture));
                        }
                        this.Energy = 100;
                        this.Happiness = 100;
                        this.Health = 100;
                        this.Hygene = 100;
                        this.Money = 100;

                        break;
                    }
            }

        }

    }
}
