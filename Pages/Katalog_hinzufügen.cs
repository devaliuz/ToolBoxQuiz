using System;
using System.Windows;
using System.IO;
using System.Data.SQLite;

namespace ToolBoxQuiz
{
    public partial class Katalog_hinzufügen : Form
    {
        Database databaseAddCAT = new Database();
        
        public Katalog_hinzufügen()
        {
            InitializeComponent();
        }


        private void BTN_KH_ADD_Click(object sender, EventArgs e)
        {
            
            ADD_Table();
            
            Close();
        }

        void ADD_Table() 
        {
            

            string TableName = TB_TABLE_NAME.Text;
            if (TableName != null)
            {

                string query1 = "CREATE TABLE "
                                + TableName
                                + " ("
                                + " ID INTEGER PRIMARY KEY AUTOINCREMENT,"
                                + " Frage TEXT NOT NULL,"
                                + " Antwort_A TEXT NOT NULL,"
                                + " Antwort_B TEXT NOT NULL,"
                                + " Antwort_C TEXT NOT NULL,"
                                + " Antwort_D TEXT NOT NULL,"
                                + " Bild  BLOB,"
                                + " Richtige_Antwort  TEXT NOT NULL)";
                               
                            
                SQLiteCommand add1 = new SQLiteCommand(query1);
                
                string query2 = "INSERT INTO Tabellen('Name') VALUES(@Name)";
                SQLiteCommand add2 = new SQLiteCommand(query2);
                add2.Parameters.AddWithValue("@Name", TableName);
                add1.ExecuteNonQuery();
                add2.ExecuteNonQuery();
            }            
        }
    }
    
}
