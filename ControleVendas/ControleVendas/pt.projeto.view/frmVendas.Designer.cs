﻿namespace ControleVendas.pt.projeto.view
{
    partial class frmVendas
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
            txttitulo = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtcodigocliente = new TextBox();
            lblcodigo = new Label();
            txtnome = new TextBox();
            lblnome = new Label();
            dataGridView1 = new DataGridView();
            txtdescricaoproduto = new TextBox();
            label1 = new Label();
            txtpreco = new TextBox();
            lblpreco = new Label();
            txtquantidade = new TextBox();
            lblquantidade = new Label();
            btncancelar = new Button();
            btnpagamento = new Button();
            groupBox3 = new GroupBox();
            txttotal = new TextBox();
            label2 = new Label();
            btnremover = new Button();
            btnadicionar = new Button();
            txtcodigoproduto = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txttitulo
            // 
            txttitulo.AutoSize = true;
            txttitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttitulo.ForeColor = SystemColors.ButtonHighlight;
            txttitulo.Location = new Point(55, 46);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(377, 54);
            txttitulo.TabIndex = 0;
            txttitulo.Text = "Vendas de Produtos";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(txttitulo);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1365, 142);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtnome);
            groupBox1.Controls.Add(lblnome);
            groupBox1.Controls.Add(txtcodigocliente);
            groupBox1.Controls.Add(lblcodigo);
            groupBox1.Location = new Point(12, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(579, 216);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtcodigoproduto);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtquantidade);
            groupBox2.Controls.Add(lblquantidade);
            groupBox2.Controls.Add(txtpreco);
            groupBox2.Controls.Add(lblpreco);
            groupBox2.Controls.Add(txtdescricaoproduto);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 380);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(579, 243);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // txtcodigocliente
            // 
            txtcodigocliente.Font = new Font("Segoe UI", 12F);
            txtcodigocliente.Location = new Point(140, 49);
            txtcodigocliente.Name = "txtcodigocliente";
            txtcodigocliente.Size = new Size(178, 34);
            txtcodigocliente.TabIndex = 3;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.BackColor = SystemColors.ControlDark;
            lblcodigo.Font = new Font("Segoe UI", 16.2F);
            lblcodigo.Location = new Point(15, 49);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(105, 38);
            lblcodigo.TabIndex = 2;
            lblcodigo.Text = "Codigo";
            // 
            // txtnome
            // 
            txtnome.Font = new Font("Segoe UI", 12F);
            txtnome.Location = new Point(140, 128);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(407, 34);
            txtnome.TabIndex = 5;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.BackColor = SystemColors.ControlDark;
            lblnome.Font = new Font("Segoe UI", 16.2F);
            lblnome.Location = new Point(27, 128);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(93, 38);
            lblnome.TabIndex = 4;
            lblnome.Text = "Nome";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(623, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(732, 387);
            dataGridView1.TabIndex = 4;
            // 
            // txtdescricaoproduto
            // 
            txtdescricaoproduto.Font = new Font("Segoe UI", 12F);
            txtdescricaoproduto.Location = new Point(230, 78);
            txtdescricaoproduto.Multiline = true;
            txtdescricaoproduto.Name = "txtdescricaoproduto";
            txtdescricaoproduto.Size = new Size(322, 38);
            txtdescricaoproduto.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 78);
            label1.Name = "label1";
            label1.Size = new Size(137, 38);
            label1.TabIndex = 2;
            label1.Text = "Descricao";
            // 
            // txtpreco
            // 
            txtpreco.Font = new Font("Segoe UI", 12F);
            txtpreco.Location = new Point(230, 130);
            txtpreco.Multiline = true;
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(171, 38);
            txtpreco.TabIndex = 5;
            // 
            // lblpreco
            // 
            lblpreco.AutoSize = true;
            lblpreco.BackColor = Color.DarkGray;
            lblpreco.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpreco.Location = new Point(77, 130);
            lblpreco.Name = "lblpreco";
            lblpreco.Size = new Size(87, 38);
            lblpreco.TabIndex = 4;
            lblpreco.Text = "Preço";
            // 
            // txtquantidade
            // 
            txtquantidade.Font = new Font("Segoe UI", 12F);
            txtquantidade.Location = new Point(230, 183);
            txtquantidade.Multiline = true;
            txtquantidade.Name = "txtquantidade";
            txtquantidade.Size = new Size(171, 38);
            txtquantidade.TabIndex = 7;
            // 
            // lblquantidade
            // 
            lblquantidade.AutoSize = true;
            lblquantidade.BackColor = Color.DarkGray;
            lblquantidade.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblquantidade.Location = new Point(3, 183);
            lblquantidade.Name = "lblquantidade";
            lblquantidade.Size = new Size(161, 38);
            lblquantidade.TabIndex = 6;
            lblquantidade.Text = "Quantidade";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = SystemColors.ActiveCaption;
            btncancelar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btncancelar.Location = new Point(1012, 646);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(342, 53);
            btncancelar.TabIndex = 6;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnpagamento
            // 
            btnpagamento.BackColor = SystemColors.ActiveCaption;
            btnpagamento.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpagamento.Location = new Point(623, 646);
            btnpagamento.Name = "btnpagamento";
            btnpagamento.Size = new Size(329, 53);
            btnpagamento.TabIndex = 5;
            btnpagamento.Text = "Pagamento";
            btnpagamento.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txttotal);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(626, 563);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(730, 77);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttotal.Location = new Point(468, 20);
            txttotal.Multiline = true;
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(246, 38);
            txttotal.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkGray;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(339, 20);
            label2.Name = "label2";
            label2.Size = new Size(75, 38);
            label2.TabIndex = 4;
            label2.Text = "Total";
            // 
            // btnremover
            // 
            btnremover.BackColor = SystemColors.ActiveCaption;
            btnremover.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnremover.Location = new Point(340, 646);
            btnremover.Name = "btnremover";
            btnremover.Size = new Size(251, 53);
            btnremover.TabIndex = 9;
            btnremover.Text = "Remover";
            btnremover.UseVisualStyleBackColor = false;
            // 
            // btnadicionar
            // 
            btnadicionar.BackColor = SystemColors.ActiveCaption;
            btnadicionar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnadicionar.Location = new Point(15, 646);
            btnadicionar.Name = "btnadicionar";
            btnadicionar.Size = new Size(241, 53);
            btnadicionar.TabIndex = 8;
            btnadicionar.Text = "Adicionar";
            btnadicionar.UseVisualStyleBackColor = false;
            // 
            // txtcodigoproduto
            // 
            txtcodigoproduto.Font = new Font("Segoe UI", 12F);
            txtcodigoproduto.Location = new Point(230, 23);
            txtcodigoproduto.Multiline = true;
            txtcodigoproduto.Name = "txtcodigoproduto";
            txtcodigoproduto.Size = new Size(171, 38);
            txtcodigoproduto.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkGray;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 23);
            label3.Name = "label3";
            label3.Size = new Size(105, 38);
            label3.TabIndex = 8;
            label3.Text = "Codigo";
            // 
            // frmVendas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1366, 723);
            Controls.Add(btnremover);
            Controls.Add(btnadicionar);
            Controls.Add(groupBox3);
            Controls.Add(btncancelar);
            Controls.Add(btnpagamento);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "frmVendas";
            Text = "frmVendas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label txttitulo;
        private Panel panel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtcodigocliente;
        private Label lblcodigo;
        private TextBox txtnome;
        private Label lblnome;
        private DataGridView dataGridView1;
        private TextBox txtdescricaoproduto;
        private Label label1;
        private TextBox txtpreco;
        private Label lblpreco;
        private TextBox txtquantidade;
        private Label lblquantidade;
        private Button btncancelar;
        private Button btnpagamento;
        private GroupBox groupBox3;
        private TextBox txttotal;
        private Label label2;
        private Button btnremover;
        private Button btnadicionar;
        private TextBox txtcodigoproduto;
        private Label label3;
    }
}