/****************************************************************************
 * Author       : Jessica Sulzbach
 * Class        : I.In-P4B
 * Project      : TPI - Virtual animal
 * Name         : DataRecovery
 * Description  : This class recuperates the data and rewrite it
 * Last modified: 23.05.2017
 ****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    public class DataRecovery
    {
        #region Variables
        // Variables
        // Bool to append or not
        private bool _firstTime;
        // List where the seperate ( without ; ) data is added
        private List<string> _seperateData;
        private Dictionary<string, int> _dataToRecover_Animal;

        #endregion

        #region Properties
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
        public List<string> SeperateData
        {
            get { return _seperateData; }
            set { _seperateData = value; }
        }
        #endregion

        #region Constructor
        // Constructor
        public DataRecovery()
        {
            FirstTime = true;
            //Initiate
            DataToRecover_Animal = new Dictionary<string, int>();
            SeperateData = new List<string>();
        }
        #endregion

        /// <summary>
        /// Writtes in the text files
        /// </summary>
        /// <param name="FileName">The files name</param>
        /// <param name="DataToSave">Test to be writen</param>
        public void FileWritter(string FileName, string DataToSave)
        {
            StreamWriter Write;
            // The text file will be cleared before writing
            if (FirstTime == true)
            {
                Write = new StreamWriter(@"..\\..\\Resources\" + FileName, false);
                Write.WriteLine(DataToSave);
                Write.Close();
                FirstTime = false;
            }
            // The text file will not be cleared before writing
            // The text will be added at the end of the text file
            else
            {
                Write = new StreamWriter(@"..\\..\\Resources\" + FileName, true);
                Write.WriteLine(DataToSave);
                Write.Close();
            }
        }

        /// <summary>
        /// Reads texte files and according to the file name saves the data in lists 
        /// and then closes the file
        /// </summary>
        /// <param name="FileName">The files name</param>
        public void FileReader(string FileName)
        {
            StreamReader Read;
            Read = new StreamReader(@"..\\..\\Resources\" + FileName);
            // List of the data by line
            List<string> Data = new List<string>();
            SeperateData.Clear();
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
                DataToRecover_Animal.Add("Hygene", Convert.ToInt32(Data[1]));
                DataToRecover_Animal.Add("Energy", Convert.ToInt32(Data[2]));
                DataToRecover_Animal.Add("Happiness", Convert.ToInt32(Data[3]));
                DataToRecover_Animal.Add("Money", Convert.ToInt32(Data[4]));
            }
            if (FileName == "Product_name_and_price.txt")
            {
                while ((LineBeingRead = Read.ReadLine()) != null)
                {
                    Data.Add(LineBeingRead);
                }

                foreach (var item in Data)
                {
                    SeperateData.AddRange(item.Split(';').ToList());
                }

                Read.Close();
            }
            if (FileName == "Animal_Age_Name.txt")
            {
                while ((LineBeingRead = Read.ReadLine()) != null)
                {
                    SeperateData.Add(LineBeingRead);
                }

                Read.Close();
            }
        }
    }
}
