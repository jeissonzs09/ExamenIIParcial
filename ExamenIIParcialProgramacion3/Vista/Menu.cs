using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ticketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tickets ticketsFormulario = new Tickets();
            this.Hide();
            ticketsFormulario.Show();
        }
    }
}
