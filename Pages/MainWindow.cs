
using System.Diagnostics;
using System.Data.SQLite;

namespace ToolBoxQuiz
{
    public partial class MainWindow : Form
    {

        Database databaseMainWin = new Database();
        public int Frage=1;
        public int FrageMax = 0;
        public string Theme = "";
        public string Richtige_Antwort ="";
        public string Nutzer_Antwort = "";
        public int Richtig = 0;
        public string Antworten = "";
        public string Username = "";
        public bool passed = false;
        public string QuestionType = "MC";
        public string bestätigt;
        
        
        public MainWindow()
        {
            Login login = new Login();
            login.ShowDialog();                                                                     //Throws Login at User
            InitializeComponent();

             if (login.passwordInput == login.passwordDB)                                            //Checks if Login was Succsessfull -> loadas Window
             {                                                                             
                 Load_Auswahl();                                                                     //Loads Topics into dropdown                                                                             
                 WHO_IS_LOGGED_IN.Text = "Als " + login.UsernameRaw + " eingeloggt.";                //Shows Loged in User
                 Username = login.UsernameRaw;                                                       //Saves Username into useable Variable
                
                if(Username == "Peter Pingelig") 
                {
                    BTN_ERGEBNIS.Visible = true;
                }
             }
             else 
             {
                 Close();                                                                            //Closes Window if Login wasnt Succsessfull
             }
            
            
        }

        private void Auswahl_SelectedIndexChanged(object sender, EventArgs e)                       //Reacts on Changes in Dropdownselection
        {   
            Theme = Auswahl.SelectedItem.ToString();                                                //Saves Chosen Topic into Variable
        }

        private void BTN_START_Click(object sender, EventArgs e)                                    //Starts the Quiz
        {          
            Start();                                                                                //Calls function for Changes in Window and starting the Quiz           
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {                                                                        
            Finish();                                                                              //Cancels the current test and throws back to startscreen                                                                        
        }

        private void BTN_FORWARD_Click(object sender, EventArgs e)                                  //
        {

            if (QuestionType == "MC")
            {
                if (Antwort_A.Checked == true)                                                         //checks wich Answer was chosen by User
                {
                    Nutzer_Antwort = Antwort_A.Text;                                                   //Saves given Answer to Variable                
                    Forward();                                                                         //                
                }
                else if (Antwort_B.Checked == true)
                {
                    Nutzer_Antwort = Antwort_B.Text;                                                    //**           
                    Forward();                                                                          //**           
                }
                else if (Antwort_C.Checked == true)
                {
                    Nutzer_Antwort = Antwort_C.Text;
                    Forward();
                }
                else if (Antwort_D.Checked == true)
                {
                    Nutzer_Antwort = Antwort_D.Text;
                    Forward();
                }
                else
                {
                    if (Frage <= FrageMax)                                                          //Checks if last Question is reached
                    {
                        MessageBox.Show("Bitte eine Antwort wählen!");                              //if not, calls user to chose a Answer cause he didnt
                    }
                }
            }
            else if(QuestionType == "Math")
            {
                if (MATH_NUM.Value.ToString() != "")
                {
                    Nutzer_Antwort = MATH_NUM.Value.ToString();
                    Forward();
                }
                else
                {
                    if (Frage <= FrageMax)                                                          //Checks if last Question is reached
                    {
                        MessageBox.Show("Bitte eine Antwort eigeben!");                              //if not, calls user to chose a Answer cause he didnt
                    }
                }
            }
            else if (QuestionType == "Text")
            {
                if (TB_Answer.Text != "")
                {
                    Nutzer_Antwort = TB_Answer.Text;
                    Forward();
                }
                else
                {
                    if (Frage <= FrageMax)                                                          //Checks if last Question is reached
                    {
                        MessageBox.Show("Bitte eine Antwort eigeben!");                              //if not, calls user to chose a Answer cause he didnt
                    }
                }
            }

        }

        void Load_Auswahl()                                                                         //reads DB to show all saved Questionthemes
        {
            string[] Themes = databaseMainWin.Load("Tabellen", "Name");
            for (int i = 0; i < Themes.Length; i++)
            {
                Auswahl.Items.Add(Themes[i]);
            }               
        }

        private void Start()
        {
            if (Auswahl.SelectedItem != null)
            {
                BTN_START.Visible = false;                                                          //Changes Visibility of UI-elements to change look on the window
                BildBox.Visible = true;
                Fragenzähler.Visible = true;
                QuestionLabel.Visible = true;
                BTN_FORWARD.Visible = true;
                BTN_CANCEL.Visible = true;
                Auswahl.Enabled = false;
                Antwort_A.Checked = false;                                                          //sets all Answerbuttons unchecked
                Antwort_B.Checked = false;
                Antwort_C.Checked = false;
                Antwort_D.Checked = false;
                BTN_ERGEBNIS.Visible = false;
                BTN_LOGOUT.Visible = false;
                Antworten = "";
                LoadQuestion();                                                                      //calls function to read the Questions from database
            }
            else
            {
                MessageBox.Show("Bitte erst  Fragenkatalog auswählen");                             //catches, if no Theme was selected
            }
        }
        public void LoadQuestion()
        {
            try
            {
                FrageMax = databaseMainWin.count(Theme);                                                             //Saves counted rows into a Variable                
            }
            catch
            {
                MessageBox.Show("Fehler beim lesen.");
            }

            try
            {
                using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
                {
                    c.Open();
                    string query = "SELECT * FROM " + Theme + " WHERE _rowid_ = " + Frage;
                    using (SQLiteCommand rowdata = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader rowreader = rowdata.ExecuteReader())
                        {
                            rowreader.Read();


                            Fragenzähler.Text = "Frage " + Frage + "/" + FrageMax;                                  //displays the current Questionnumber out of maximum questions in this theme
                            QuestionLabel.Text = rowreader["Frage"].ToString();                                     //Displays the question
                            QuestionType = rowreader["QuestionType"].ToString();

                            if (QuestionType == "MC")
                            {
                                Antwort_A.Visible = true;
                                Antwort_B.Visible = true;
                                Antwort_C.Visible = true;
                                Antwort_D.Visible = true;
                                MATH_NUM.Visible = false;
                                TB_Answer.Visible = false;
                                Antwort_A.Text = rowreader["Antwort_A"].ToString();                                     //Displays a possible answer
                                Antwort_B.Text = rowreader["Antwort_B"].ToString();                                     //**
                                Antwort_C.Text = rowreader["Antwort_C"].ToString();                                     //**
                                Antwort_D.Text = rowreader["Antwort_D"].ToString();                                     //**
                                Richtige_Antwort = rowreader["Richtige_Antwort"].ToString();                            //saves right answer into a variable
                            }
                            else if (QuestionType == "Math")
                            {
                                Antwort_A.Visible = false;
                                Antwort_B.Visible = false;
                                Antwort_C.Visible = false;
                                Antwort_D.Visible = false;
                                MATH_NUM.Visible = true;
                                TB_Answer.Visible = false;
                                Richtige_Antwort = rowreader["Richtige_Antwort"].ToString();                            //saves right answer into a variable

                            }
                            else if (QuestionType == "Text")
                            {
                                Antwort_A.Visible = false;
                                Antwort_B.Visible = false;
                                Antwort_C.Visible = false;
                                Antwort_D.Visible = false;
                                MATH_NUM.Visible = false;
                                TB_Answer.Visible = true;
                                Richtige_Antwort = rowreader["Richtige_Antwort"].ToString();                            //saves right answer into a variable
                            }
                            string picpath = rowreader["Bild"].ToString();                                              //gets picturname from DB
                            BildBox.Image = Image.FromFile(@"Pics\"+picpath);                                           //picture NEEDS to be in "Pics" folder atm
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Unerwarteter Fehler aufgetreten!");                                     //if anything goes wrong with this process....
            }
        }
             
        private void Finish() 
        {
            BTN_START.Visible = true;                                                                       //Makes Startscreen Visible again
            BildBox.Visible = false;
            Fragenzähler.Visible = false;
            QuestionLabel.Visible = false;
            Antwort_A.Visible = false;
            Antwort_B.Visible = false;
            Antwort_C.Visible = false;
            Antwort_D.Visible = false;
            BTN_FORWARD.Visible = false;
            BTN_CANCEL.Visible = false;
            TB_Answer.Visible = false;
            Auswahl.Enabled = true;                                                                                                 //resets all basic values
            MATH_NUM.Visible=false;
            TB_Answer.Visible=false;
            BTN_LOGOUT.Visible = true;
            if (Username == "Peter Pingelig")
            {
                BTN_ERGEBNIS.Visible = true;
            }
            Richtig = 0;
            DateTime date = DateTime.Now;
            string stamp = date.ToString();                                                                 //gives current time in De
            if (Frage == databaseMainWin.count(Theme))
            {
                using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
                {
                    c.Open();
                    string query = "INSERT INTO Ergebnisse ('Name', 'Test', 'Antworten', 'Ergebnis', 'Datum', 'Unterschrift') VALUES(@Name, @Test, @Antworten, @Ergebnis, @Datum, @Unterschrift)"; //prepares string for adding information to DB
                    using (SQLiteCommand add = new SQLiteCommand(query, c))
                    {

                        add.Parameters.AddWithValue("@Name", Username);                                     //adds parts of the string into DB by using "@" to prevent from injections
                        add.Parameters.AddWithValue("@Test", Theme);                                        //**
                        add.Parameters.AddWithValue("@Antworten", Antworten);                               //**
                        if (passed == true)                                                                  //checks if user has passed the test
                        {
                            add.Parameters.AddWithValue("@Ergebnis", "bestanden");
                        }
                        else
                        {
                            add.Parameters.AddWithValue("@Ergebnis", "nicht bestanden");
                        }
                        add.Parameters.AddWithValue("@Datum", stamp);                                       //adds a timestamp to the data
                        add.Parameters.AddWithValue("@Unterschrift", bestätigt);
                        add.ExecuteNonQuery();                                                              //executes all code above in SQLite

                        Antworten = "";                                                                     //clears variable
                        passed = false;                                                                     //resets variable
                    }
                }
            }
            Frage = 1;
            bestätigt = "";

        }

        void Forward()
        {
            Antworten += $"?? Frage: {Frage} Antwort: {Nutzer_Antwort}!!\n";                   //Adds the given Answer, together with Theme , Questionnumber and Username into a Variable
            if (Richtige_Antwort == Nutzer_Antwort)                                             //checks if user gave correct answer
            {
                Richtig++;                                                                      //adds one point
            }
            if (Frage < FrageMax)                                                               //checks if there are questions left
            {               
                Frage++;                                                                        //ads one to Questioncounter
                LoadQuestion();                                                                 //loads next question
            }
            else
            {
                MessageBox.Show("Du hast "+Richtig+"/"+FrageMax+" richtig beantwortet!");      //if no questions are left, gives user information bout how many correct answers he gave
                if (Richtig / FrageMax * 100 >= 90)                                            //checks if correct answers were at 90> %
                {
                    passed = true;                                                            //saves passed to variable 


                    Unterschrift sign = new Unterschrift();
                    sign.Username = Username;
                    sign.ShowDialog();
                    bestätigt = sign.bestätigt;
                    
                    MessageBox.Show("Deine Antworten, sowie dein Ergebnis 'bestanden' werden gespeichert!");
                }
                else 
                {
                    passed=false;                                                             //saves failed to variable
                    MessageBox.Show("Deine Antworten, sowie dein Ergebnis 'nicht bestanden' werden gespeichert!");
                }
                Finish();
                
            }
            Antwort_A.Checked = false;                                                          //resets all Answerbuttons
            Antwort_B.Checked = false;
            Antwort_C.Checked = false;
            Antwort_D.Checked = false;
            MATH_NUM.Value = 0;
            TB_Answer.Text = "";
        }

        private void Ergebnisse_Click(object sender, EventArgs e)
        {
            if(Username== "Peter Pingelig")                                                         //Preseted as "Admin"
            {
                Ergebnisse ergebnisse = new Ergebnisse();
                ergebnisse.Username=Username;
                ergebnisse.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Bitte als Admin (Peter Pingelig) anmelden, um die Ergebnisse aller Teilnehmer zu sehen!"); //Should never be shown, but in case...
            }
     
        }

        private void BTN_LOGOUT_Click(object sender, EventArgs e)
        {
            Application.Restart();                                                          //logs out current user, restarts the App

        }
    }
}

 