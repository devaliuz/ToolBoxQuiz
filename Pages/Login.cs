using System.Diagnostics;
using System.Data.SQLite;
namespace ToolBoxQuiz
{
    public partial class Login : Form
    {
        Database database = new Database();
        public Login()
        {
            InitializeComponent();
            //Debug.WriteLine("Open");
            //databaseLogin.Connection.Open();                        //**            
            Load_Users();                                           //Loads List of registered Users                                                                                       
        }

        public string UsernameRaw = "";                             //sets global variable
        public string Username = "";                                //**
        public string passwordDB = "asdfasdas";                     //ensures passwordDB and passwordInput are different by default
        public string passwordInput = "trsdfasdfasue";
        public int wrong = 0;

        private void Username_SelectedIndexChanged(object sender, EventArgs e)
        {
            UsernameRaw = UsernameDD.SelectedItem.ToString();               //gets Username from UI
            Username = "'" + UsernameDD.SelectedItem.ToString() + "'";          //adds ' ' to username, to make it readable for Sqlite
            TB_PASSWORD.ReadOnly = false;                                   //resets the Textbox to writeable
            BTN_LOGIN.Visible = true;                                       //resets the login button to visible
            wrong = 0;                                                      //resets number of failed tries
            Label_Check.Text = "Fehlversuche " + wrong + "/3";              //shows the amount of wrong tries (resettet)
            TB_PASSWORD.Text = "";                                          //clears all input in Textbox

        }
        private void BTN_LOGIN_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine("Open");
            //databaseLogin.Connection.Open();                                //**                      
            Check_PW();                                                     //proves Userinput
                                                                            //Debug.WriteLine("Close");
                                                                            //databaseLogin.Connection.Close();                               //**

        }
        void Load_Users()
        {
            string[] Users = database.Load("Benutzer", "User");
            for(int i=0; i<Users.Length; i++) 
            {
                UsernameDD.Items.Add(Users[i]);
            }
        }



        void Check_PW()
        {
            if (UsernameDD.SelectedItem != null)                                                        //checks if user has chosen a username
            {
                if (TB_PASSWORD.Text != "")                                                             //checks if user typed in a password
                {
                    using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
                    {
                        c.Open();
                        string query = "SELECT Passwort FROM Benutzer WHERE User LIKE " + Username;             //**
                        using (SQLiteCommand rowdata = new SQLiteCommand(query, c))
                        {                                                                                           //**
                            using (SQLiteDataReader rowreader = rowdata.ExecuteReader())
                            {                                                                                      //**
                                rowreader.Read();

                                passwordDB = rowreader["Passwort"].ToString();                                      //saves correct PW to variable
                                passwordInput = TB_PASSWORD.Text;                                                   //saves typed in PW to variable

                                if (passwordDB != passwordInput)                                                   //compares correct and typed in PW
                                {
                                    MessageBox.Show("Passwort Falsch!");                                            //shows if typed in pw isnt correct
                                    wrong++;                                                                        //adds one to fail-attempts
                                    if (wrong == 3)                                                                 //stops if fail-attempts where at 3
                                    {
                                        MessageBox.Show("Zu viele Fehlversuche!");                                  //shows user he failed to often
                                        TB_PASSWORD.ReadOnly = true;                                                //blocks another try
                                        BTN_LOGIN.Visible = false;                                                  //dmakes loginbutton invis for user
                                        Label_Check.Text = "";                                                      //clears the information bout fail-attempts
                                    }
                                    Label_Check.Text = "Fehlversuche " + wrong + "/3";                              //shows current fail-attempts
                                }
                                else
                                {
                                    Close();                                                                        //if password was right, closes loginwindow and opens Mainwindow
                                }
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Bitte korrektes Passwort eingeben!");                              //shows user he didnt type any pw
                }
            }
            else
            {
                MessageBox.Show("Bitte Nutzer auswählen!");                                             //shows user, he forgot to chose a username
            }
        }
    }
}
