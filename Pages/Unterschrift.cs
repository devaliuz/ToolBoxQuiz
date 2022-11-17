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
    public partial class Unterschrift : Form
    {
        
        public Point current = new Point();
        public Point old = new Point();
        public Graphics g;
        public Graphics graph;
        public Pen pen = new Pen(Color.Black, 5);
        Bitmap surface;

        public string Username;
        public int rowid;
        public string bestätigt;
       



        public Unterschrift()
        {
            InitializeComponent();
            g = PB_SIGN.CreateGraphics();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            surface = new Bitmap(PB_SIGN.Width, PB_SIGN.Height);
            graph = Graphics.FromImage(surface);
            PB_SIGN.BackgroundImage = surface;
            PB_SIGN.BackgroundImageLayout = ImageLayout.None;
            
        }

        private void BTN_VALIDATE_Click_1(object sender, EventArgs e)
        {
            Save();        
            Close();            
        }

        private void PB_SIGN_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void PB_SIGN_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) 
            {
                current = e.Location;
                g.DrawLine(pen, old, current);
                graph.DrawLine(pen, old, current);
                old = current;
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            graph.Clear(Color.White);
            PB_SIGN.Invalidate();
        }

        void Save()
        {
            DateTime date = DateTime.Now;
            string stamp = date.ToString("dd_MM_yy_HH_mm");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Png Files(*png) | *.png";
            sfd.DefaultExt = "png";
            sfd.AddExtension = true;
            
            sfd.FileName = $"Unterschrift_{Username}_{stamp}";
            sfd.InitialDirectory = "@SIGNS";
            bestätigt = sfd.FileName;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                surface.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
