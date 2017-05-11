using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualAnimal
{
    public partial class VirtualAnimalMaterials : Form
    {
        public VirtualAnimalMaterials()
        {
            InitializeComponent();
        }

        private void btnMaterialsBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
