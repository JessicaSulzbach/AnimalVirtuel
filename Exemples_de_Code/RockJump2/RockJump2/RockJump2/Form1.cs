using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockJump2
{
    public partial class RockJump2 : Form
    {
        //les images
        List<Image> decor = new List<Image>();//la liste avec les 2 images du background
        int decor0X = 0;//la position en X de l'image decor0
        int decor1X = 1006;//la position en Y de l'image decor1
        //pour commencer
        bool start = false; // le booleen pour démarrer le jeu
        //pour sauter
        bool jump = false;//pour que le personnage saute
        //pour le score
        int score = 0;//pour le score
        int i = 0;//pour le score aussi
        //pour la vitesse
        int vitesse = 3;//pour augementer la vitesse des nuage
        //Pour les carrés
        Random alea = new Random();
        List<int> carre = new List<int>();
        int vitesseCarre = -3;//c'est la vitesse a laquelle les carrés se déplacent
        const int NbrCarre=8;//le nombre de carré dans le jeu
        int h = 0;// h est une variable qui me permet de compter le temps dans le timer
        bool pacOuvert;
        int z = 0;// z permet de compter le temps dans le timer
        public RockJump2()
        {
            InitializeComponent();
            DoubleBuffered = true;
        }

        private void RockJump2_Load(object sender, EventArgs e)//Quand le programme est chargé
        {
            // test est un nombre aléatoire entre 1006 et 1200
            decor.Add(Properties.Resources.décor0);//on ajoute l'image décor0 à la liste
            decor.Add(Properties.Resources.décor1);//on ajoute l'image décor1 à la liste
            carre.Add(1000 + alea.Next(100, 200));//on ajoute un nombre a 1000 + nombre aléatoire dans la liste
            for (int j = 1; j < NbrCarre; j++)//tant que j est plus petit que le nombre de carré
            {
                carre.Add(carre[j - 1] + 100 + alea.Next(100, 200));//on ajoute un carre avec la position d'avant + 100 et un nombre aléatoire
            }

        }

        private void RockJump2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(decor[0], decor0X, 0);//Pour dessiner l'image décor0
            e.Graphics.DrawImage(decor[1], decor1X, 0);//Pour dessiner l'image décor1

            for (int j = 0; j < NbrCarre; j++)//tant que j est plus petit que le nombre de carré
            {

                e.Graphics.DrawImage(Properties.Resources.carre, carre[j], 350);//on dessine un carre avec une position aleatoire en X


            }

        }

        private void tmr1_Tick(object sender, EventArgs e)//Quand le Timer fait tick
        {
            if (start == true)//si start est égale à true
            {
                //Pour le décor

                lblStart.Visible = false;//le text "appuyer sur start" disparait
                if (decor0X >= -1006)// si le decor0 en X est plus grand ou égal a -1006
                {
                    decor0X = decor0X - vitesse; // le décor est égal au décor moins la vitesse pour qu'il bouge
                }
                else
                {
                    decor0X = 996; //sinon on remet le décor a 996 (à cause du décalage)
                }
                if (decor1X >= -1006)//si le decor1 est plus grand ou égale a -1006
                {
                    decor1X = decor1X - vitesse;//le decor1 est égale au décor1 - la vitesse
                }
                else
                {
                    decor1X = 996;//sinon on remet le décor en 996 (pour le décalage)
                }
                this.Refresh();//on rafraichi la page
                
                //Pour le Score
                
                i = i+1;//on augmente i chaque tick 
                if (i == 10)//si i = 10
                {
                    score = score + 1;//on ajoute 1 au score
                    i = 0;//on remet i a zéro
                }
                
                //Pour que le score aille moins vite
                lblScore.Text = ("Score : " + score);//on met le score dans le label score

                //Pour le saut

                if (jump == true)//si jump est égal à true
                {
                    pibPlayer.Top += -4; //on monte de 4
                }
                if (pibPlayer.Top <= 220)//si le top est de 250
                {
                    jump = false; //on arrete de sauter
                }
                if (jump == false && pibPlayer.Top < 330)//si le saut est faux et que le top est plus petit a 330
                {
                    pibPlayer.Top += 4; //on le descent de 4
                }
                if (pibPlayer.Top >= 330)//si le top est plus grand ou égal a 330
                {
                    pibPlayer.Top = 330;//on le laisse ou remet a 330
                }
                
                //Pour les carré
                for (int j = 0; j < NbrCarre; j++)//tant que j est plus petit que 5 
                {

                    if (carre[j] < -26)//si le carré est plus petit que moins 26 (en dehors de l'écran
                    {
                        if (j == 0)//si j = 0
                            carre[j] = carre[carre.Count -1] + 100 + alea.Next(100, 200); //on remet le premier carré à la position du dernier carré  + un nombre aléatoire                                              
                        else
                            carre[j] = carre[j - 1] + 150 + alea.Next(100, 200);// sinon on prend la position du dernier carre, on lui rajoute 100 + un nombre aléatoire                                              

                    }
                    else
                        carre[j] += vitesseCarre;//sinon on avance le carré de -3 a chaque tick
                }
                h = h + 1;
                if (h == 1000)//si h est égale a 1000 (donc au score de 100)
                {
                    vitesseCarre = vitesseCarre -1;//la vitesse du carré augmente de -1
                    vitesse = vitesse + 1;//au augmente aussi la vitesse des nuages
                    h = 0;//on remet h a zéro
                }
                //Pour les collisions

               for (int j = 0; j < NbrCarre; j++)//tant que j est plus petit que le nombre de carré
			{
                    //si le joueur ne touche pas le carré
                if ((carre[j] >= pibPlayer.Left -10 + pibPlayer.Width)      // trop à droite
            || (carre[j] + carre[j] <= pibPlayer.Left +10) // trop à gauche
            || (350 >= pibPlayer.Top -5 + pibPlayer.Height) // trop en bas
            || (350 + 50 <= pibPlayer.Top+5))  // trop en haut
                {

                }
                else//sinon
                {
                    tmr1.Enabled = false;//on arrete le timer
                    DialogResult result = MessageBox.Show("Vous avez perdu !\nVotre score est de   " + score +"\n Voulez vous rejouer","vous avez perdu" , MessageBoxButtons.YesNo);//on lance une boite de dialogue qui affiche le score
                    switch (result)
                    {
                        case DialogResult.Yes://si on appuie sur oui, on relance l'application
                            Application.Restart();
                            break;
                        case DialogResult.No://sinon on quitte
                            Application.Exit();
                            break;
                    }
                    
                }
			}
               
               z++;//on augmente z de 1 a chaque tick
               if (z == 10)//si il est égale a 10
               {
                   pacOuvert = !pacOuvert;//pacman est différent de pacman
                   if (pacOuvert == true)// si c'est oui on met l'autre image
                   {
                       pibPlayer.Image = Properties.Resources.pac2;
                   }
                   else//sinon on laisse l'image par défaut
                   {
                       pibPlayer.Image = Properties.Resources.pac1;
                   }
                   z = 0;
               }

            }
        }

        private void RockJump2_KeyDown(object sender, KeyEventArgs e)//Lorsque l'on appuie sur une touche
        {
            if (e.KeyCode == Keys.Space && pibPlayer.Top == 330)//si l'on appuie sur la barre espace et que la position du joueur est a 330 (pour éviter les double sauts
            {
                if (start == false)// et que start est égal à false
                {
                    start = true;//on met start a true pour commencer le jeu
                    tmr1.Enabled = true;//on active le timer
                }
                else
                {
                    jump = true; //sinon on met jump a true pour faire sauter le personnage
                }
            }
        }



    }
}
