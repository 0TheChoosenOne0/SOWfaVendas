using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmVendas : Form
    {
        bool incluir = false;
        bool editar = false;
        bool editarItem = false;
        bool incluirItem = false;
        double precoTemp = 0;

        public FrmVendas()
        {
            InitializeComponent();
        }

        private void pc_itemvendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pc_itemvendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.lP2DataSet);

        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {

            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_venda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_vendaTableAdapter.Fill(this.lP2DataSet.pc_venda);
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_itemvenda'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_itemvendaTableAdapter.Fill(this.lP2DataSet.pc_itemvenda);
            if (pc_vendaDataGridView.Rows.Count > 0)
            {
                pc_vendaDataGridView.Rows[0].Selected = true;
            }
        }

        private void pc_vendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pc_itemvendaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void habilitaCampos(bool hab)
        {
            txtNumvenda.Enabled = hab;
            cmbNome.Enabled = hab;
            dtpDataVenda.Enabled = hab;
            dtpDataEntrega.Enabled = hab;
            txtObs.Enabled = hab;
        }

        private void habilitaCamposItem(bool hab)
        {
            cmbProduto.Enabled = hab;
            nudQuantidade.Enabled = hab;
        }

        private void habilitaBotoes(bool hab)
        {
            btnIncluirItem.Enabled = hab;
            btnApagarItem.Enabled = hab;
            btnEditarItem.Enabled = hab;
            btnPesquisarItem.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravarItem.Enabled = !hab;
            btnCancelarItem.Enabled = !hab;
        }

        private void habilitaBotoesItem(bool hab)
        {
            btnIncluirItem.Enabled = hab;
            btnApagarItem.Enabled = hab;
            btnEditarItem.Enabled = hab;
            btnPesquisarItem.Enabled = hab;
            btnSair.Enabled = hab;
            btnGravarItem.Enabled = hab;
            btnCancelarItem.Enabled = hab;
        }

        private void limpaCampos(Control local)
        {
            foreach (Control item in local.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                    if (((TextBox)item).Name == "txtPrecoUnit" || ((TextBox)item).Name == "txtBoxSubTotal" || ((TextBox)item).Name == "txtTotal")
                    {
                        ((TextBox)item).Text = "R$ 0,00";
                    }
                }
                if (item is NumericUpDown)
                {
                    ((NumericUpDown)item).Value = 1;
                }
                if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                if (item is ComboBox)
                {
                    if (((ComboBox)item).Items.Count > 0)
                    {
                        ((ComboBox)item).SelectedIndex = 0;
                    }
                }
                if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            incluir = true;
            habilitaCampos(true);
            habilitaBotoes(false);
            txtNumvenda.Focus();
        }

        private void pc_vendaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (pc_vendaDataGridView.RowCount > 0)
                {
                    this.pc_itemvendaTableAdapter.FillByNumVenda(this.lP2DataSet.pc_itemvenda, Convert.ToInt32(pc_vendaDataGridView[0, pc_vendaDataGridView.CurrentRow.Index].Value.ToString()));
                    if (pc_vendaDataGridView.RowCount > 0)
                    {
                        double total = (Double)pc_itemvendaTableAdapter.TotalVenda(Convert.ToInt32(pc_vendaDataGridView[0, pc_vendaDataGridView.CurrentRow.Index].Value.ToString()));
                        txtTotal.Text = total.ToString("R$ #,###,##0.00");
                    }
                    else
                    {
                        txtTotal.Text = "R$ 0,00";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(null, "Ocorreu um erro:\n " + ex.Message, "Erro ao acessar os items da VENDA: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pc_vendaDataGridView.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir a VENDA selecionada?", "Atenção: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pc_itemvendaTableAdapter.DeleteTodos(Convert.ToInt32(pc_vendaDataGridView[0, pc_vendaDataGridView.CurrentRow.Index].Value.ToString()));
                        pc_vendaTableAdapter.Delete(Convert.ToInt32(pc_vendaDataGridView[0, pc_vendaDataGridView.CurrentRow.Index].Value.ToString()));
                        FrmVendas_Load(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Sucesso: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione uma venda primeiro!", "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    //pc_itemvendaTableAdapter.Insert(Convert.ToInt32(txtNumvenda.Text), Convert.ToInt32(cmbNome.SelectedValue),dtpDataVenda.Value, dtpDataEntrega.Value, txtObs.Text); <--- tenho ctz q ta errado, ver no dataset
                    MessageBox.Show(null, "Incluido com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (editar)
                {
                    //pc_itemvendaTableAdapter.Update((Int32)cmbNome.SelectedValue, Convert.ToInt32(dtpDataVenda.Value), Convert.ToInt32(dtpDataEntrega.Value), Convert.ToInt32(txtObs.Text), Convert.ToInt32(txtNumvenda.Text));<--- tenho ctz q ta errado, ver no dataset
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnCancelar_Click(null,null);
                FrmVendas_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
