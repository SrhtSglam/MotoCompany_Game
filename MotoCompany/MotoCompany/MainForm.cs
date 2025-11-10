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
    public partial class MainForm : Form
    {
        UserControl activeScreen;
        public MainForm()
        {
            InitializeComponent();
            ShowScreen(new MainMenu(this));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public void ShowScreen(UserControl screen)
        {
            if (activeScreen != null)
                Controls.Remove(activeScreen);

            activeScreen = screen;
            screen.Dock = DockStyle.Fill;
            Controls.Add(screen);
        }
    }
}
