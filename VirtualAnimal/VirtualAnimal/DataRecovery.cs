using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    class DataRecovery
    {
        // Variables
        private bool _firstTime;
        private Dictionary<string, int> _dataToRecover_Animal;
        private List<string> _dataToRecover_Store;

        // Properties
        public Dictionary<string, int> DataToRecover_Animal
        {
            get { return _dataToRecover_Animal; }
            set { _dataToRecover_Animal = value; }
        }
        public bool FirstTime
        {
            get { return _firstTime; }
            set { _firstTime = value; }
        }
        public List<string> DataToRecover_Store
        {
            get { return _dataToRecover_Store; }
            set { _dataToRecover_Store = value; }
        }

        public DataRecovery()
        {
            FirstTime = true;
            DataToRecover_Animal = new Dictionary<string, int>();
            DataToRecover_Store =  new List<string>();
        }

        public void FileWritter(string FileName, string DataToSave)
        {
            StreamWriter Write;

            if (FirstTime == true)
            {
                Write = new StreamWriter(@"..\\..\\Resources\" + FileName, false);
                Write.WriteLine(DataToSave);
                Write.Close();
                FirstTime = false;
            }
            else
            {
                Write = new StreamWriter(@"..\\..\\Resources\" + FileName, true);
                Write.WriteLine(DataToSave);
                Write.Close();
            }
        }

        public void FileReader(string FileName)
        {
            StreamReader Read;

            Read = new StreamReader(@"..\\..\\Resources\" + FileName);
            List<string> Data = new List<string>();
            string LineBeingRead;

            if (FileName == "Save_Animal.txt")
            {
                Data.Clear();

                while ((LineBeingRead = Read.ReadLine()) != null)
                {
                    Data.Add(LineBeingRead);
                }

                Read.Close();

                DataToRecover_Animal.Add("Health", Convert.ToInt32(Data[0]));
                DataToRecover_Animal.Add("Energy", Convert.ToInt32(Data[1]));
                DataToRecover_Animal.Add("Happiness", Convert.ToInt32(Data[2]));
                DataToRecover_Animal.Add("Hygene", Convert.ToInt32(Data[3]));
            }

            if (FileName == "Store_Data.txt")
            {
                while ((LineBeingRead = Read.ReadLine()) != null)
                {
                    DataToRecover_Store.Add(LineBeingRead); 
                }
            }
        }
    }
}
