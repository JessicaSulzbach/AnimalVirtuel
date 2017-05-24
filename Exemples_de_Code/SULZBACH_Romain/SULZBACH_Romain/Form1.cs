using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SULZBACH_Romain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            int chiffre = Convert.ToInt32(textBox1.Text);

            if (chiffre <= 3999 && chiffre > 0)
            {
                uint chiffre1 = Convert.ToUInt32(chiffre);
                lblResult.Text = Convert.ToString(Convertisseur(chiffre1));
            }
            else
            {
                MessageBox.Show("Veuillez rentrer un chiffre entre 1 et 3999.", "Erreur",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string Convertisseur(uint chiffre)
        {
            string chiffreRomain = "";

            // Tableau romain
            char[,] chiffreRomainLettre = new char[4, 3] { { 'M', '\0', '\0' }, { 'C', 'D', 'M' }, { 'X', 'L', 'C' }, { 'I', 'V', 'X' } };

            // Tableau decimale
            uint[] numeration = new uint[4] { 1000, 100, 10, 1 };

            for (int i = 0; i < numeration.Length; i++)
            {
                if (chiffre >= numeration[i])
                {
                    // Prend le premier nombre du chiffre pour pouvoir le traiter
                    int firstChiffre = Convert.ToInt32(chiffre.ToString()[0].ToString());

                    // Ajoute les bon caractère romain en fonction du premier chiffre
                    switch (firstChiffre)
                    {
                        case 1:
                        case 2:
                        case 3:
                            // S'occupe des formats 1000: M, MM, MM; 100: C, CC, CCC; 10: X, XX, XXX; 1: I, II, III
                            for (int j = 0; j < firstChiffre; j++)
                            {
                                chiffreRomain += chiffreRomainLettre[i, 0];
                            }
                            break;
                        case 4:
                            // S'occupe des formats 100: CD; 10: XL; 1: IV
                            chiffreRomain += chiffreRomainLettre[i, 0];
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            break;
                        case 5:
                            // S'occupe des formats 100: D; 10: L; 1: V
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            break;
                        case 6:
                        case 7:
                        case 8:
                            // S'occupe des formats 100: DC, DCC, DCCC; 10: LX, LXX, LXX; 1: VI, VII, VIII
                            chiffreRomain += chiffreRomainLettre[i, 1];
                            for (int j = 0; j < firstChiffre - 5; j++)
                            {
                                chiffreRomain += chiffreRomainLettre[i, 0];
                            }
                            break;
                        case 9:
                            // S'occupe des formats 100: CM; 10: XC; 1: IX;
                            chiffreRomain += chiffreRomainLettre[i, 0];
                            chiffreRomain += chiffreRomainLettre[i, 2];
                            break;
                    }
                }

                // Réduit à la numération inférieur
                chiffre %= numeration[i];
            }

            return chiffreRomain;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Filtre le texte box : accepte que des chiffres
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsPunctuation(e.KeyChar)) e.Handled = true;
        }
    }
}
