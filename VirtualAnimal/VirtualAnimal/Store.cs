using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    class Store
    {
        private DataRecovery _saveOrRecover;
        private Dictionary<string, double> _DataStore;

        public Dictionary<string, double> DataStore
        {
            get { return _DataStore; }
            set { _DataStore = value; }
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

            SaveOrRecover.FileReader("Store_Data.txt");

            StoreData();



        }

        public void StoreData()
        {
            DataStore.Clear();
            List<string> SeperateData = new List<string>();
            foreach (var item in SaveOrRecover.DataToRecover_Store)
            {
                SeperateData.AddRange(item.Split(';').ToList());

            }

            for (int i = 0; i < SeperateData.Count; i = i + 2)
            {
                for (int y = 1; y < SeperateData.Count; y = y + 2)
                {
                    DataStore.Add(SeperateData[i], Convert.ToDouble(SeperateData[y]));
                }
            }
            
        }


    }
}
