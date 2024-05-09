namespace _11_het
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kit�r�lj�k az �sszes vez�rl�t a panelr�l  
            panel1.Controls.Clear();

            // L�trehozzuk az 1. UserControlt  
            UserControl userControl1 = new UserControl1();

            // Hozz�adjuk a panelhez.  
            panel1.Controls.Add(userControl1);

            // Dock: Az objektum sz�l�objektum�hoz val� illeszked�s�t hat�rozza meg  
            // DockSt�le.Fill: A vez�rl� mind a n�gy oldala illeszkedjen (�s m�retez�dj�n) a sz�l�objektumhoz.  
            userControl1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kit�r�lj�k az �sszes vez�rl�t a panelr�l  
            panel1.Controls.Clear();

            // L�trehozzuk a 2. UserControlt  
            UserControl userControl2 = new UserControl2();

            // Hozz�adjuk a panelhez.  
            panel1.Controls.Add(userControl2);

            // Dock: Az objektum sz�l�objektum�hoz val� illeszked�s�t hat�rozza meg  
            // DockSt�le.Fill: A vez�rl� mind a n�gy oldala illeszkedjen (�s m�retez�dj�n) a sz�l�objektumhoz.  
            userControl2.Dock = DockStyle.Fill;
        }
    }
}