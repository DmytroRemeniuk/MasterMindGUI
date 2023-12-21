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
        const int POSITION_BUTTON_SIZE = 14;
        //pour parcourir le tableau des boutons
        int _currentLine = 0;
        int _currentColumn = 0;
        //fonctionnement du jeu
        char[] stringColours;
        Random random = new Random();
        int _r;//fonction++
        public int combLength;
        public string colours;
        string _guess = "";
        int _correctColours = 0;
        int _correctPositions = 0;
        string[] noRep;
        List<char> usedColours;
        int _cmptr;//pour remplir le tableau des mauvaises positions
        int _noRepCmptr;
        bool _noRepRun = false;
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
            if(_currentColumn == combLength)
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
                resultTable[_currentLine, _currentColumn].BackColor = btnColor.BackColor;
                resultTable[_currentLine, _currentColumn].Text = btnColor.Text;
                resultTable[_currentLine, _currentColumn].ForeColor = btnColor.ForeColor;

                //aller sur le bouton prochain
                _currentColumn++;  
                if(_currentColumn < combLength)
                {
                    resultTable[_currentLine, _currentColumn].ForeColor = Color.White;
                }
            }
        }

        /// <summary>
        /// Méthode pour effacer les couleurs entrées
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnErase_Click(object sender, EventArgs e)
        {
            if(_currentColumn != 0)
            {
                for (int j = combLength-1; j >= 0; j--)
                {
                    resultTable[_currentLine, j].BackColor = Color.Gray;
                    resultTable[_currentLine, j].ForeColor = Color.Gray;
                    resultTable[_currentLine, j].Text = "";
                }

                _currentColumn = 0;
                //bordure
                resultTable[_currentLine, _currentColumn].ForeColor = Color.White;
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
            if(_currentColumn != 0)
            {
                _currentColumn--;
                resultTable[_currentLine, _currentColumn].BackColor = Color.Gray;
                resultTable[_currentLine, _currentColumn].ForeColor = Color.Gray;
                resultTable[_currentLine, _currentColumn].Text = "";
                //bordure
                resultTable[_currentLine, _currentColumn].ForeColor = Color.White;
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
            btnErase.Location = new Point(btnValidate.Location.X, btnErase.Location.Y);
            btnEraseOne.Location = new Point(btnValidate.Location.X, btnEraseOne.Location.Y);
            btnRed.Location = new Point(btnValidate.Location.X + 68, btnRed.Location.Y);
            btnGreen.Location = new Point(btnRed.Location.X, btnGreen.Location.Y);
            btnBlue.Location = new Point(btnRed.Location.X, btnBlue.Location.Y);
            btnYellow.Location = new Point(btnRed.Location.X, btnYellow.Location.Y);
            btnOrange.Location = new Point(btnRed.Location.X, btnOrange.Location.Y);
            btnCyan.Location = new Point(btnRed.Location.X, btnCyan.Location.Y);
            btnMagenta.Location = new Point(btnRed.Location.X, btnMagenta.Location.Y);
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

            //tableau des répétitions
            noRep = new string[MAX_TRIES];
            _noRepCmptr = 0;
            for(int i = 0; i < MAX_TRIES; i++)
            {
                noRep[i] = "-";
            }

            //créer les boutons et remplir le tableau avec eux
            for (int i = 0; i < MAX_TRIES; i++)
            {
                for (int j = 0; j < combLength; j++)
                {
                    //fonction++
                    _r = random.Next(5);

                    //créer un nouveau bouton
                    Button button = new Button
                    {
                        Text = "",
                        Size = new Size(BUTTON_SIZE, BUTTON_SIZE),
                        Location = new Point(j * BUTTON_SIZE * 7 / 4, i * BUTTON_SIZE * 7 / 4),
                        FlatStyle = FlatStyle.Flat,
                        ForeColor = Color.Gray,
                        BackColor = Color.Gray
                    };
                    //fonction++
                    switch (_r)
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
                    if(!showNumbers)
                    {
                        Button button1 = new Button
                        {
                            Text = "",
                            Size = new Size(POSITION_BUTTON_SIZE, POSITION_BUTTON_SIZE),
                            Location = new Point(j * POSITION_BUTTON_SIZE * 7 / 4 + 25, i * BUTTON_SIZE * 7 / 4 + 4),
                            FlatStyle = FlatStyle.Flat,
                            BackColor = Color.Gray,
                            Enabled = false
                        };
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
            //bordure
            resultTable[_currentLine, _currentColumn].ForeColor = Color.White;

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
            _correctColours = 0;
            _correctPositions = 0;
            //initialiser une liste avec des couleurs utilisées 
            usedColours = new List<char>(stringColours);

            _guess = "";

            //remplir le tableau de verification
            for (int i = 0; i < combLength; i++)
            {
                _guess += resultTable[_currentLine, i].Text;
            }

            Double();

            //pour ne pas répéter les même combinaisons
            if(!noRep.Contains(_guess) && resultTable[_currentLine, combLength - 1].BackColor != Color.Gray)
            {
                noRep[_noRepCmptr] = _guess;
                _noRepCmptr++;
            }

            //affichage d'erreur
            if (resultTable[_currentLine, combLength-1].BackColor == Color.Gray && !_noRepRun)
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
            else if(resultTable[_currentLine, combLength - 1].BackColor != Color.Gray && !_noRepRun)
            {
                //verifier chaque élément du tableau si c'est une bonne position
                for (int i = 0; i < _guess.Length; i++)
                {
                    if (_guess[i] == stringColours[i])
                    {
                        _correctPositions++;
                        usedColours[i] = ' ';//marquer la couleur utilisée
                    }
                }

                //verifier chaque élément du tableau si c'est une mauvaise position
                for (int i = 0; i < _guess.Length; i++)
                {
                    if (_guess[i] != stringColours[i] && usedColours.Contains(_guess[i]))
                    {
                        _correctColours++;
                        usedColours[usedColours.IndexOf(_guess[i])] = ' ';//marquer la couleur utilisée
                    }
                }

                //affichage avec les chiffres
                if(showNumbers == true)
                {
                    //labels pour afficher le resultat
                    //bonnes positions
                    Label labelGoodPositions = new Label();
                    if(languageChoice == 0)
                    {
                        labelGoodPositions.Text = "Bonnes: " + _correctPositions.ToString();
                    }
                    if(languageChoice == 1)
                    {
                        labelGoodPositions.Text = "Good: " + _correctPositions.ToString();
                    }
                    if(languageChoice == 2)
                    {
                        labelGoodPositions.Text = "Taм: " + _correctPositions.ToString();
                    }
                    labelGoodPositions.Location = new Point(0, _currentLine * BUTTON_SIZE * 7 / 4 + 6);
                    labelGoodPositions.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    labelGoodPositions.ForeColor = Color.White;
                    labelGoodPositions.Size = new Size(79, 25);

                    //mauvaises positions
                    Label labelBadPositions = new Label();
                    if (languageChoice == 0)
                    {
                        labelBadPositions.Text = "Mauvaises: " + _correctColours.ToString();
                    }
                    if (languageChoice == 1)
                    {
                        labelBadPositions.Text = "Bad: " + _correctColours.ToString();
                    }
                    if (languageChoice == 2)
                    {
                        labelBadPositions.Text = "Не там: " + _correctColours.ToString();
                    }
                    labelBadPositions.Location = new Point(75, _currentLine * BUTTON_SIZE * 7 / 4 + 6);
                    labelBadPositions.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                    labelBadPositions.ForeColor = Color.White;
                    //ajouter les labels au panel
                    pnlPositionsResults.Controls.Add(labelGoodPositions);
                    pnlPositionsResults.Controls.Add(labelBadPositions);
                }
                //affichage avec les points
                else
                {
                    if(_correctPositions != 0)
                    {
                        for (int i = 0; i < _correctPositions; i++)
                        {
                            resultPositionsTable[_currentLine, i].BackColor = Color.White;
                        }
                    }
                    if(_correctColours != 0)
                    {
                        _cmptr = _correctPositions;
                        for(int i = 0; i < _correctColours; i++)
                        {
                            resultPositionsTable[_currentLine, _cmptr].BackColor = Color.Black;
                            _cmptr++;
                        }
                    }
                    for(int i = 0; i < combLength; i++)
                    {
                        if (resultPositionsTable[_currentLine, i].BackColor == Color.Gray)
                        {
                            resultPositionsTable[_currentLine, i].BackColor = Color.Brown;
                        }
                    }
                }

                //parcourir le tableau des boutons
                _currentColumn = 0;
                _currentLine++;
                //bordure
                if(_currentColumn < combLength && _currentLine < MAX_TRIES)
                {
                    resultTable[_currentLine, _currentColumn].ForeColor = Color.White;
                }

                //afficher le message si l'utilisateur a gagné
                if(_correctPositions == combLength)
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
                    _currentLine--;
                }

                //afficher le message si l'utilisateur a perdu
                if(_currentLine == MAX_TRIES)
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
            //annuler
            _noRepRun = false;
        }

        /// <summary>
        /// pour le débogage
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
            if(showNumbers)
            {
                pnlPositionsResults.Controls.Clear();
            }

            //pour commencer avec le premier bouton
            _currentColumn = 0;
            _currentLine = 0;
            //bordure
            resultTable[_currentLine, _currentColumn].ForeColor = Color.White;

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
            _noRepCmptr = 0;
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
            if (noRep.Contains(_guess))
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
                    resultTable[_currentLine, j].BackColor = Color.Gray;
                    resultTable[_currentLine, j].ForeColor = Color.Gray;
                    resultTable[_currentLine, j].Text = "";
                }
                _currentColumn = 0;
                //bordure
                resultTable[_currentLine, _currentColumn].ForeColor = Color.White;
                //pour afficher qu'un seul message
                _noRepRun = true;
            }
        }
    }
}
