using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoCompany
{
    public partial class MainMenu : UserControl
    {
        MainForm main;
        public MainMenu(MainForm form)
        {
            InitializeComponent();
            main = form;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            main.ShowScreen(new GameScreen(main));
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
