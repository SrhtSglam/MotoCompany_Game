using MotoCompany.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace MotoCompany
{
    public partial class Warehouse : UserControl
    {
        GameScreen game;

        public Warehouse(GameScreen parent)
        {
            InitializeComponent();
            game = parent;
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            var list = new List<Part>();
            list.Add(new Part { Name = "Vida", Price = 2, Amount = 3});
            list.Add(new Part { Name = "Somun", Price = 2, Amount = 6});
            list.Add(new Part { Name = "Sağ Manet", Price = 100, Amount = 2});
            list.Add(new Part { Name = "Sol Manet", Price = 100, Amount = 1});
            lstParts.DataSource = list;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            game.ShowSubScreen(null);
        }
    }
}
