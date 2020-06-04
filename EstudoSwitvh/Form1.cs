using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoSwitvh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numeroDigitado = Convert.ToInt32(txtNumero.Text);
            // 0 ~ 3: número baixo
            // 4 ~ 6: número médio
            // > 7: número alto
            switch (numeroDigitado)
            {
                case 0:
                case 1: 
                case 2:
                case 3:
                    MessageBox.Show("Número baixo");
                    break;
                case 4:
                case 5:
                case 6:
                    MessageBox.Show("Número médio");
                    break;
                default:
                    MessageBox.Show("Número alto");
                    break;
            }
        }
    }
}
