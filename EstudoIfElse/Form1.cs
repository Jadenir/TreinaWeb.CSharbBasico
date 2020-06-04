using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoIfElse
{
    public partial class frmIfElse : Form
    {
        public frmIfElse()
        {
            InitializeComponent();
        }

        private void btnVerificarIdade_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);
            if(idade >= 18)
            {
                MessageBox.Show("Você é maior de idade.");
            }
            else 
            {
                MessageBox.Show("Você é menor de idade.");
            }
        }
    }
}
