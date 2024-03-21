namespace _6.het
{
    public partial class Form1 : Form
    {

        int hossz = 5;

        int fej_x = 100;
        int fej_y = 100;

        int ir�ny_x = 1;
        int ir�ny_y = 0;

        int l�p�ssz�m = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> list = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                //list[i] =
            }

            foreach (string s in list)
            {
                list.Add(s);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            l�p�ssz�m++;
            fej_x += ir�ny_x * K�gy�Elem.M�ret;
            fej_y += ir�ny_y * K�gy�Elem.M�ret;

            foreach (K�gy�Elem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }

           

            K�gy�Elem ke = new K�gy�Elem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            if (Controls.Count > hossz)
            {
                //K�gy�Elem lev�gand� = k�gy�[0];
                Controls.RemoveAt(0);
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }


            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }


            if (l�p�ssz�m % 2 == 0)
            {
                hossz += 1;
            }

        }
    }
}