using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMindGUI
{
    public partial class MasterMind : Form
    {
        #region Variables et constantes
        //pour faire le tableau des boutons de resultat
        const int MAX_TRIES = 10;
        int cmptr = 0;
        Button[,] resultTable;
        //des attributs des boutons de resultat
        const int BUTTON_SIZE = 25;
        //pour parcourir le tableau des boutons
        int currentLine = 0;
        int currentColumn = 0;
        //fonctionnement du jeu
        char[] stringColours;
        Random random = new Random();
        int r;//fonction++
        public int combLength;
        public string colours;
        string guess = "";
        int correctColours = 0;
        int correctPositions = 0;
        List<string> noRep = new List<string>();
        List<char> usedColours;
        #endregion

        //pour ouvrir autres formulaires
        Menu mainMenu;

        public MasterMind(Menu menu)
        {
            InitializeComponent();

            mainMenu = menu;
        }

        /// <summary>
        /// Evénement pour entrer des couleurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColor_Click(object sender, EventArgs e)
        {
            if(currentColumn == combLength)
            {
                MessageBox.Show("Vous avez entrez maximum des couleur");
            }
            else
            {  
                //récuperer des attributs d'un bouton appuyé
                Button btnColor = (Button)sender;

                //changer la couleur
                resultTable[currentLine, currentColumn].BackColor = btnColor.BackColor;
                resultTable[currentLine, currentColumn].Text = btnColor.Text;
                resultTable[currentLine, currentColumn].ForeColor = btnColor.ForeColor;

                //aller sur le bouton prochain
                currentColumn++;      
            }
        }

        /// <summary>
        /// Un événement pour effacer les couleurs entrées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnErase_Click(object sender, EventArgs e)
        {
            resultTable[currentLine, 0].BackColor = Color.Gray;
            resultTable[currentLine, 1].BackColor = Color.Gray;
            resultTable[currentLine, 2].BackColor = Color.Gray;
            resultTable[currentLine, 3].BackColor = Color.Gray;
            resultTable[currentLine, 0].Text = "";
            resultTable[currentLine, 1].Text = "";
            resultTable[currentLine, 2].Text = "";
            resultTable[currentLine, 3].Text = "";

            currentColumn = 0;
        }

        /// <summary>
        /// pour effacer un élément
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEraseOne_Click(object sender, EventArgs e)
        {
            if(currentColumn != 0)
            {
                currentColumn--;
                resultTable[currentLine, currentColumn].BackColor = Color.Gray;
                resultTable[currentLine, currentColumn].Text = "";
            }
            else
            {
                MessageBox.Show("Le tableau est déjà vide");
            }
        }

        

        /// <summary>
        /// le jeu-même
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterMind_VisibleChanged(object sender, EventArgs e)
        {
            //tableau de boutons
            resultTable = new Button[MAX_TRIES, combLength];
            //remplir le tableau avec des boutons
            for (int i = 0; i < MAX_TRIES; i++)
            {
                for (int j = 0; j < combLength; j++)
                {
                    cmptr++;

                    r = random.Next(5);

                    Button button = new Button();
                    button.Text = "";
                    button.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                    button.Location = new Point(j * BUTTON_SIZE * 2, i * BUTTON_SIZE * 2);
                    button.Name = "btnGuess" + cmptr;
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.Gray;
                    button.BackColor = Color.Gray;

                    //fonction++
                    if (r == 0)
                    {
                        button.Click += Boo;
                    }
                    else if (r == 1)
                    {
                        button.Click += LettreD;
                    }
                    else if (r == 2)
                    {
                        button.Click += LettreI;
                    }
                    else if (r == 3)
                    {
                        button.Click += LettreM;
                    }
                    else
                    {
                        button.Click += LettreA;
                    }

                    resultTable[i, j] = button;
                }
            }

            //afficher les boutons
            for (int i = 0; i < MAX_TRIES; i++)
            {
                for (int j = 0; j < combLength; j++)
                {
                    pnlResults.Controls.Add(resultTable[i, j]);
                }
            }

            //création d'un code à deviner
            //tableau pour stocker la combinaison
            stringColours = new char[combLength];

            //boucle qui se répète pour que la variable "stringColours" prenne des valeurs de "colours"
            for (int i = 0; i < stringColours.Length; i++)
            {
                stringColours[i] = colours[random.Next(colours.Length)];
            }
        }

        /// <summary>
        /// valider la réponse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValidate_Click(object sender, EventArgs e)
        {
            //des variables pour verifier bonne/mauvaise position
            correctColours = 0;
            correctPositions = 0;
            //initialiser une liste avec des couleurs utilisées 
            usedColours = new List<char>(stringColours);

            guess = "";

            //remplir le tableau de verification
            for (int i = 0; i < combLength; i++)
            {
                guess += resultTable[currentLine, i].Text;
            }

            //affichage d'erreur
            if (resultTable[currentLine, combLength-1].BackColor == Color.Gray)
            {
                MessageBox.Show("Veuillez entrer " + combLength + " couleurs");
            }
            //vérifier 
            else
            {
                //verifier chaque élément du tableau si c'est une bonne position
                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] == stringColours[i])
                    {
                        correctPositions++;
                        usedColours[i] = ' ';//marquer la couleur utilisée
                    }
                }

                //verifier chaque élément du tableau si c'est une mauvaise position
                for (int i = 0; i < guess.Length; i++)
                {
                    if (guess[i] != stringColours[i] && usedColours.Contains(guess[i]))
                    {
                        correctColours++;
                        usedColours[usedColours.IndexOf(guess[i])] = ' ';//marquer la couleur utilisée
                    }
                }

                for(int i = 0; i < 2; i++)
                {
                    if(i == 0)
                    {
                        Label label = new Label();
                        label.Text = "Bonnes positions: " + correctPositions.ToString();
                        label.Location = new Point(currentColumn * BUTTON_SIZE * 2, currentLine * BUTTON_SIZE * 2);
                        pnlResults.Controls.Add(label);
                    }
                    else
                    {
                        Label label = new Label();
                        label.Text = "Mauvaises: " + correctColours.ToString();
                        label.Location = new Point(currentColumn * BUTTON_SIZE * 2 + 120, currentLine * BUTTON_SIZE * 2);
                        pnlResults.Controls.Add(label);
                    }
                }
                
                //parcourir le tableau
                currentColumn = 0;
                currentLine++;

                //afficher le message si l'utilisateur a gagner
                if(correctPositions == combLength)
                {
                    MessageBox.Show("Vous avez gagnez!\n" +
                        "Appuyez sur \"Reset\" pour recommencer");
                    btnErase.Enabled = false;
                    btnEraseOne.Enabled = false;
                    btnValidate.Enabled = false;
                }
            }
        }

        /// <summary>
        /// pour débugage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cheatBox_CheckedChanged(object sender, EventArgs e)
        {  
            if(cheatBox.Checked == true)
            {
                for (int i = 0; i < combLength; i++)
                {
                    lblAnswer.Text += stringColours[i].ToString();
                }
            }
            else
            {
                lblAnswer.Text = "";
            }
        }

        /// <summary>
        /// fonction++ 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Boo(object sender, EventArgs e)
        {
            MessageBox.Show("Boo!");
        }

        /// <summary>
        /// fonction++ 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LettreD(object sender, EventArgs e)
        {
            MessageBox.Show("1:  -··");
        }

        /// <summary>
        /// fonction++ 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LettreI(object sender, EventArgs e)
        {
            MessageBox.Show("2:  ··");
        }

        /// <summary>
        /// fonction++ 4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LettreM(object sender, EventArgs e)
        {
            MessageBox.Show("3:  --");
        }

        /// <summary>
        /// fonction++ 5
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LettreA(object sender, EventArgs e)
        {
            MessageBox.Show("4:  ·-");
        }

        #region Reset et Retour
        /// <summary>
        /// pour recommencer le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        /// <summary>
        /// Quitter le jeu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            Reset();
            //ouvrir le menu
            mainMenu.Show();
            //fermer le jeu
            this.Hide();
        }

        /// <summary>
        /// méthode pour les boutons Reset et Retour
        /// </summary>
        void Reset()
        {
            //modifier la couleur et texte des boutons
            for (int i = 0; i < MAX_TRIES; i++)
            {
                for (int j = 0; j < combLength; j++)
                {
                    resultTable[i, j].Text = "";
                    resultTable[i, j].BackColor = Color.Gray;
                    resultTable[i, j].ForeColor = Color.Gray;
                }
            }

            //faire fonctionner des boutons
            btnValidate.Enabled = true;
            btnErase.Enabled = true;
            btnEraseOne.Enabled = true;

            //faire disparaitre des labels
            foreach (var lbl in pnlResults.Controls.OfType<Label>())//l'idée - https://stackoverflow.com/questions/31233558/c-sharp-hide-all-labels-controls
                lbl.Hide();

            //pour commencer avec le premier bouton
            currentColumn = 0;
            currentLine = 0;

            //récréer la combinaison
            for (int i = 0; i < stringColours.Length; i++)
            {
                stringColours[i] = colours[random.Next(colours.Length)];
            }
            cheatBox.Checked = false;
        }
        #endregion
    }
}
