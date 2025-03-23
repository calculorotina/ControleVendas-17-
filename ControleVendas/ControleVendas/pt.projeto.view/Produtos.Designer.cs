namespace ControleVendas.pt.projeto.view
{
    partial class Produtos
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
            panel1 = new Panel();
            lblprodutos = new Label();
            tabelaprodutos = new TabControl();
            tabprodutos = new TabPage();
            txtfornecedor = new ComboBox();
            txtcodigo = new TextBox();
            label1 = new Label();
            lblfornid = new Label();
            txtfamilia = new ComboBox();
            lblfamilia = new Label();
            textBox1 = new TextBox();
            lblquantidade = new Label();
            txtpreco = new TextBox();
            lblpreco = new Label();
            txtdescricao = new TextBox();
            lblnome = new Label();
            tablistprodutos = new TabPage();
            dataproduto = new DataGridView();
            btnnovo = new Button();
            btngravar = new Button();
            btneditar = new Button();
            btnpagar = new Button();
            btnpesquisa = new Button();
            txtpesquisa = new TextBox();
            panel1.SuspendLayout();
            tabelaprodutos.SuspendLayout();
            tabprodutos.SuspendLayout();
            tablistprodutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataproduto).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblprodutos);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1186, 145);
            panel1.TabIndex = 0;
            // 
            // lblprodutos
            // 
            lblprodutos.AutoSize = true;
            lblprodutos.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblprodutos.ForeColor = SystemColors.ButtonHighlight;
            lblprodutos.Location = new Point(36, 40);
            lblprodutos.Name = "lblprodutos";
            lblprodutos.Size = new Size(202, 60);
            lblprodutos.TabIndex = 0;
            lblprodutos.Text = "Produtos";
            // 
            // tabelaprodutos
            // 
            tabelaprodutos.Controls.Add(tabprodutos);
            tabelaprodutos.Controls.Add(tablistprodutos);
            tabelaprodutos.Location = new Point(12, 163);
            tabelaprodutos.Name = "tabelaprodutos";
            tabelaprodutos.SelectedIndex = 0;
            tabelaprodutos.Size = new Size(1186, 301);
            tabelaprodutos.TabIndex = 1;
            // 
            // tabprodutos
            // 
            tabprodutos.Controls.Add(txtfornecedor);
            tabprodutos.Controls.Add(txtcodigo);
            tabprodutos.Controls.Add(label1);
            tabprodutos.Controls.Add(lblfornid);
            tabprodutos.Controls.Add(txtfamilia);
            tabprodutos.Controls.Add(lblfamilia);
            tabprodutos.Controls.Add(textBox1);
            tabprodutos.Controls.Add(lblquantidade);
            tabprodutos.Controls.Add(txtpreco);
            tabprodutos.Controls.Add(lblpreco);
            tabprodutos.Controls.Add(txtdescricao);
            tabprodutos.Controls.Add(lblnome);
            tabprodutos.Location = new Point(4, 29);
            tabprodutos.Name = "tabprodutos";
            tabprodutos.Padding = new Padding(3);
            tabprodutos.Size = new Size(1178, 268);
            tabprodutos.TabIndex = 0;
            tabprodutos.Text = "Produtos";
            tabprodutos.UseVisualStyleBackColor = true;
            tabprodutos.Click += tabprodutos_Click;
            // 
            // txtfornecedor
            // 
            txtfornecedor.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfornecedor.FormattingEnabled = true;
            txtfornecedor.Items.AddRange(new object[] { "Desktops", "Portateis", "Servidores" });
            txtfornecedor.Location = new Point(270, 182);
            txtfornecedor.Name = "txtfornecedor";
            txtfornecedor.Size = new Size(250, 39);
            txtfornecedor.TabIndex = 12;
            // 
            // txtcodigo
            // 
            txtcodigo.Location = new Point(185, 29);
            txtcodigo.Multiline = true;
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(110, 38);
            txtcodigo.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 10;
            label1.Text = "Codigo";
            // 
            // lblfornid
            // 
            lblfornid.AutoSize = true;
            lblfornid.BackColor = Color.DarkGray;
            lblfornid.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfornid.Location = new Point(19, 183);
            lblfornid.Name = "lblfornid";
            lblfornid.Size = new Size(193, 38);
            lblfornid.TabIndex = 9;
            lblfornid.Text = "Fornecedor_id";
            // 
            // txtfamilia
            // 
            txtfamilia.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfamilia.FormattingEnabled = true;
            txtfamilia.Items.AddRange(new object[] { "Desktops", "Portateis", "Servidores" });
            txtfamilia.Location = new Point(751, 104);
            txtfamilia.Name = "txtfamilia";
            txtfamilia.Size = new Size(219, 39);
            txtfamilia.TabIndex = 8;
            // 
            // lblfamilia
            // 
            lblfamilia.AutoSize = true;
            lblfamilia.BackColor = Color.DarkGray;
            lblfamilia.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfamilia.Location = new Point(574, 101);
            lblfamilia.Name = "lblfamilia";
            lblfamilia.Size = new Size(103, 38);
            lblfamilia.TabIndex = 6;
            lblfamilia.Text = "Familia";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 101);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(171, 38);
            textBox1.TabIndex = 5;
            // 
            // lblquantidade
            // 
            lblquantidade.AutoSize = true;
            lblquantidade.BackColor = Color.DarkGray;
            lblquantidade.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblquantidade.Location = new Point(51, 101);
            lblquantidade.Name = "lblquantidade";
            lblquantidade.Size = new Size(161, 38);
            lblquantidade.TabIndex = 4;
            lblquantidade.Text = "Quantidade";
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(976, 29);
            txtpreco.Multiline = true;
            txtpreco.Name = "txtpreco";
            txtpreco.Size = new Size(171, 38);
            txtpreco.TabIndex = 3;
            txtpreco.TextChanged += textBox2_TextChanged;
            // 
            // lblpreco
            // 
            lblpreco.AutoSize = true;
            lblpreco.BackColor = Color.DarkGray;
            lblpreco.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpreco.Location = new Point(857, 29);
            lblpreco.Name = "lblpreco";
            lblpreco.Size = new Size(87, 38);
            lblpreco.TabIndex = 2;
            lblpreco.Text = "Preço";
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(511, 29);
            txtdescricao.Multiline = true;
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(313, 38);
            txtdescricao.TabIndex = 1;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.BackColor = Color.DarkGray;
            lblnome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnome.Location = new Point(348, 29);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(137, 38);
            lblnome.TabIndex = 0;
            lblnome.Text = "Descricao";
            lblnome.Click += lblnome_Click;
            // 
            // tablistprodutos
            // 
            tablistprodutos.Controls.Add(btnpesquisa);
            tablistprodutos.Controls.Add(txtpesquisa);
            tablistprodutos.Controls.Add(dataproduto);
            tablistprodutos.Location = new Point(4, 29);
            tablistprodutos.Name = "tablistprodutos";
            tablistprodutos.Padding = new Padding(3);
            tablistprodutos.Size = new Size(1178, 268);
            tablistprodutos.TabIndex = 1;
            tablistprodutos.Text = "Lista de produtos";
            tablistprodutos.UseVisualStyleBackColor = true;
            // 
            // dataproduto
            // 
            dataproduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataproduto.Location = new Point(6, 99);
            dataproduto.Name = "dataproduto";
            dataproduto.RowHeadersWidth = 51;
            dataproduto.Size = new Size(1166, 163);
            dataproduto.TabIndex = 0;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = SystemColors.ActiveCaption;
            btnnovo.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnovo.Location = new Point(76, 494);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(220, 53);
            btnnovo.TabIndex = 2;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = false;
            // 
            // btngravar
            // 
            btngravar.BackColor = SystemColors.ActiveCaption;
            btngravar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btngravar.Location = new Point(364, 494);
            btngravar.Name = "btngravar";
            btngravar.Size = new Size(220, 53);
            btngravar.TabIndex = 3;
            btngravar.Text = "Gravar";
            btngravar.UseVisualStyleBackColor = false;
            // 
            // btneditar
            // 
            btneditar.BackColor = SystemColors.ActiveCaption;
            btneditar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneditar.Location = new Point(644, 494);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(220, 53);
            btneditar.TabIndex = 4;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            // 
            // btnpagar
            // 
            btnpagar.BackColor = SystemColors.ActiveCaption;
            btnpagar.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpagar.Location = new Point(909, 494);
            btnpagar.Name = "btnpagar";
            btnpagar.Size = new Size(220, 53);
            btnpagar.TabIndex = 5;
            btnpagar.Text = "Apagar";
            btnpagar.UseVisualStyleBackColor = false;
            // 
            // btnpesquisa
            // 
            btnpesquisa.BackColor = Color.DodgerBlue;
            btnpesquisa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpesquisa.ForeColor = SystemColors.ButtonHighlight;
            btnpesquisa.Location = new Point(448, 22);
            btnpesquisa.Name = "btnpesquisa";
            btnpesquisa.Size = new Size(189, 51);
            btnpesquisa.TabIndex = 24;
            btnpesquisa.Text = "Pesquisar";
            btnpesquisa.UseVisualStyleBackColor = false;
            // 
            // txtpesquisa
            // 
            txtpesquisa.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpesquisa.Location = new Point(71, 29);
            txtpesquisa.Name = "txtpesquisa";
            txtpesquisa.Size = new Size(298, 38);
            txtpesquisa.TabIndex = 23;
            // 
            // Produtos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 584);
            Controls.Add(btnpagar);
            Controls.Add(btneditar);
            Controls.Add(btngravar);
            Controls.Add(btnnovo);
            Controls.Add(tabelaprodutos);
            Controls.Add(panel1);
            Name = "Produtos";
            Text = "Produtos";
            Load += Produtos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabelaprodutos.ResumeLayout(false);
            tabprodutos.ResumeLayout(false);
            tabprodutos.PerformLayout();
            tablistprodutos.ResumeLayout(false);
            tablistprodutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataproduto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblprodutos;
        private TabPage tabprodutos;
        private Button btnnovo;
        private Button btngravar;
        private Button btneditar;
        private Button btnpagar;
        private Label lblnome;
        private TextBox txtpreco;
        private Label lblpreco;
        private TextBox txtdescricao;
        private TextBox textBox1;
        private Label lblquantidade;
        private ComboBox txtfamilia;
        private Label lblfamilia;
        private Label lblfornid;
        private DataGridView dataproduto;
        private TextBox txtcodigo;
        private Label label1;
        private ComboBox txtfornecedor;
        public TabControl tabelaprodutos;
        public TabPage tablistprodutos;
        private Button btnpesquisa;
        private TextBox txtpesquisa;
    }
}