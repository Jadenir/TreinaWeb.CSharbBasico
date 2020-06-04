using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstruturasRepeticao
{
    public partial class frmEstruturasRepeticao : Form
    {
        public frmEstruturasRepeticao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtNumero.Text);
            //for
            /*for (int i = 0; i < 10; i++)
            {
                lsbResultados.Items.Add(string.Format("{0} x {1} = {2}", numero, i, numero * i));

            }*/


            int i = 0;
            /*while(i < 10)
            {
                lsbResultados.Items.Add(string.Format("{0} x {1} = {2}", numero, i, numero * i));
                i++;
            }*/


            do
            {
                lsbResultados.Items.Add(string.Format("{0} x {1} = {2}", numero, i, numero * i));
                i++;
            } while (i < 10);
        }
    }
}
