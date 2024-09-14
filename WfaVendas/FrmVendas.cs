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
            if (dgvVendas.Rows.Count > 0)
            {
                dgvVendas.Rows[0].Selected = true;
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir a VENDA selecionada?", "Atenção: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pc_itemvendaTableAdapter.DeleteTodos(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        pc_vendaTableAdapter.Delete(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
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
            limpaCampos(this);
            limpaCampos(grpItem);
            habilitaCampos(false);
            habilitaBotoes(true);
            editar = false;
            incluir = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVendas.SelectedRows.Count > 0)
            {
                editar = true;
                habilitaBotoes(false);
                habilitaCampos(true);
                txtNumvenda.Enabled = false;
                txtNumvenda.Text = dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbNome.SelectedValue = Convert.ToInt32(dgvVendas[1, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataVenda.Value = Convert.ToDateTime(dgvVendas[2, dgvVendas.CurrentRow.Index].Value.ToString());
                dtpDataEntrega.Value = Convert.ToDateTime(dgvVendas[3, dgvVendas.CurrentRow.Index].Value.ToString());
                txtObs.Text = dgvVendas[4, dgvVendas.CurrentRow.Index].Value.ToString();
                cmbNome.Focus();
            }
            else 
            {
                MessageBox.Show(null, "Selecione uma Venda Primeiro!", "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (cmbNome.Enabled == false)
            {
                cmbNome.Enabled = true;
                cmbNome.Focus();
                habilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false; 
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome do cliente desejado ou " + "\nparte dele.", "Pesquisa: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pc_vendaTableAdapter.FillByNome(this.lP2DataSet.pc_venda, "%" + cmbNome.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void btnIncluirItem_Click(object sender, EventArgs e)
        {
            incluirItem = true;
            habilitaCamposItem(false);
            habilitaBotoesItem(false);
            cmbProduto_SelectedIndexChanged(null, null);
            cmbProduto.Focus();
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable produto = pc_produtoTableAdapter.GetDataBy(cmbProduto.Text); //TODO arrumar o getby no database, capaz de ter que arrumar em todos os tables
            precoTemp = 0;
            foreach (DataRow row in produto.Rows)
            {
                precoTemp = Convert.ToDouble(row["precounit"].ToString());
            }
            nudQuantidade.Value = 1;
            txtPrecoUnit.Text = precoTemp.ToString("R$ #,###,##0.00");
            txtBoxSubtotal.Text = precoTemp.ToString("R$ #,###,##0.00");
        }

        private void nudQuantidade_ValueChanged(object sender, EventArgs e)
        {
            double subTotal = (Int32)nudQuantidade.Value * precoTemp;
            txtBoxSubtotal.Text = subTotal.ToString("R$ #,###,##0.00");
        }

        private void btnApagarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItens.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o ITEM selecionado?", "Atenção: ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pc_itemvendaTableAdapter.DeleteTodos(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                        pc_itemvendaTableAdapter.DeleteTodos(Convert.ToInt32(dgvItens[0, dgvItens.CurrentRow.Index].Value.ToString()));
                        dgvVendas_SelectionChanged(null, null);
                        MessageBox.Show(null, "Apagado com sucesso!", "Exclusão: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show(null, "Selecione um item primeiro!", "Erro ao excluir: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVendas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvVendas.RowCount > 0)
                {
                    this.pc_itemvendaTableAdapter.FillByNumVenda(this.lP2DataSet.pc_itemvenda, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                    if (dgvVendas.RowCount > 0)
                    {
                        double total = (Double)pc_itemvendaTableAdapter.TotalVenda(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
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

        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count > 0)
            {
                editarItem = true;
                habilitaBotoesItem(false); 
                habilitaCamposItem(true);
                cmbProduto.Text = dgvItens[1, dgvItens.CurrentRow.Index].Value.ToString();
                cmbProduto_SelectedIndexChanged(null, null);
                nudQuantidade.Value = Convert.ToInt32(dgvItens[2, dgvItens.CurrentRow.Index].Value.ToString());
                cmbProduto.Focus();
            }
            else
            {
                MessageBox.Show(null, "Selecione um ITEM primeiro!", "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItens.RowCount > 0)
                {
                    if (cmbProduto.Enabled == false)
                    {
                        cmbProduto.Enabled = true;
                        cmbProduto.Focus();
                        habilitaBotoesItem(false);
                        btnPesquisarItem.Enabled = true;
                        btnGravarItem.Enabled = false;
                        btnCancelarItem.Enabled = false;
                        MessageBox.Show(null, "Digite o nome do ITEM desejado ou " + "\nparte dele.", "Pesquisa: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        //pc_itemvendaTableAdapter.FillByDescricao(this.lP2DataSet.pc_itemvenda,Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()), "%" + cmbProduto.Text + "%"); <-- não sei pq krls ta dando erro
                        btnCancelar_Click(null, null);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Cadastre um item primeiro!", "Erro ao excluir: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarItem_Click(object sender, EventArgs e)
        {
            limpaCampos(grpItem);
            habilitaCamposItem(false);
            habilitaBotoesItem(true);
            editarItem = false;
            incluirItem = false;    
        }

        private void btnGravarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluirItem)
                {
                    pc_itemvendaTableAdapter.Insert(Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()), (Int32)cmbProduto.SelectedValue, (Int32)nudQuantidade.Value, precoTemp);
                    MessageBox.Show(null, "Incluido com sucesso!", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (editarItem)
                {
                    pc_itemvendaTableAdapter.Update((Int32)cmbProduto.SelectedValue, (Int32)nudQuantidade.Value, (Int32)precoTemp, Convert.ToInt32(dgvVendas[0, dgvVendas.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show(null, "Alterado com sucesso!", "Alteração: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvVendas_SelectionChanged(null, null);
                btnCancelarItem_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro: \n" + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            FrmVendas_Load(null, null);
        }
    }
}
