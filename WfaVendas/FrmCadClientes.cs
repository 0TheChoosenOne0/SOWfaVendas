using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfaVendas.LP2DataSetTableAdapters;

namespace WfaVendas
{
    public partial class FrmCadClientes : Form
    {
        bool incluir = false;
        bool alterar = false;
        private object vendaDataSet;

        public FrmCadClientes()
        {
            InitializeComponent();
        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_clientesTableAdapter.Fill(this.lP2DataSet.pc_clientes);


        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HabilitaBotoes(bool hab)
        {
            foreach (Control btn in Controls)
            {
                if (btn is Button)
                {
                    btn.Enabled = hab;
                    if (btn.Name == "btnGravar" || btn.Name == "btnCancelar")
                    {
                        btn.Enabled = !hab;
                    }
                }
            }
        }

        private void HabilitaCampos(bool hab)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox || item is MaskedTextBox ||
                    item is DateTimePicker)
                { 
                   item.Enabled = hab;
                }
            }
        }

        private void LimpaCampos()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                } 
                else if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitaBotoes(false);
            HabilitaCampos(true);
            LimpaCampos();
            incluir = true;
            txtNome.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pc_clientesTableAdapter.Insert(txtNome.Text, txtEndereco.Text, txtCidade.Text,
                    txtBairro.Text, mskUf.Text, mskCep.Text, mskTelefone.Text, dtpDatanasc.Value);
                    MessageBox.Show("Incluido com sucesso! ", "Aviso:",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    pc_clientesTableAdapter.Update(txtNome.Text,txtEndereco.Text,txtBairro.Text,txtCidade.Text,mskUf.Text,mskCep.Text,mskTelefone.Text, Convert.ToDateTime(dtpDatanasc.Value), int.Parse(txtCodcli.Text));
                    MessageBox.Show("Alterado Com Sucesso!", "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                FrmCadClientes_Load(null, null);
                btnCancelar_Click(null, null);  
            }
            catch(Exception ex) 
            { 
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message,"Erro:",     
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            HabilitaBotoes(true);
            HabilitaCampos(false);
            LimpaCampos();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "telefone")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5) + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }
                }
            }
            else if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "CEP")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != null)
                    {
                        stringValue = stringValue.Substring(0, 5) + "-" + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }
                }
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                alterar = true;
                HabilitaBotoes(false);
                HabilitaCampos(true);
                txtCodcli.Enabled = false;
                txtCodcli.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                mskCep.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                mskUf.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                mskTelefone.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                dtpDatanasc.Value = Convert.ToDateTime(dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString());
                txtNome.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", "Atenção: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        pc_clientesTableAdapter.Delete(Convert.ToInt32(dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString()));
                        FrmCadClientes_Load(null, null);
                        MessageBox.Show(null, "Apagado Com Sucesso!", "Exclusão", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Seleciona Um Cliente Primeiro!", "Erro Ao Excluir: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)
            {
                txtNome.Enabled = true;
                txtNome.Focus();
                HabilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome desejado ou " + "\nparte dele.", "Pesquisa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                pc_clientesTableAdapter.FillByNome(this.lP2DataSet.pc_clientes, '%' + txtNome.Text + '%');
                btnCancelar_Click(null, null);
            }
        }

        private void dgvClientes_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
