﻿namespace WfaVendas
{
    partial class FrmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numvendaLabel1;
            System.Windows.Forms.Label obsLabel;
            System.Windows.Forms.Label datavendaLabel;
            System.Windows.Forms.Label dataentregaLabel;
            System.Windows.Forms.Label txtSubtotal;
            System.Windows.Forms.Label precounitLabel;
            System.Windows.Forms.Label quantidadeLabel;
            System.Windows.Forms.Label codproLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label label1;
            this.lP2DataSet = new WfaVendas.LP2DataSet();
            this.pc_itemvendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pc_itemvendaTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_itemvendaTableAdapter();
            this.tableAdapterManager = new WfaVendas.LP2DataSetTableAdapters.TableAdapterManager();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNome = new System.Windows.Forms.ComboBox();
            this.pc_vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtNumvenda = new System.Windows.Forms.TextBox();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cmbProduto = new System.Windows.Forms.ComboBox();
            this.txtBoxSubtotal = new System.Windows.Forms.TextBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtPrecoUnit = new System.Windows.Forms.TextBox();
            this.btnGravarItem = new System.Windows.Forms.Button();
            this.btnCancelarItem = new System.Windows.Forms.Button();
            this.btnPesquisarItem = new System.Windows.Forms.Button();
            this.btnApagarItem = new System.Windows.Forms.Button();
            this.btnEditarItem = new System.Windows.Forms.Button();
            this.btnIncluirItem = new System.Windows.Forms.Button();
            this.pc_vendaTableAdapter = new WfaVendas.LP2DataSetTableAdapters.pc_vendaTableAdapter();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            numvendaLabel1 = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            datavendaLabel = new System.Windows.Forms.Label();
            dataentregaLabel = new System.Windows.Forms.Label();
            txtSubtotal = new System.Windows.Forms.Label();
            precounitLabel = new System.Windows.Forms.Label();
            quantidadeLabel = new System.Windows.Forms.Label();
            codproLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaBindingSource)).BeginInit();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // numvendaLabel1
            // 
            numvendaLabel1.AutoSize = true;
            numvendaLabel1.Location = new System.Drawing.Point(48, 34);
            numvendaLabel1.Name = "numvendaLabel1";
            numvendaLabel1.Size = new System.Drawing.Size(41, 13);
            numvendaLabel1.TabIndex = 25;
            numvendaLabel1.Text = "Venda:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Location = new System.Drawing.Point(13, 100);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(29, 13);
            obsLabel.TabIndex = 33;
            obsLabel.Text = "Obs:";
            // 
            // datavendaLabel
            // 
            datavendaLabel.AutoSize = true;
            datavendaLabel.Location = new System.Drawing.Point(12, 60);
            datavendaLabel.Name = "datavendaLabel";
            datavendaLabel.Size = new System.Drawing.Size(82, 13);
            datavendaLabel.TabIndex = 27;
            datavendaLabel.Text = "Data da Venda:";
            // 
            // dataentregaLabel
            // 
            dataentregaLabel.AutoSize = true;
            dataentregaLabel.Location = new System.Drawing.Point(241, 60);
            dataentregaLabel.Name = "dataentregaLabel";
            dataentregaLabel.Size = new System.Drawing.Size(88, 13);
            dataentregaLabel.TabIndex = 29;
            dataentregaLabel.Text = "Data da Entrega:";
            // 
            // txtSubtotal
            // 
            txtSubtotal.AutoSize = true;
            txtSubtotal.Location = new System.Drawing.Point(487, 65);
            txtSubtotal.Name = "txtSubtotal";
            txtSubtotal.Size = new System.Drawing.Size(50, 13);
            txtSubtotal.TabIndex = 26;
            txtSubtotal.Text = "SubTotal";
            // 
            // precounitLabel
            // 
            precounitLabel.AutoSize = true;
            precounitLabel.Location = new System.Drawing.Point(339, 65);
            precounitLabel.Name = "precounitLabel";
            precounitLabel.Size = new System.Drawing.Size(77, 13);
            precounitLabel.TabIndex = 23;
            precounitLabel.Text = "Preço Unitário:";
            // 
            // quantidadeLabel
            // 
            quantidadeLabel.AutoSize = true;
            quantidadeLabel.Location = new System.Drawing.Point(189, 65);
            quantidadeLabel.Name = "quantidadeLabel";
            quantidadeLabel.Size = new System.Drawing.Size(65, 13);
            quantidadeLabel.TabIndex = 21;
            quantidadeLabel.Text = "Quantidade:";
            // 
            // codproLabel
            // 
            codproLabel.AutoSize = true;
            codproLabel.Location = new System.Drawing.Point(33, 65);
            codproLabel.Name = "codproLabel";
            codproLabel.Size = new System.Drawing.Size(47, 13);
            codproLabel.TabIndex = 19;
            codproLabel.Text = "Produto:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(241, 31);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 34;
            nomeLabel.Text = "Nome:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(606, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(31, 13);
            label1.TabIndex = 29;
            label1.Text = "Total";
            // 
            // lP2DataSet
            // 
            this.lP2DataSet.DataSetName = "LP2DataSet";
            this.lP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pc_itemvendaBindingSource
            // 
            this.pc_itemvendaBindingSource.DataMember = "pc_itemvenda";
            this.pc_itemvendaBindingSource.DataSource = this.lP2DataSet;
            // 
            // pc_itemvendaTableAdapter
            // 
            this.pc_itemvendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.pc_clientesTableAdapter = null;
            this.tableAdapterManager.pc_itemvendaTableAdapter = this.pc_itemvendaTableAdapter;
            this.tableAdapterManager.pc_produtoTableAdapter = null;
            this.tableAdapterManager.pc_vendaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaVendas.LP2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.cmbNome);
            this.groupBox2.Controls.Add(numvendaLabel1);
            this.groupBox2.Controls.Add(this.txtObs);
            this.groupBox2.Controls.Add(this.txtNumvenda);
            this.groupBox2.Controls.Add(obsLabel);
            this.groupBox2.Controls.Add(datavendaLabel);
            this.groupBox2.Controls.Add(this.dtpDataVenda);
            this.groupBox2.Controls.Add(dataentregaLabel);
            this.groupBox2.Controls.Add(this.dtpDataEntrega);
            this.groupBox2.Location = new System.Drawing.Point(12, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(896, 164);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // cmbNome
            // 
            this.cmbNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_vendaBindingSource, "nome", true));
            this.cmbNome.FormattingEnabled = true;
            this.cmbNome.Location = new System.Drawing.Point(285, 26);
            this.cmbNome.Name = "cmbNome";
            this.cmbNome.Size = new System.Drawing.Size(268, 21);
            this.cmbNome.TabIndex = 35;
            // 
            // pc_vendaBindingSource
            // 
            this.pc_vendaBindingSource.DataMember = "pc_venda";
            this.pc_vendaBindingSource.DataSource = this.lP2DataSet;
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(46, 83);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(821, 69);
            this.txtObs.TabIndex = 34;
            // 
            // txtNumvenda
            // 
            this.txtNumvenda.Location = new System.Drawing.Point(95, 31);
            this.txtNumvenda.Name = "txtNumvenda";
            this.txtNumvenda.Size = new System.Drawing.Size(118, 20);
            this.txtNumvenda.TabIndex = 26;
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.CustomFormat = "dd/MM/yyyy";
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataVenda.Location = new System.Drawing.Point(95, 57);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(118, 20);
            this.dtpDataVenda.TabIndex = 28;
            // 
            // dtpDataEntrega
            // 
            this.dtpDataEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataEntrega.Location = new System.Drawing.Point(335, 57);
            this.dtpDataEntrega.Name = "dtpDataEntrega";
            this.dtpDataEntrega.Size = new System.Drawing.Size(118, 20);
            this.dtpDataEntrega.TabIndex = 30;
            // 
            // grpItem
            // 
            this.grpItem.Controls.Add(this.txtTotal);
            this.grpItem.Controls.Add(label1);
            this.grpItem.Controls.Add(this.cmbProduto);
            this.grpItem.Controls.Add(this.txtBoxSubtotal);
            this.grpItem.Controls.Add(txtSubtotal);
            this.grpItem.Controls.Add(this.nudQuantidade);
            this.grpItem.Controls.Add(this.txtPrecoUnit);
            this.grpItem.Controls.Add(precounitLabel);
            this.grpItem.Controls.Add(this.btnGravarItem);
            this.grpItem.Controls.Add(this.btnCancelarItem);
            this.grpItem.Controls.Add(quantidadeLabel);
            this.grpItem.Controls.Add(this.btnPesquisarItem);
            this.grpItem.Controls.Add(codproLabel);
            this.grpItem.Controls.Add(this.btnApagarItem);
            this.grpItem.Controls.Add(this.btnEditarItem);
            this.grpItem.Controls.Add(this.btnIncluirItem);
            this.grpItem.Location = new System.Drawing.Point(12, 331);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(896, 124);
            this.grpItem.TabIndex = 37;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Itens da Venda:";
            // 
            // txtTotal
            // 
            this.txtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "precounit", true));
            this.txtTotal.Location = new System.Drawing.Point(609, 87);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 30;
            // 
            // cmbProduto
            // 
            this.cmbProduto.FormattingEnabled = true;
            this.cmbProduto.Location = new System.Drawing.Point(32, 88);
            this.cmbProduto.Name = "cmbProduto";
            this.cmbProduto.Size = new System.Drawing.Size(121, 21);
            this.cmbProduto.TabIndex = 28;
            this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
            // 
            // txtBoxSubtotal
            // 
            this.txtBoxSubtotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "precounit", true));
            this.txtBoxSubtotal.Location = new System.Drawing.Point(490, 87);
            this.txtBoxSubtotal.Name = "txtBoxSubtotal";
            this.txtBoxSubtotal.ReadOnly = true;
            this.txtBoxSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSubtotal.TabIndex = 27;
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(192, 88);
            this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(100, 20);
            this.nudQuantidade.TabIndex = 25;
            this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
            // 
            // txtPrecoUnit
            // 
            this.txtPrecoUnit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pc_itemvendaBindingSource, "precounit", true));
            this.txtPrecoUnit.Location = new System.Drawing.Point(342, 87);
            this.txtPrecoUnit.Name = "txtPrecoUnit";
            this.txtPrecoUnit.ReadOnly = true;
            this.txtPrecoUnit.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoUnit.TabIndex = 24;
            // 
            // btnGravarItem
            // 
            this.btnGravarItem.BackColor = System.Drawing.SystemColors.Info;
            this.btnGravarItem.Enabled = false;
            this.btnGravarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGravarItem.Location = new System.Drawing.Point(456, 27);
            this.btnGravarItem.Name = "btnGravarItem";
            this.btnGravarItem.Size = new System.Drawing.Size(75, 23);
            this.btnGravarItem.TabIndex = 13;
            this.btnGravarItem.Text = "&Gravar";
            this.btnGravarItem.UseVisualStyleBackColor = false;
            this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
            // 
            // btnCancelarItem
            // 
            this.btnCancelarItem.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancelarItem.Enabled = false;
            this.btnCancelarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelarItem.Location = new System.Drawing.Point(562, 27);
            this.btnCancelarItem.Name = "btnCancelarItem";
            this.btnCancelarItem.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarItem.TabIndex = 14;
            this.btnCancelarItem.Text = "&Cancelar";
            this.btnCancelarItem.UseVisualStyleBackColor = false;
            this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
            // 
            // btnPesquisarItem
            // 
            this.btnPesquisarItem.BackColor = System.Drawing.SystemColors.Info;
            this.btnPesquisarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisarItem.Location = new System.Drawing.Point(350, 27);
            this.btnPesquisarItem.Name = "btnPesquisarItem";
            this.btnPesquisarItem.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarItem.TabIndex = 12;
            this.btnPesquisarItem.Text = "&Pesquisar";
            this.btnPesquisarItem.UseVisualStyleBackColor = false;
            this.btnPesquisarItem.Click += new System.EventHandler(this.btnPesquisarItem_Click);
            // 
            // btnApagarItem
            // 
            this.btnApagarItem.BackColor = System.Drawing.SystemColors.Info;
            this.btnApagarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApagarItem.Location = new System.Drawing.Point(244, 27);
            this.btnApagarItem.Name = "btnApagarItem";
            this.btnApagarItem.Size = new System.Drawing.Size(75, 23);
            this.btnApagarItem.TabIndex = 11;
            this.btnApagarItem.Text = "&Apagar";
            this.btnApagarItem.UseVisualStyleBackColor = false;
            this.btnApagarItem.Click += new System.EventHandler(this.btnApagarItem_Click);
            // 
            // btnEditarItem
            // 
            this.btnEditarItem.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditarItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditarItem.Location = new System.Drawing.Point(138, 27);
            this.btnEditarItem.Name = "btnEditarItem";
            this.btnEditarItem.Size = new System.Drawing.Size(75, 23);
            this.btnEditarItem.TabIndex = 10;
            this.btnEditarItem.Text = "&Editar";
            this.btnEditarItem.UseVisualStyleBackColor = false;
            this.btnEditarItem.Click += new System.EventHandler(this.btnEditarItem_Click);
            // 
            // btnIncluirItem
            // 
            this.btnIncluirItem.BackColor = System.Drawing.SystemColors.Info;
            this.btnIncluirItem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIncluirItem.Location = new System.Drawing.Point(32, 26);
            this.btnIncluirItem.Name = "btnIncluirItem";
            this.btnIncluirItem.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirItem.TabIndex = 9;
            this.btnIncluirItem.Text = "&Incluir";
            this.btnIncluirItem.UseVisualStyleBackColor = false;
            this.btnIncluirItem.Click += new System.EventHandler(this.btnIncluirItem_Click);
            // 
            // pc_vendaTableAdapter
            // 
            this.pc_vendaTableAdapter.ClearBeforeFill = true;
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvVendas.DataSource = this.pc_vendaBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(12, 218);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(874, 107);
            this.dgvVendas.TabIndex = 39;
            this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numvenda";
            this.dataGridViewTextBoxColumn1.HeaderText = "Venda";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codcli";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "datavenda";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Da Venda";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dataentrega";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data Da Entrega";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "obs";
            this.dataGridViewTextBoxColumn5.HeaderText = "Obs";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "nome";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoGenerateColumns = false;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvItens.DataSource = this.pc_itemvendaBindingSource;
            this.dgvItens.Location = new System.Drawing.Point(12, 474);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.Size = new System.Drawing.Size(874, 105);
            this.dgvItens.TabIndex = 39;
            this.dgvItens.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pc_itemvendaDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "numvenda";
            this.dataGridViewTextBoxColumn7.HeaderText = "numvenda";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "codpro";
            this.dataGridViewTextBoxColumn8.HeaderText = "Produto";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "quantidade";
            this.dataGridViewTextBoxColumn9.HeaderText = "Quantidade";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "precounit";
            this.dataGridViewTextBoxColumn10.HeaderText = "Preço Unitário";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn11.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Subtotal";
            this.dataGridViewTextBoxColumn12.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Info;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSair.Location = new System.Drawing.Point(754, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 47;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.SystemColors.Info;
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTodos.Location = new System.Drawing.Point(648, 12);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(75, 23);
            this.btnTodos.TabIndex = 46;
            this.btnTodos.Text = "&Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.SystemColors.Info;
            this.btnGravar.Enabled = false;
            this.btnGravar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnGravar.Location = new System.Drawing.Point(436, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 44;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Location = new System.Drawing.Point(542, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 45;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.Info;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Location = new System.Drawing.Point(330, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 43;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.SystemColors.Info;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApagar.Location = new System.Drawing.Point(224, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 23);
            this.btnApagar.TabIndex = 42;
            this.btnApagar.Text = "&Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Info;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Location = new System.Drawing.Point(118, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.SystemColors.Info;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIncluir.Location = new System.Drawing.Point(12, 11);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 40;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // FrmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 754);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.dgvItens);
            this.Controls.Add(this.dgvVendas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmVendas";
            this.Text = "FrmVendas";
            this.Load += new System.EventHandler(this.FrmVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_itemvendaBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_vendaBindingSource)).EndInit();
            this.grpItem.ResumeLayout(false);
            this.grpItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LP2DataSet lP2DataSet;
        private System.Windows.Forms.BindingSource pc_itemvendaBindingSource;
        private LP2DataSetTableAdapters.pc_itemvendaTableAdapter pc_itemvendaTableAdapter;
        private LP2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtNumvenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.TextBox txtBoxSubtotal;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnPesquisarItem;
        private System.Windows.Forms.Button btnApagarItem;
        private System.Windows.Forms.Button btnEditarItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.BindingSource pc_vendaBindingSource;
        private LP2DataSetTableAdapters.pc_vendaTableAdapter pc_vendaTableAdapter;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.ComboBox cmbNome;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}