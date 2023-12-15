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
        Button[,] resultTable;
        Button[,] resultPositionsTable;
        //des attributs des boutons de resultat
        const int BUTTON_SIZE = 25;
        const int POSITION_BUTTON_SIZE = 16;
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
        string[] noRep;
        List<char> usedColours;
        int cmptr;//pour remplir le tableau des positions
        int noRepCmptr;
        //cosmetique
        public bool showNumbers;
        public bool showLetters;
        public int languageChoice;
        #endregion

        //pour ouvrir autres formulaires
        Menu mainMenu;

        public MasterMind(Menu menu)
        {
            InitializeComponent();

            mainMenu = menu;
        }

        #region Colours
        /// <summary>
        /// Méthode pour entrer des couleurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnColor_Click(object sender, EventArgs e)
        {
            if(currentColumn == combLength)
            {
                if(languageChoice == 0)
                {
                    MessageBox.Show("Vous avez entrez maximum de couleurs");
                }
                if(languageChoice == 1)
                {
                    MessageBox.Show("You have entered maximum of colors");
                }
                if(languageChoice == 2)
                {
                    MessageBox.Show("Ви ввели максимум кольорів");
                }
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
        /// Méthode pour effacer les couleurs entrées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnErase_Click(object sender, EventArgs e)
        {
            if(currentColumn != 0)
            {
                for (int j = combLength-1; j >= 0; j--)
                {
                    resultTable[currentLine, j].BackColor = Color.Gray;
                    resultTable[currentLine, j].Text = "";
                }

                currentColumn = 0;
            }
            else
            {
                if(languageChoice == 0)
                {
                    MessageBox.Show("Le tableau est déjà vide");
                }
                if(languageChoice == 1)
                {
                    MessageBox.Show("The table is already empty");
                }
                if(languageChoice == 2)
                {
                    MessageBox.Show("Таблиця вже пуста");
                }
            }
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
                if (languageChoice == 0)
                {
                    MessageBox.Show("Le tableau est déjà vide");
                }
                if (languageChoice == 1)
                {
                    MessageBox.Show("The table is already empty");
                }
                if (languageChoice == 2)
                {
                    MessageBox.Show("Таблиця вже пуста");
                }
            }
        }
        #endregion

        /// <summary>
        /// le jeu-même
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MasterMind_Load(object sender, EventArgs e)
        {
            #region Size&Location
            //changer la taille et position d'éléments
            this.Size = new Size(this.Width + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), this.Height);
            pnlResults.Size = new Size(pnlResults.Width + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), pnlResults.Height);
            pnlPositionsResults.Location = new Point(pnlPositionsResults.Location.X + (combLength - 2) * BUTTON_SIZE + 18 * (combLength - 2), pnlPositionsResults.Location.Y);
            btnValidate.Location = new Point(btnValidate.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnValidate.Location.Y);
            btnErase.Location = new Point(btnErase.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnErase.Location.Y);
            btnEraseOne.Location = new Point(btnEraseOne.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnEraseOne.Location.Y);
            btnRed.Location = new Point(btnRed.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnRed.Location.Y);
            btnGreen.Location = new Point(btnGreen.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnGreen.Location.Y);
            btnBlue.Location = new Point(btnBlue.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnBlue.Location.Y);
            btnYellow.Location = new Point(btnYellow.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnYellow.Location.Y);
            btnOrange.Location = new Point(btnOrange.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnOrange.Location.Y);
            btnCyan.Location = new Point(btnCyan.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnCyan.Location.Y);
            btnMagenta.Location = new Point(btnMagenta.Location.X + (combLength - 2) * BUTTON_SIZE + 13 * (combLength - 2), btnMagenta.Location.Y);
            #endregion

            //langue
            if(languageChoice == 0)
            {
                lblExemple1.Text = "- bonne position"; 
                lblExemple2.Text = "- mauvaise position"; 
                lblExemple3.Text = "- rien";
                btnReset.Text = "Reset";
                btnReturnMenu.Text = "Retour au menu";
                btnValidate.Text = "Valider";
                btnErase.Text = "Effacer tout";
                btnEraseOne.Text = "Effacer";
                cheatBox.Text = "Tricher";
                btnRed.Text = "R";
                btnGreen.Text = "V";
                btnBlue.Text = "B";
                btnYellow.Text = "J";
                btnOrange.Text = "O";
                btnCyan.Text = "C";
                btnMagenta.Text = "M";
            }
            if(languageChoice == 1)
            {
                lblExemple1.Text = "- good position";
                lblExemple2.Text = "- bad position";
                lblExemple3.Text = "- nothing";
                btnReset.Text = "Reset";
                btnReturnMenu.Text = "Return to menu";
                btnValidate.Text = "Validate";
                btnErase.Text = "Erase all";
                btnEraseOne.Text = "Erase";
                cheatBox.Text = "Cheat";
                btnRed.Text = "R";
                btnGreen.Text = "G";
                btnBlue.Text = "B";
                btnYellow.Text = "Y";
                btnOrange.Text = "O";
                btnCyan.Text = "C";
                btnMagenta.Text = "M";
            }
            if(languageChoice == 2)
            {
                lblExemple1.Text = "- правильно";
                lblExemple2.Text = "- не та позиція";
                lblExemple3.Text = "- нічого";
                btnReset.Text = "Reset";
                btnReturnMenu.Text = "Назад до меню";
                btnValidate.Text = "Підтвердити";
                btnErase.Text = "Стерти все";
                btnEraseOne.Text = "Стерти";
                cheatBox.Text = "Змухлювати";
                cheatBox.Font = new Font("Microsoft Sans Serif", 7, FontStyle.Regular);
                btnRed.Text = "Ч";
                btnGreen.Text = "З";
                btnBlue.Text = "С";
                btnYellow.Text = "Ж";
                btnOrange.Text = "П";
                btnCyan.Text = "Г";
                btnMagenta.Text = "Р";
            }

            //montrer/cacher les lettres des couleurs
            if (showLetters == true)
            {
                btnRed.ForeColor = Color.Black;
                btnGreen.ForeColor = Color.Black;
                btnBlue.ForeColor = Color.Black;
                btnYellow.ForeColor = Color.Black;
                btnOrange.ForeColor = Color.Black;
                btnCyan.ForeColor = Color.Black;
                btnMagenta.ForeColor = Color.Black;
            }
            else
            {
                btnRed.ForeColor = Color.Red;
                btnGreen.ForeColor = Color.Green;
                btnBlue.ForeColor = Color.Blue;
                btnYellow.ForeColor = Color.Yellow;
                btnOrange.ForeColor = Color.Orange;
                btnCyan.ForeColor = Color.Cyan;
                btnMagenta.ForeColor = Color.Magenta;
            }
            //cacher les indices
            if(showNumbers == true)
            {
                btnExemple1.Hide();
                btnExemple2.Hide();
                btnExemple3.Hide();
                lblExemple1.Hide();
                lblExemple2.Hide();
                lblExemple3.Hide();
            }

            //tableaux de boutons
            resultTable = new Button[MAX_TRIES, combLength];
            resultPositionsTable = new Button[MAX_TRIES, combLength];
            noRep = new string[MAX_TRIES];
            noRepCmptr = 0;
            for(int i = 0; i < MAX_TRIES; i++)
            {
                noRep[i] = "-";
            }
            //remplir le tableau avec des boutons
            for (int i = 0; i < MAX_TRIES; i++)
            {
                for (int j = 0; j < combLength; j++)
                {
                    //fonction++
                    r = random.Next(5);

                    //créer un nouveau bouton
                    Button button = new Button();
                    button.Text = "";
                    button.Size = new Size(BUTTON_SIZE, BUTTON_SIZE);
                    button.Location = new Point(j * BUTTON_SIZE * 7 / 4, i * BUTTON_SIZE * 7 / 4);
                    button.FlatStyle = FlatStyle.Flat;
                    button.ForeColor = Color.Gray;
                    button.BackColor = Color.Gray;
                    //fonction++
                    switch (r)
                    {
                        case 0:
                            button.Click += Boo;
                            break;
                        case 1:
                            button.Click += LettreD;
                            break;
                        case 2:
                            button.Click += LettreI;
                            break;
                        case 3:
                            button.Click += LettreM;
                            break;
                        case 4:
                            button.Click += LettreA;
                            break;
                    }    
                    //ajouter dans le tableau des boutons
                    resultTable[i, j] = button;

                    //pour les boutons des positions
                    if(showNumbers == false)
                    {
                        Button button1 = new Button();
                        button1.Text = "";
                        button1.Size = new Size (POSITION_BUTTON_SIZE, POSITION_BUTTON_SIZE);
                        button1.Location = new Point(j * POSITION_BUTTON_SIZE * 7 / 4 + 10, i * BUTTON_SIZE * 7 / 4 + 4);
                        button1.FlatStyle = FlatStyle.Flat; 
                        button1.BackColor = Color.Gray;
                        button1.Enabled = false;
                        resultPositionsTable[i, j] = button1;
                    }
                }
            }

            //afficher les boutons
            for (int i = 0; i < MAX_TRIES; i++)
            {
                for (int j = 0; j < combLength; j++)
                {
                    pnlResults.Controls.Add(resultTable[i, j]);
                    pnlPositionsResults.Controls.Add(resultPositionsTable[i, j]);
                }
            }           

            //création d'un code à deviner
            //tableau pour stocker la combinaison
            stringColours = new char[combLength];

            CombCreate();
            HideButtons();
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

            Double();

            //pour ne pas répéter les même combinaisons
            if(!noRep.Contains(guess))
            {
                noRep[noRepCmptr] = guess;
                noRepCmptr++;
            }

            //affichage d'erreur
            if (resultTable[currentLine, combLength-1].BackColor == Color.Gray)
            {
                if(languageChoice == 0)
                {
                    MessageBox.Show("Veuillez entrer " + combLength + " couleurs");
                }
                if(languageChoice == 1)
                {
                    MessageBox.Show("Enter " + combLength + " colors");
                }
                if(languageChoice == 2)
                {
                    MessageBox.Show("Введіть " + combLength + " кольорів");
                }
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

                if(showNumbers == true)
                {
                    //labels pour afficher le resultat
                    //bonnes positionnes
                    Label labelGoodPositions = new Label();
                    if(languageChoice == 0)
                    {
                        labelGoodPositions.Text = "Bonnes: " + correctPositions.ToString();
                    }
                    if(languageChoice == 1)
                    {
                        labelGoodPositions.Text = "Good: " + correctPositions.ToString();
                    }
                    if(languageChoice == 2)
                    {
                        labelGoodPositions.Text = "OK: " + correctPositions.ToString();
                    }
                    labelGoodPositions.Location = new Point(0, currentLine * BUTTON_SIZE * 7 / 4 + 6);
                    labelGoodPositions.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    labelGoodPositions.ForeColor = Color.White;
                    labelGoodPositions.Size = new Size(80, 25);
                    //mauvaises positionnes
                    Label labelBadPositions = new Label();
                    if (languageChoice == 0)
                    {
                        labelBadPositions.Text = "Mauvaises: " + correctColours.ToString();
                    }
                    if (languageChoice == 1)
                    {
                        labelBadPositions.Text = "Bad: " + correctColours.ToString();
                    }
                    if (languageChoice == 2)
                    {
                        labelBadPositions.Text = "Не там: " + correctColours.ToString();
                    }
                    labelBadPositions.Location = new Point(85, currentLine * BUTTON_SIZE * 7 / 4 + 6);
                    labelBadPositions.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    labelBadPositions.ForeColor = Color.White;
                    //ajouter les labels au panel
                    pnlPositionsResults.Controls.Add(labelGoodPositions);
                    pnlPositionsResults.Controls.Add(labelBadPositions);
                }
                else
                {
                    if(correctPositions != 0)
                    {
                        for (int i = 0; i < correctPositions; i++)
                        {
                            resultPositionsTable[currentLine, i].BackColor = Color.White;
                        }
                    }
                    if(correctColours != 0)
                    {
                        cmptr = correctPositions;
                        for(int i = 0; i < correctColours; i++)
                        {
                            resultPositionsTable[currentLine, cmptr].BackColor = Color.Black;
                            cmptr++;
                        }
                    }
                    for(int i = 0; i < combLength; i++)
                    {
                        if (resultPositionsTable[currentLine, i].BackColor == Color.Gray)
                        {
                            resultPositionsTable[currentLine, i].BackColor = Color.Brown;
                        }
                    }
                }

                //parcourir le tableau des boutons
                currentColumn = 0;
                currentLine++;

                //afficher le message si l'utilisateur a gagner
                if(correctPositions == combLength)
                {
                    if(languageChoice == 0)
                    {
                        MessageBox.Show("Vous avez gagnez!\n" +
                        "Appuyez sur \"Reset\" pour recommencer");
                    }
                    if (languageChoice == 1)
                    {
                        MessageBox.Show("You win!\n" +
                        "Click on \"Reset\" to replay");
                    }
                    if (languageChoice == 2)
                    {
                        MessageBox.Show("Ви виграли!\n" +
                        "Натисніть на \"Reset\", щоб почати спочатку");
                    }
                    btnErase.Enabled = false;
                    btnEraseOne.Enabled = false;
                    btnValidate.Enabled = false;
                    currentLine--;
                }

                //afficher le message si l'utilisateur a perdu
                if(currentLine == MAX_TRIES)
                {
                    if (languageChoice == 0)
                    {
                        MessageBox.Show("Vous avez perdu!\n" +
                        "Appuyez sur \"Reset\" pour recommencer");
                    }
                    if (languageChoice == 1)
                    {
                        MessageBox.Show("You lose!\n" +
                        "Click on \"Reset\" to replay");
                    }
                    if (languageChoice == 2)
                    {
                        MessageBox.Show("Ви програли!\n" +
                        "Натисніть на \"Reset\", щоб почати спочатку");
                    }
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
            Cheats();
        }

        #region Fonction++
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
        #endregion

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
            //ouvrir le menu
            mainMenu.Show();
            //fermer le jeu
            this.Close();
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
                    if(!showNumbers)
                    {
                        resultPositionsTable[i, j].BackColor = Color.Gray;
                    }   
                }
            }

            //faire fonctionner des boutons
            btnValidate.Enabled = true;
            btnErase.Enabled = true;
            btnEraseOne.Enabled = true;

            //faire disparaitre des labels
            foreach (var lbl in pnlPositionsResults.Controls.OfType<Label>())//l'idée - https://stackoverflow.com/questions/31233558/c-sharp-hide-all-labels-controls
            {
                lbl.Hide();
            }   

            //pour commencer avec le premier bouton
            currentColumn = 0;
            currentLine = 0;

            //récréer la combinaison
            CombCreate();
            //changer le texte de "Tricher"
            lblAnswer.Text = "";
            Cheats();
            //effacer le tableau noRep
            for(int i = 0; i < MAX_TRIES; i++)
            {
                noRep[i] = "-";
            }
            noRepCmptr = 0;
        }
        #endregion

        /// <summary>
        /// créer la combinaison
        /// </summary>
        void CombCreate()
        {
            //boucle qui se répète pour que la variable "stringColours" prenne des valeurs de "colours"
            for (int i = 0; i < stringColours.Length; i++)
            {
                stringColours[i] = colours[random.Next(colours.Length)];
            }
        }

        /// <summary>
        /// pour afficher la bonne quantité des boutons des couleurs
        /// </summary>
        void HideButtons()
        {
            switch(colours)
            {
                case "ЧЗ":
                case "RG":
                case "RV":
                    btnBlue.Hide();
                    btnCyan.Hide();
                    btnMagenta.Hide();
                    btnOrange.Hide();
                    btnYellow.Hide();
                    break;
                case "ЧЗС":
                case "RGB":
                case "RVB":
                    btnBlue.Show();
                    btnCyan.Hide();
                    btnMagenta.Hide();
                    btnOrange.Hide();
                    btnYellow.Hide();
                    break;
                case "ЧЗСЖ":
                case "RGBY":
                case "RVBJ":
                    btnBlue.Show();
                    btnYellow.Show();
                    btnCyan.Hide();
                    btnMagenta.Hide();
                    btnOrange.Hide();
                    break;
                case "ЧЗСЖП":
                case "RGBYO":
                case "RVBJO":
                    btnBlue.Show();
                    btnYellow.Show();
                    btnOrange.Show();
                    btnCyan.Hide();
                    btnMagenta.Hide();
                    break;
                case "ЧЗСЖПГ":
                case "RGBYOC":
                case "RVBJOC":
                    btnBlue.Show();
                    btnYellow.Show();
                    btnOrange.Show();
                    btnCyan.Show();
                    btnMagenta.Hide();
                    break;
                case "ЧЗСЖПГР":
                case "RGBYOCM":
                case "RVBJOCM":
                    btnBlue.Show();
                    btnYellow.Show();
                    btnOrange.Show();
                    btnCyan.Show();
                    btnMagenta.Show();
                    break;
            }    
        }

        /// <summary>
        /// pour changer le texte de "Tricher"
        /// </summary>
        void Cheats()
        {
            if (cheatBox.Checked == true)
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
        /// éviter des doublons
        /// </summary>
        void Double()
        {
            if (noRep.Contains(guess))
            {
                if(languageChoice == 0)
                {
                    MessageBox.Show("Vous avez déja utilisé cette combinaison, réessayez");
                }
                if(languageChoice == 1)
                {
                    MessageBox.Show("You have already tried this combination, retry");
                }
                if(languageChoice == 2)
                {
                    MessageBox.Show("Ви вже вводили цю послідовність, спробуйте іншу");
                }
                for(int j = combLength-1; j >= 0; j--)
                {
                    resultTable[currentLine, j].BackColor = Color.Gray;
                    resultTable[currentLine, j].ForeColor = Color.Gray;
                    resultTable[currentLine, j].Text = "";
                }
                currentColumn = 0;
            }
        }
    }
}
