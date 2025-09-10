using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace snakeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
        }

        Panel parca;
        Panel elma = new Panel();
        List<Panel> yilan = new List<Panel>();

        string yon = "sag";

        private void button1_Click(object sender, EventArgs e)
        {
            lblpuangosterge.Text = "0";
            paneliTemizle();

            parca = new Panel();
            parca.Location = new Point(200, 200);
            parca.Size = new Size(30, 30);
            parca.BackColor = Color.Black;
            yilan.Add(parca);
            panel1.Controls.Add(yilan[0]);

            timer1.Start();
            elmaOlustur();
            this.ActiveControl = null;
            this.Focus();
        }

        void carpismaKontol()
        {
            for (int i = 2; i < yilan.Count; i++)
            {
                if (yilan[0].Location == yilan[i].Location)
                {
                    lbldurum.Visible = true;
                    lbldurum.Text = "KAYBETTİNİZ";
                    timer1.Stop();
                }
            }
        }

        void paneliTemizle()
        {
            panel1.Controls.Clear();
            yilan.Clear();
            lbldurum.Visible = false;

        }

        void puanKontrol()
        {
            int puan = int.Parse(lblpuangosterge.Text);
            if (puan == 500)
            {
                lbldurum.Text = "KAZANDINIZ";
                lbldurum.Visible = true;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int locX = yilan[0].Location.X;
            int locY = yilan[0].Location.Y;

            elmaYedimmi();
            hareket();
            carpismaKontol();
            puanKontrol();

            if (yon == "sag")
            {
                if (locX < 600)
                    locX += 30;
                else
                    locX = 0;
            }
            if (yon == "sol")
            {
                if (locX > 0)
                    locX -= 30;
                else
                    locX = 600;
            }
            if (yon == "asagi")
            {
                if (locY < 600)
                    locY += 30;
                else
                    locY = 0;
            }
            if (yon == "yukarı")
            {
                if (locY > 0)
                    locY -= 30;
                else
                    locY = 600;
            }

            yilan[0].Location = new Point(locX, locY);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && yon != "sol")
                yon = "sag";
            if (e.KeyCode == Keys.Left && yon != "sag")
                yon = "sol";
            if (e.KeyCode == Keys.Up && yon != "asagi")
                yon = "yukarı";
            if (e.KeyCode == Keys.Down && yon != "yukarı")
                yon = "asagi";
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Right && yon != "sol")
                yon = "sag";
            else if (keyData == Keys.Left && yon != "sag")
                yon = "sol";
            else if (keyData == Keys.Up && yon != "asagi")
                yon = "yukarı";
            else if (keyData == Keys.Down && yon != "yukarı")
                yon = "asagi";

            return base.ProcessCmdKey(ref msg, keyData);
        }

        void elmaOlustur()
        {
            Random rnd = new Random();
            int elmaX, elmaY;
            elmaX = rnd.Next(600);
            elmaY = rnd.Next(600);

            elmaX -= elmaX % 30;
            elmaY -= elmaY % 30;

            elma.Size = new Size(30, 30);
            elma.BackColor = Color.Red;
            elma.Location = new Point(elmaX, elmaY);
            panel1.Controls.Add(elma);
        }

        void elmaYedimmi()
        {
            int puan = int.Parse(lblpuangosterge.Text);
            if (yilan[0].Location == elma.Location)
            {
                panel1.Controls.Remove(elma);
                puan += 50;
                lblpuangosterge.Text = puan.ToString();
                elmaOlustur();
                parcaEkle();
            }
        }

        void parcaEkle()
        {
            Panel ekParca = new Panel();
            ekParca.Size = new Size(30, 30);
            ekParca.BackColor = Color.Black;
            yilan.Add(ekParca);
            panel1.Controls.Add(ekParca);
        }

        void hareket()
        {
            for (int i = yilan.Count - 1; i > 0; i--)
                yilan[i].Location = yilan[i - 1].Location;
        }
    }
}
