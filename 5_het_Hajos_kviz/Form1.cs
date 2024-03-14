using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _5_het_Hajos_kviz
{
    public partial class Form1 : Form
    {

        List<Kerdes> OsszesKerdes;
        List<Kerdes> AktualisKerdesek;
        int MegjelenitettKerdesSzama = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OsszesKerdes = new List<Kerdes>();
            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(OsszesKerdes[0]);
                OsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;
        }

        void KerdesMegjelenitese(Kerdes kerdes)
        {
            label1.Text = kerdes.KérdésSzöveg;
            textBox1.Text = kerdes.Válasz1;
            textBox2.Text = kerdes.Válasz2;
            textBox3.Text = kerdes.Válasz3;

            if (string.IsNullOrEmpty(kerdes.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Visible =true;
                /*pictureBox1.Load()*/
            }

            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
        }

        List<Kerdes> KerdesekBeolvasasa()
        {
            List<Kerdes> kerdesek = new();
            StreamReader sr = new StreamReader("hajosszabalyzat.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "n/a";
                string[] tömb = sor.Split("\t");

                if (tömb.Length != 7) continue;

                Kerdes k = new();
                k.KérdésSzöveg = tömb[1].ToUpper();
                k.Válasz1 = tömb[2].Trim('"');
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);

                k.HelyesVálasz = x;



                kerdesek.Add(k);
            }

            sr.Close();
            return kerdesek;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MegjelenitettKerdesSzama++;
            if (MegjelenitettKerdesSzama == AktualisKerdesek.Count) MegjelenitettKerdesSzama = 0;

            KerdesMegjelenitese(AktualisKerdesek[MegjelenitettKerdesSzama]);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Salmon;
            if (AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálasz == 1)
            {
                textBox1.BackColor = Color.LightGreen;
                AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálaszokSzáma++;
            }
            else
            {
                textBox1.BackColor = Color.Salmon;
                AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálaszokSzáma = 0;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Salmon;
            if (AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálasz == 1)
            {
                textBox2.BackColor = Color.LightGreen;
                AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálaszokSzáma++;
            }
            else
            {
                textBox2.BackColor = Color.Salmon;
                AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálaszokSzáma = 0;
            }
        }
        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Salmon;
            if (AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálasz == 1)
            {
                textBox3.BackColor = Color.LightGreen;
                AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálaszokSzáma++;
            }
            else
            {
                textBox3.BackColor = Color.Salmon;
                AktualisKerdesek[MegjelenitettKerdesSzama].HelyesVálaszokSzáma = 0;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}