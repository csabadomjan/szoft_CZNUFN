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
            // Kitöröljük az összes vezérlõt a panelrõl  
            panel1.Controls.Clear();

            // Létrehozzuk az 1. UserControlt  
            UserControl userControl1 = new UserControl1();

            // Hozzáadjuk a panelhez.  
            panel1.Controls.Add(userControl1);

            // Dock: Az objektum szülõobjektumához való illeszkedését határozza meg  
            // DockStíle.Fill: A vezérlõ mind a négy oldala illeszkedjen (és méretezõdjön) a szülõobjektumhoz.  
            userControl1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kitöröljük az összes vezérlõt a panelrõl  
            panel1.Controls.Clear();

            // Létrehozzuk a 2. UserControlt  
            UserControl userControl2 = new UserControl2();

            // Hozzáadjuk a panelhez.  
            panel1.Controls.Add(userControl2);

            // Dock: Az objektum szülõobjektumához való illeszkedését határozza meg  
            // DockStíle.Fill: A vezérlõ mind a négy oldala illeszkedjen (és méretezõdjön) a szülõobjektumhoz.  
            userControl2.Dock = DockStyle.Fill;
        }
    }
}