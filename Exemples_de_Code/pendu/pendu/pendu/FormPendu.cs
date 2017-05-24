using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pendu
{
    public partial class FormPendu : Form
    {
        const int NBR_WORDS = 28;
        StreamReader file = new StreamReader(@"U:\M306\pendu\pendu\Resources\frenchList.txt");
        Random r = new Random();
        List<string> words = new List<string>();
        string line;
        string wordToFind;
        int lineCount = 0;
        int count = 0;
        int countForMe = 0;
        StringBuilder displayToPlayer;
        List<char> correctGuesses = new List<char>();

        public FormPendu()
        {
            InitializeComponent();
            
        }

        private void FormPendu_Load(object sender, EventArgs e)
        {
            fileReader();
        }

        private void fileReader()
        {
            while ((line = file.ReadLine()) != null)
            {
                words.Add(line);
                lineCount++;
            }
            wordPicker();
        }

        private void wordPicker()
        {
            wordToFind = "";
            count = 0;
            if (NBR_WORDS == lineCount)
            {
                wordToFind = words[r.Next(lineCount)];
                displayToPlayer = new StringBuilder(wordToFind.Length);
                for (int i = 0; i < wordToFind.Length; i++)
                {
                    displayToPlayer.Append('-');
                }
                tbxWord.Text = Convert.ToString(displayToPlayer);
            }
        }

        private void bntNew_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            btnQ.Visible = false;
            letterChecker(Convert.ToChar("Q"));
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            btnW.Visible = false;
            letterChecker(Convert.ToChar("W"));
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            btnE.Visible = false; 
            letterChecker(Convert.ToChar("E"));
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            btnR.Visible = false;
            letterChecker(Convert.ToChar("R"));
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            btnT.Visible = false;
            letterChecker(Convert.ToChar("T"));
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            btnZ.Visible = false;
            letterChecker(Convert.ToChar("Z"));
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            btnU.Visible = false;
            letterChecker(Convert.ToChar("U"));
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            
            btnI.Visible = false;
            letterChecker(Convert.ToChar("I"));
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            btnO.Visible = false;
            letterChecker(Convert.ToChar("O"));
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            btnP.Visible = false;
            letterChecker(Convert.ToChar("P"));
        }

        private void btnA_Click(object sender, EventArgs e)
        {           
            btnA.Visible = false;
            letterChecker(Convert.ToChar("A"));
        }

        private void btnS_Click(object sender, EventArgs e)
        {            
            btnS.Visible = false;
            letterChecker(Convert.ToChar("S"));
        }

        private void btnD_Click(object sender, EventArgs e)
        {            
            btnD.Visible = false;
            letterChecker(Convert.ToChar("D"));
        }

        private void btnF_Click(object sender, EventArgs e)
        {           
            btnF.Visible = false;
            letterChecker(Convert.ToChar("F"));
        }

        private void btnG_Click(object sender, EventArgs e)
        {         
            btnG.Visible = false;
            letterChecker(Convert.ToChar("G"));
        }

        private void btnH_Click(object sender, EventArgs e)
        {           
            btnH.Visible = false;
            letterChecker(Convert.ToChar("H"));
        }

        private void btnJ_Click(object sender, EventArgs e)
        {            
            btnJ.Visible = false;
            letterChecker(Convert.ToChar("J"));
        }

        private void btnK_Click(object sender, EventArgs e)
        {            
            btnK.Visible = false;
            letterChecker(Convert.ToChar("K"));
        }

        private void btnL_Click(object sender, EventArgs e)
        {           
            btnL.Visible = false;
            letterChecker(Convert.ToChar("L"));
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            btnY.Visible = false;
            letterChecker(Convert.ToChar("Y"));
        }

        private void btnX_Click(object sender, EventArgs e)
        { 
            btnX.Visible = false;
            letterChecker(Convert.ToChar("X"));
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnC.Visible = false;
            letterChecker(Convert.ToChar("C"));
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            btnV.Visible = false;
            letterChecker(Convert.ToChar("V"));
        }

        private void btnB_Click(object sender, EventArgs e)
        {           
            btnB.Visible = false;
            letterChecker(Convert.ToChar("B"));
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            btnN.Visible = false;
            letterChecker(Convert.ToChar("N"));
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            btnM.Visible = false;
            letterChecker(Convert.ToChar("M"));
        }

        private void letterChecker(char guessedLetter)
        {
            if (wordToFind.Contains(guessedLetter))
            {
                correctGuesses.Add(guessedLetter);
                for (int i = 0; i < wordToFind.Length; i++)
                {
                    if (Convert.ToString(wordToFind[i]) == Convert.ToString(guessedLetter))
                    {
                        displayToPlayer[i] = wordToFind[i];
                        tbxWord.Text = Convert.ToString(displayToPlayer);
                    }
                }
            }
            else
            {
                count++;
            }   

            switch (count)
            {
                case 1:
                    pbxHangMan.Image = pendu.Properties.Resources._1;
                    break;
                case 2:
                    pbxHangMan.Image = pendu.Properties.Resources._2;
                    break;
                case 3:
                    pbxHangMan.Image = pendu.Properties.Resources._3;
                    break;
                case 4:
                    pbxHangMan.Image = pendu.Properties.Resources._4;
                    break;
                case 5:
                    pbxHangMan.Image = pendu.Properties.Resources._5;
                    break;
                case 6:
                    pbxHangMan.Image = pendu.Properties.Resources._6;
                    break;
                case 7:
                    pbxHangMan.Image = pendu.Properties.Resources._7;
                    break;
                case 8:
                    pbxHangMan.Image = pendu.Properties.Resources._8;
                    break;
                case 9:
                    pbxHangMan.Image = pendu.Properties.Resources._9;
                    break;
                case 10:
                    pbxHangMan.Image = pendu.Properties.Resources._10;
                    break;
                case 11:
                    pbxHangMan.Image = pendu.Properties.Resources._11;
                    break;
            }
            checkIfLost(count);
            checkIfWon();
        }

        private void checkIfLost(int nbr)
        {
            if (nbr == 11)
            {
                MessageBox.Show("Vous avez perdu, le mot a trouvé était " + wordToFind, "Partie terminée!");
                restartGame();
            }
        }

        private void restartGame()
        {
            wordPicker();
            countForMe = 0;
            pbxHangMan.Image = null;
            correctGuesses.Clear();

            btnQ.Visible = true;
            btnW.Visible = true;
            btnE.Visible = true;
            btnR.Visible = true;
            btnT.Visible = true;
            btnZ.Visible = true;
            btnU.Visible = true;
            btnI.Visible = true;
            btnO.Visible = true;
            btnP.Visible = true;
            btnA.Visible = true;
            btnS.Visible = true;
            btnD.Visible = true;
            btnF.Visible = true;
            btnG.Visible = true;
            btnH.Visible = true;
            btnJ.Visible = true;
            btnK.Visible = true;
            btnL.Visible = true;
            btnY.Visible = true;
            btnX.Visible = true;
            btnC.Visible = true;
            btnV.Visible = true;
            btnB.Visible = true;
            btnN.Visible = true;
            btnM.Visible = true;

            btnHint.Enabled = true;
        }

        private void checkIfWon()
        {
            if (correctGuesses.Count == wordToFind.Length)
            {
                MessageBox.Show("Felicitations! Vous avez gagné!", "Partie gagné");
                restartGame();
            }
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            tbxWord.Text = wordToFind;
        }

        private void btnHint_Click(object sender, EventArgs e)
        {
            if (countForMe == 0)
            {
                displayToPlayer[0] = wordToFind[0];
                tbxWord.Text = Convert.ToString(displayToPlayer);
                countForMe++;
                btnHint.Text = "Indice : 1";
            }
            else if (countForMe == 1)
            {
                int i = wordToFind.Length - 1;
                displayToPlayer[i] = wordToFind[i];
                tbxWord.Text = Convert.ToString(displayToPlayer);
                countForMe = 0;
                btnHint.Text = "Indice : 0";
                btnHint.Enabled = false;
            }

        }

        private void tsmNew_Click(object sender, EventArgs e)
        {
            restartGame();
        }

        private void tsmAnswer_Click(object sender, EventArgs e)
        {
            tbxWord.Text = wordToFind;
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmFrench_Click(object sender, EventArgs e)
        {
            file = new StreamReader(@"\..\..\Resources\frenchList.txt");
        }

        private void tsmPortuguese_Click(object sender, EventArgs e)
        {
            file = new StreamReader(@"U:\M306\pendu\pendu\Resources\portugueseList.txt");
        }

        private void tsmEnglish_Click(object sender, EventArgs e)
        {
            file = new StreamReader(@"U:\M306\pendu\pendu\Resources\englishList.txt");
            fileReader();
        }
        
    }
}
