using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace VirtualAnimal
{
    class SaveAndUpdate
    {
        // Variables
        List<string> DataToUpdate = new List<string>();

        public SaveAndUpdate()
        {

        }

        private void FileWritter(string DataToSave)
        {
            StreamWriter Write = new StreamWriter(@"");

            Write.WriteLine(DataToSave);
        }

        private void FileReader()
        {
            //StreamReader Read = new StreamReader();
            //string LineBeingRead;

            //while ((LineBeingRead = Read.ReadLine()) != null)
            //{
            //    DataToUpdate.Add(LineBeingRead);
            //}
        }
    }
}
