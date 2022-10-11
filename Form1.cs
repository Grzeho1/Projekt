using System.Runtime.InteropServices;
using System.Data.SqlClient;
namespace Projekt
    
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightElliepse

            );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            panelNavigace.Height = tlacitkoDomu.Height;
            panelNavigace.Top = tlacitkoDomu.Top;
            panelNavigace.Left = tlacitkoDomu.Left;
            tlacitkoDomu.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Domù";
            this.panelHlavni.Controls.Clear();
            formDomu formDomu = new formDomu() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formDomu.FormBorderStyle = FormBorderStyle.None;
            this.panelHlavni.Controls.Add(formDomu);
            formDomu.Show();

            

        }
        


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelJmeno.Text = uzivatel.Login;
        }

        private void tlacitkoDomu_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoDomu.Height;
            panelNavigace.Top = tlacitkoDomu.Top;
            panelNavigace.Left = tlacitkoDomu.Left;
            tlacitkoDomu.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Domù";
            this.panelHlavni.Controls.Clear();
            formDomu formDomu = new formDomu() { Dock = DockStyle.Fill,TopLevel=false,TopMost = true};
            formDomu.FormBorderStyle = FormBorderStyle.None;
            this.panelHlavni.Controls.Add(formDomu);
            formDomu.Show();
        }

        private void tlacitkoDomu_Leave(object sender, EventArgs e)
        {
            tlacitkoDomu.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void tlacitkoTodo_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoTodo.Height;
            panelNavigace.Top = tlacitkoTodo.Top;
            panelNavigace.Left = tlacitkoTodo.Left;
            tlacitkoTodo.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "ToDo";
            this.panelHlavni.Controls.Clear();
            formTodo formTodo = new formTodo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTodo.FormBorderStyle = FormBorderStyle.None;
            this.panelHlavni.Controls.Add(formTodo);
            formTodo.Show();
        }

        private void tlacitkoTodo_Leave(object sender, EventArgs e)
        {
            tlacitkoTodo.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void tlacitkoNastaveni_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoNastaveni.Height;
            panelNavigace.Top = tlacitkoNastaveni.Top;
            panelNavigace.Left = tlacitkoNastaveni.Left;
            tlacitkoNastaveni.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Nastavení";
        }

        private void tlacitkoKalendar_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoKalendar.Height;
            panelNavigace.Top = tlacitkoKalendar.Top;
            panelNavigace.Left = tlacitkoKalendar.Left;
            tlacitkoKalendar.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Kalendáø";
        }

        private void tlacitkoKalendar_Leave(object sender, EventArgs e)
        {
            tlacitkoKalendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void tlacitkoNastaveni_Leave(object sender, EventArgs e)
        {
            tlacitkoNastaveni.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tlacitkoKrypto_Click(object sender, EventArgs e)
        {
            panelNavigace.Height = tlacitkoKrypto.Height;
            panelNavigace.Top = tlacitkoKrypto.Top;
            panelNavigace.Left = tlacitkoKrypto.Left;
            tlacitkoKrypto.BackColor = Color.FromArgb(46, 51, 73);

            labelNazev.Text = "Krypto";
        }

        private void tlacitkoKrypto_Leave(object sender, EventArgs e)
        {
            tlacitkoKrypto.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    
}