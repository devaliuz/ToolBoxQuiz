using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace ToolBoxQuiz
{
    public partial class Ergebnisse : Form
    {
        
        Database database = new Database();
        public int chosen;
        public string Username;
        public string Unterschrift_Pic;
        public Ergebnisse()
        {
            InitializeComponent();
            Load_Ergebnisse();
        }

        private void BTN_FORWARD_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Ergebnisliste_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Sign();
        }

        void Load_Ergebnisse() 
        {
            string[] Ergebnisse = database.Ergebnisse("Ergebnisse");
            for(int i = 0; i < Ergebnisse.Length; i++)
            {
                Ergebnisliste.Items.Add(Ergebnisse[i]);
            }
        }

        void Load_Sign()
        {
            PB_SHOW_SIGN.Image = null;
            Dateiname.Text = "";
            chosen = Ergebnisliste.SelectedIndex + 1;
            using (SQLiteConnection c = new SQLiteConnection("Data Source = Questions.sqlite3"))
            {
                c.Open();
                using (SQLiteCommand rowdata = new SQLiteCommand($"Select * From Ergebnisse WHERE _rowid_={chosen}", c))
                {
                    using (SQLiteDataReader rowreader = rowdata.ExecuteReader())
                    {
                        rowreader.Read();
                        Unterschrift_Pic = rowreader["Unterschrift"].ToString();
                    }
                }
            }
            if (Unterschrift_Pic != "")
            {
                try
                {
                    PB_SHOW_SIGN.Image = Image.FromFile(@"SIGNS\" + Unterschrift_Pic + ".png");
                    Dateiname.Text = $"{Unterschrift_Pic}png";
                }
                catch
                {
                    Dateiname.Text = "Keine Unterschrift gefunden!";
                }
            }
            else
            {
                Dateiname.Text = "Keine Unterschrift vorhanden!";
            }
            Unterschrift_Pic = "";
        }                                      
    }
}
