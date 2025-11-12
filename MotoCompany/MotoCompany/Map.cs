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
    public partial class Map : UserControl
    {
        GameScreen game;

        public Map(GameScreen parent)
        {
            InitializeComponent();
            game = parent;
        }

        private void Map_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            game.ShowSubScreen(null);
        }

        private void btnRegionTr_Click(object sender, EventArgs e)
        {

        }

        private void btnRegionFr_Click(object sender, EventArgs e)
        {

        }

        private void btnRegionDu_Click(object sender, EventArgs e)
        {

        }
    }
}
