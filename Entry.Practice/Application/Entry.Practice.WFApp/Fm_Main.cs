using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entry.Practice.WFApp
{
    public partial class Fm_Main : Form
    {
        public Fm_Main()
        {
            InitializeComponent();
        }

        private void Fm_Main_Load(object sender, EventArgs e)
        {
            var arr = new [] { "[世界观]，就是人们对[整个世界]以及人与世界关系的根本观点、根本看法。","[哲学]是[理论化、系统化]的[世界观]。"};

            foreach (var item in arr)
            {

            }

        }
    }
}
