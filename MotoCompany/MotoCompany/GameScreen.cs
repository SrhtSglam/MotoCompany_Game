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
    public partial class GameScreen : UserControl
    {
        MainForm main;

        public GameScreen(MainForm form)
        {
            InitializeComponent();
            main = form;
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnMap_Click(object sender, EventArgs e)
        {

        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            main.ShowScreen(new PCScreen());
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {

        }
    }
}
