/****************************************************************************
 * Author       : Jessica Sulzbach
 * Class        : I.In-P4B
 * Project      : TPI - Virtual animal
 * Name         : Inventory
 * Description  : This class manages the add and subtract of products  
 * Last modified: 23.05.2017
 ****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    public class Inventory
    {
        #region Variables
        // Variables
        private DataRecovery _saveOrRecover;
        private Dictionary<string, int> _dataInventoryHALF;
        private Dictionary<string, int> _dataInventoryFULL;
        private string _product;
        #endregion

        #region Properties
        // Properties
        public string Product
        {
            get { return _product; }
            set { _product = value; }
        }

        public const int LAST_OF_FOODS = 8;

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
        #endregion

        #region Constructor
        // Constructor
        public Inventory()
        {
            // Initiates
            SaveOrRecover = new DataRecovery();
            DataInventoryHALF = new Dictionary<string, int>();
            DataInventoryFULL = new Dictionary<string, int>();

            SaveOrRecover.FileReader("Product_name_and_price.txt");
        }
        #endregion

        #region Methods
        // Methods
        /// <summary>
        /// Adds all the products data to the list
        /// </summary>
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

        /// <summary>
        /// Adds certain product data to the list
        /// </summary>
        /// <param name="NameView">Type of products</param>
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

        /// <summary>
        /// Initiates the Product variable with the name of the products
        /// This will be usefull when calling an animation
        /// </summary>
        /// <param name="ProductName">The selected products name</param>
        public void Use(string ProductName)
        {
            Product = ProductName;
        }

        /// <summary>
        /// Rewrites the Save_Aniaml text file with the new quantity
        /// </summary>
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

        /// <summary>
        /// Rewrites the Save_Aniaml text file with all quantities at 0
        /// For starting new game
        /// </summary>
        public void RewriteNew()
        {
            InventoryData();
            SaveOrRecover.FirstTime = true;

            for (int i = 0; i <= SaveOrRecover.SeperateData.Count - 3; i++)
            {
                for (int y = 1; y <= SaveOrRecover.SeperateData.Count - 2; y++)
                {
                    foreach (var pair in DataInventoryFULL)
                    {
                        string FinalLineToSave = string.Format("{0};{1};{2}", SaveOrRecover.SeperateData[i], SaveOrRecover.SeperateData[y], 0);
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
        #endregion
    }
}
