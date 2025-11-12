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
        UserControl activeSubScreen;

        public GameScreen(MainForm form)
        {
            InitializeComponent();
            main = form;
        }

        public void ShowSubScreen(UserControl subScreen)
        {
            if (activeSubScreen != null)
            {
                pnlSubScreen.Controls.Remove(activeSubScreen);
                activeSubScreen = null;
            }

            if (subScreen != null)
            {
                activeSubScreen = subScreen;
                subScreen.Dock = DockStyle.Fill;
                pnlSubScreen.Controls.Add(subScreen);
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            ShowSubScreen(new Map(this));
        }

        private void btnPC_Click(object sender, EventArgs e)
        {
            main.ShowScreen(new PCScreen(main));
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            ShowSubScreen(new Warehouse(this));
        }
    }
}
