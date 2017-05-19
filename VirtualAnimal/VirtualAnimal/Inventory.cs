using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    public class Inventory
    {
        private DataRecovery _saveOrRecover;
        private Animal _TheAnimal;
        private Dictionary<string, int> _dataInventoryHALF;
        private Dictionary<string, int> _dataInventoryFULL;
        private string _product;

        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public const int LAST_OF_FOODS = 8;

        public Animal TheAnimal
        {
            get { return _TheAnimal; }
            set { _TheAnimal = value; }
        }
        public Dictionary<string, int> DataInventoryFULL
        {
            get { return _dataInventoryFULL; }
            set { _dataInventoryFULL = value; }
        }
        public const int LAST_OF_MATERIALS = 20;

        public Dictionary<string, int> DataInventoryHALF
        {
            get { return _dataInventoryHALF; }
            set { _dataInventoryHALF = value; }
        }

        public DataRecovery SaveOrRecover
        {
            get { return _saveOrRecover; }
            set { _saveOrRecover = value; }
        }

        

        public Inventory()
        {
            SaveOrRecover = new DataRecovery();
            TheAnimal = new Animal();
            DataInventoryHALF = new Dictionary<string, int>();
            DataInventoryFULL = new Dictionary<string, int>();

            SaveOrRecover.FileReader("Product_name_and_price.txt");
        }

        public void InventoryData()
        {
            DataInventoryFULL.Clear();
            for (int i = 0; i < SaveOrRecover.SeperateData.Count - 3; i = i + 3)
            {
                for (int y = 2; y <= SaveOrRecover.SeperateData.Count - 1; y = y + 3)
                {
                    DataInventoryFULL.Add(SaveOrRecover.SeperateData[i], Convert.ToInt32(SaveOrRecover.SeperateData[y]));
                    if (i < SaveOrRecover.SeperateData.Count - 3)
                    {
                        i = i + 3;
                    }
                }
            }
        }

        public void InventoryData(string NameView)
        {
            DataInventoryHALF.Clear();
            if (NameView == "Materials")
            {
                for (int i = 9; i < LAST_OF_MATERIALS - 2; i = i + 3)
                {
                    for (int y = 11; y <= LAST_OF_MATERIALS; y = y + 3)
                    {
                        DataInventoryHALF.Add(SaveOrRecover.SeperateData[i], Convert.ToInt32(SaveOrRecover.SeperateData[y]));
                        if (i < SaveOrRecover.SeperateData.Count - 3)
                        {
                            i = i + 3;
                        }
                    }
                }
            }
            if (NameView == "Food")
            {
                for (int i = 0; i < LAST_OF_FOODS - 2; i = i + 3)
                {
                    for (int y = 2; y <= LAST_OF_FOODS; y = y + 3)
                    {
                        DataInventoryHALF.Add(SaveOrRecover.SeperateData[i], Convert.ToInt32(SaveOrRecover.SeperateData[y]));
                        if (i < SaveOrRecover.SeperateData.Count - 3)
                        {
                            i = i + 3;
                        }
                    }
                }
            }
        }

        public void Use(string ProductName)
        {
            Product = ProductName;
        }

        public void Rewrite()
        {
            SaveOrRecover.FirstTime = true;

            for (int i = 0; i <= SaveOrRecover.SeperateData.Count - 3; i++)
            {
                for (int y = 1; y <= SaveOrRecover.SeperateData.Count - 2; y++)
                {
                    foreach (var pair in DataInventoryFULL)
                    {
                        string FinalLineToSave = string.Format("{0};{1};{2}", SaveOrRecover.SeperateData[i], SaveOrRecover.SeperateData[y], pair.Value);
                        SaveOrRecover.FileWritter("Product_name_and_price.txt", FinalLineToSave);
                        if (i < SaveOrRecover.SeperateData.Count - 3)
                        {
                            i = i + 3;
                            y = y + 3;
                        }
                    }
                }
            }
        }
    }
}
