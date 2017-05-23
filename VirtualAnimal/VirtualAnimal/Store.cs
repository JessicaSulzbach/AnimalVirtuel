﻿/****************************************************************************
 * Author       : Jessica Sulzbach
 * Class        : I.In-P4B
 * Project      : TPI
 * Name         : Animal
 * Description  :
 * Last modified: 23.05.2017
 ****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    public class Store
    {
        private DataRecovery _saveOrRecover;
        private Dictionary<string, double> _dataStore;

        public Dictionary<string, double> DataStore
        {
            get { return _dataStore; }
            set { _dataStore = value; }
        }

        public DataRecovery SaveOrRecover
        {
            get { return _saveOrRecover; }
            set { _saveOrRecover = value; }
        }

        public Store()
        {
            SaveOrRecover = new DataRecovery();
            DataStore = new Dictionary<string, double>();

            SaveOrRecover.FileReader("Product_name_and_price.txt");

            StoreData();
        }

        public void StoreData()
        {
            DataStore.Clear();
            for (int i = 0; i < SaveOrRecover.SeperateData.Count - 2; i = i + 3)
            {
                for (int y = 1; y < SaveOrRecover.SeperateData.Count; y = y + 3)
                {
                    DataStore.Add(SaveOrRecover.SeperateData[i], Convert.ToDouble(SaveOrRecover.SeperateData[y]));
                    if (i < SaveOrRecover.SeperateData.Count - 3)
                    {
                        i = i + 3;
                    }
                }
            }
        }

        public void Sell(List<int> NewQuantity, int TotalCost)
        {
            SaveOrRecover.FileReader("Product_name_and_price.txt");
            SaveOrRecover.FirstTime = true;

            List<int> OldQuantity = new List<int>();
            for (int i = 2; i < SaveOrRecover.SeperateData.Count; i = i + 3)
            {
                OldQuantity.Add(Convert.ToInt32(SaveOrRecover.SeperateData[i]));
            }
            for (int i = 0; i < NewQuantity.Count; i++)
            {
                NewQuantity[i] = NewQuantity[i] + OldQuantity[i];
            }

            for (int i = 0; i < SaveOrRecover.SeperateData.Count - 2; i++)
            {
                for (int y = 1; y < SaveOrRecover.SeperateData.Count - 1; y++)
                {
                    for (int j = 0; j <= NewQuantity.Count - 1; j++)
                    {
                        string FinalLineToSave = string.Format("{0};{1};{2}", SaveOrRecover.SeperateData[i], SaveOrRecover.SeperateData[y], NewQuantity[j]);
                        SaveOrRecover.FileWritter("Product_name_and_price.txt", FinalLineToSave);
                        if (i < SaveOrRecover.SeperateData.Count - 3)
                        {
                            i = i + 3;
                            y = y + 3;
                        }
                    }
                }
            }

            SaveOrRecover.FirstTime = true;
            SaveOrRecover.DataToRecover_Animal["Money"] = SaveOrRecover.DataToRecover_Animal["Money"] - TotalCost;
            foreach (var pair in SaveOrRecover.DataToRecover_Animal)
            {
                SaveOrRecover.FileWritter("Save_Animal.txt", Convert.ToString(pair.Value));
            }
            

        }

        public void Money()
        {
            SaveOrRecover.FileReader("Save_Animal.txt");
        }
    }
}
