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
            tabControl1 = new TabControl();
            tabprodutos = new TabPage();
            tablistprodutos = new TabPage();
            btnnovo = new Button();
            btngravar = new Button();
            btneditar = new Button();
            btnpagar = new Button();
            lblnome = new Label();
            txtdescricao = new TextBox();
            txtpreco = new TextBox();
            lblpreco = new Label();
            textBox1 = new TextBox();
            lblquantidade = new Label();
            textBox2 = new TextBox();
            lblfamilia = new Label();
            txtfamilia = new ComboBox();
            lblfornid = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabprodutos.SuspendLayout();
            tablistprodutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabprodutos);
            tabControl1.Controls.Add(tablistprodutos);
            tabControl1.Location = new Point(12, 163);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1186, 301);
            tabControl1.TabIndex = 1;
            // 
            // tabprodutos
            // 
            tabprodutos.Controls.Add(lblfornid);
            tabprodutos.Controls.Add(txtfamilia);
            tabprodutos.Controls.Add(textBox2);
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
            // 
            // tablistprodutos
            // 
            tablistprodutos.Controls.Add(dataGridView1);
            tablistprodutos.Location = new Point(4, 29);
            tablistprodutos.Name = "tablistprodutos";
            tablistprodutos.Padding = new Padding(3);
            tablistprodutos.Size = new Size(1178, 268);
            tablistprodutos.TabIndex = 1;
            tablistprodutos.Text = "Lista de produtos";
            tablistprodutos.UseVisualStyleBackColor = true;
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
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.BackColor = Color.DarkGray;
            lblnome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblnome.Location = new Point(75, 30);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(137, 38);
            lblnome.TabIndex = 0;
            lblnome.Text = "Descricao";
            // 
            // txtdescricao
            // 
            txtdescricao.Location = new Point(278, 30);
            txtdescricao.Multiline = true;
            txtdescricao.Name = "txtdescricao";
            txtdescricao.Size = new Size(400, 38);
            txtdescricao.TabIndex = 1;
            // 
            // txtpreco
            // 
            txtpreco.Location = new Point(925, 30);
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
            lblpreco.Location = new Point(789, 30);
            lblpreco.Name = "lblpreco";
            lblpreco.Size = new Size(87, 38);
            lblpreco.TabIndex = 2;
            lblpreco.Text = "Preço";
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
            // textBox2
            // 
            textBox2.Location = new Point(270, 183);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 38);
            textBox2.TabIndex = 7;
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
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1166, 256);
            dataGridView1.TabIndex = 0;
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
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "Produtos";
            Text = "Produtos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabprodutos.ResumeLayout(false);
            tabprodutos.PerformLayout();
            tablistprodutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblprodutos;
        private TabControl tabControl1;
        private TabPage tabprodutos;
        private TabPage tablistprodutos;
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
        private TextBox textBox2;
        private Label lblfamilia;
        private Label lblfornid;
        private DataGridView dataGridView1;
    }
}