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
    public partial class PCScreen : UserControl
    {
        MainForm main;
        public PCScreen(MainForm form)
        {
            InitializeComponent();
            main = form;
        }

        private void PCScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnShop_Click(object sender, EventArgs e)
        {

        }

        private void btnComCoin_Click(object sender, EventArgs e)
        {

        }

        private void btnBackPage_Click(object sender, EventArgs e)
        {
            main.ShowScreen(new GameScreen(main));
        }
    }
}
