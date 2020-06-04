using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContatosTreinaWeb
{
    public partial class frmAgendaContato : Form
    {
        private OperacaoEnum acao;
        public frmAgendaContato()
        {
            InitializeComponent();
        }

        //shown
        private void frmAgendaContato_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            CarregarListaContatos();
            AlterarStadoCampos(false);
        }


        //Click
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Popula objeto contato
            Contato contato = new Contato
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                NumeroTelefone = txtTelefone.Text
            };
            //Percore objeto para preencher lista
            List<Contato> contatosList = new List<Contato>();
            foreach (Contato contatoDaLista in lbxContatos.Items)
            {
                contatosList.Add(contatoDaLista);
            }
            //Valida se vai incluir novo
            if (acao == OperacaoEnum.INCLUIR)
            {
                contatosList.Add(contato);
            }
            //Valida se vai alterar
            if (acao == OperacaoEnum.ALTERAR)
            {
                int indice = lbxContatos.SelectedIndex;
                contatosList.RemoveAt(indice);
                contatosList.Insert(indice, contato);
            }
            //escreve o arquivo
            ManipuladorDeArquivos.EscreverArquivo(contatosList);
            CarregarListaContatos();
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            LimparCampos();
            AlterarStadoCampos(false);
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarStadoCampos(true);
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indexExcluido = lbxContatos.SelectedIndex;
                lbxContatos.SelectedIndex = 0;
                lbxContatos.Items.RemoveAt(indexExcluido);
                List<Contato> contatosList = new List<Contato>();
                foreach (Contato contato in lbxContatos.Items)
                {
                    contatosList.Add(contato);
                }
                ManipuladorDeArquivos.EscreverArquivo(contatosList);
                CarregarListaContatos();
                LimparCampos();
            }
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarStadoCampos(true);
            acao = OperacaoEnum.INCLUIR;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarECancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarStadoCampos(false);
        }


        //SelectedIndexChanged
        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contato contato = (Contato)lbxContatos.Items[lbxContatos.SelectedIndex];
            txtNome.Text = contato.Nome;
            txtEmail.Text = contato.Email;
            txtTelefone.Text = contato.NumeroTelefone;
        }


        //Métodos
        private void AlterarBotoesSalvarECancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }
        private void AlterarBotoesIncluirAlterarExcluir(bool estado)
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }
        private void AlterarStadoCampos(bool estado)
        {
            txtNome.Enabled = estado;
            txtEmail.Enabled = estado;
            txtTelefone.Enabled = estado;
        }
        private void CarregarListaContatos()
        {
            lbxContatos.Items.Clear();
            lbxContatos.Items.AddRange(ManipuladorDeArquivos.LerArquivo().ToArray());
        }
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            txtTelefone.Text = "";
        }


    }
}

