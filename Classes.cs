using System.Data.SQLite;

namespace ToolBoxQuiz
{
    class Database
    {
        public SQLiteConnection c { get; set; }
        public Database()
        {
            if (!File.Exists("./Questions.sqlite3"))
            {
                SQLiteConnection.CreateFile("Questions.sqlite3");
            }
        }

        public int count(string Tabelle)
        {
            int counter = 0;                                                                            //Creates Variable to count
            try
            {
                using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
                {
                    c.Open();
                    using (SQLiteCommand selectall = new SQLiteCommand($"SELECT * FROM {Tabelle}", c))
                    {                                                                                                           //Creates SQLite Command to Select from "Tabellen", where all Questionthemes are saved 
                        using (SQLiteDataReader readall = selectall.ExecuteReader())                                            //calls a Reader for the created command
                        {
                            if (readall.HasRows)                                                                                    //checks if reader found anything
                            {

                                while (readall.Read())                                                                              //keeps going, as long  as there are rows left in called table
                                {
                                    counter++;                                                                                      //adds 1 to count for each row the reader read
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Keine Daten gefunden.");                                                               //Catches the try, if database couldnt be read or found
            }
            return counter;

        }

        public string[] Load(string Tabelle,string Name)
        {
           
            try
            {
                
                int x = count(Tabelle);
                string[] Rückgabe = new string[x];
                for (int i = 1; i < x + 1; i++)
                {
                        using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
                    {
                        c.Open();
                        using (SQLiteCommand rowdata = new SQLiteCommand($"Select * From {Tabelle} WHERE _rowid_={i}", c))
                        {
                            using (SQLiteDataReader rowreader = rowdata.ExecuteReader())
                            {
                                rowreader.Read();
                                Rückgabe[i - 1] = rowreader[$"{Name}"].ToString();
                            }
                        }
                    }
                }
                return Rückgabe;
            }
            catch 
            {
                return new string[1];
            }
        }
        public string[] Ergebnisse(string Tabelle) 
        {
            try
            {

                int x = count(Tabelle);
                string[] Rückgabe = new string[x];
                
                for (int i = 1; i < x + 1; i++)
                {
                    using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
                    {
                        c.Open();
                        using (SQLiteCommand rowdata = new SQLiteCommand($"Select * From {Tabelle} WHERE _rowid_={i}", c))
                        {
                            using (SQLiteDataReader rowreader = rowdata.ExecuteReader())
                            {
                                rowreader.Read();
                                Rückgabe[i - 1] += rowreader["Datum"].ToString();
                                Rückgabe[i - 1] += "  \t" + rowreader["Name"].ToString();
                                Rückgabe[i - 1] += "  \t" + rowreader["Ergebnis"].ToString();
                                Rückgabe[i - 1] += "  \t" + rowreader["Test"].ToString();
                            }
                        }
                    }
                }
                return Rückgabe;
            }
            catch
            {
                return null;
            }
        }
        
        
    }
}
    

        


    
            
                
            
    
               

