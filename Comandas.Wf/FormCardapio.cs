using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comandas.Wf
{
    public partial class FormCardapio : Form
    {
        public FormCardapio()
        {
            InitializeComponent();
        }

        private void btnAdItemCardapio_Click(object sender, EventArgs e)
        {
            new FormCardapioCad().ShowDialog();
        }
    }
}
