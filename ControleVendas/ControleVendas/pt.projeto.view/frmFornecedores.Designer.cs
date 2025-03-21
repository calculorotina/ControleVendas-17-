namespace ControleVendas.pt.projeto.view
{
    partial class frmFornecedores
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
            txttitulo = new Label();
            btnnovo = new Button();
            btnapagar = new Button();
            btneditar = new Button();
            cmdgravar = new Button();
            tabfornecedor1 = new TabControl();
            tabelafornecedor = new TabPage();
            txtestado = new TextBox();
            txtcidade = new TextBox();
            lblcidade = new Label();
            txtbairro = new TextBox();
            lblbairro = new Label();
            txtcomplemento = new TextBox();
            lblcomplemento = new Label();
            txtnumero = new TextBox();
            lblnumero = new Label();
            lblestado = new Label();
            txtemail = new TextBox();
            lblemail = new Label();
            txttelefone = new MaskedTextBox();
            txtcelular = new MaskedTextBox();
            lblcelular = new Label();
            lbltlf = new Label();
            txtcep = new TextBox();
            lblcep = new Label();
            txtcnpj = new MaskedTextBox();
            lblcp = new Label();
            txtmorada = new TextBox();
            lblmorada = new Label();
            txtnome = new TextBox();
            lblnome = new Label();
            txtcodigo = new TextBox();
            lblcodigo = new Label();
            tablistaforn = new TabPage();
            tabelafornecedorgrid = new DataGridView();
            panel1.SuspendLayout();
            tabfornecedor1.SuspendLayout();
            tabelafornecedor.SuspendLayout();
            tablistaforn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelafornecedorgrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(txttitulo);
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1356, 153);
            panel1.TabIndex = 1;
            // 
            // txttitulo
            // 
            txttitulo.AutoSize = true;
            txttitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttitulo.ForeColor = SystemColors.ButtonHighlight;
            txttitulo.Location = new Point(54, 49);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(441, 54);
            txttitulo.TabIndex = 0;
            txttitulo.Text = "Tabela de Fornecedores";
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.DodgerBlue;
            btnnovo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnovo.ForeColor = SystemColors.ButtonHighlight;
            btnnovo.Location = new Point(132, 180);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(189, 66);
            btnnovo.TabIndex = 28;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += btnnovo_Click;
            // 
            // btnapagar
            // 
            btnapagar.BackColor = Color.DodgerBlue;
            btnapagar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnapagar.ForeColor = SystemColors.ButtonHighlight;
            btnapagar.Location = new Point(1023, 180);
            btnapagar.Name = "btnapagar";
            btnapagar.Size = new Size(189, 66);
            btnapagar.TabIndex = 27;
            btnapagar.Text = "Apagar";
            btnapagar.UseVisualStyleBackColor = false;
            btnapagar.Click += btnapagar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.DodgerBlue;
            btneditar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneditar.ForeColor = SystemColors.ButtonHighlight;
            btneditar.Location = new Point(705, 180);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(189, 66);
            btneditar.TabIndex = 26;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // cmdgravar
            // 
            cmdgravar.BackColor = Color.DodgerBlue;
            cmdgravar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdgravar.ForeColor = SystemColors.ButtonHighlight;
            cmdgravar.Location = new Point(420, 180);
            cmdgravar.Name = "cmdgravar";
            cmdgravar.Size = new Size(189, 66);
            cmdgravar.TabIndex = 25;
            cmdgravar.Text = "Gravar";
            cmdgravar.UseVisualStyleBackColor = false;
            cmdgravar.Click += cmdgravar_Click;
            // 
            // tabfornecedor1
            // 
            tabfornecedor1.Controls.Add(tabelafornecedor);
            tabfornecedor1.Controls.Add(tablistaforn);
            tabfornecedor1.Location = new Point(28, 279);
            tabfornecedor1.Name = "tabfornecedor1";
            tabfornecedor1.SelectedIndex = 0;
            tabfornecedor1.Size = new Size(1332, 417);
            tabfornecedor1.TabIndex = 29;
            // 
            // tabelafornecedor
            // 
            tabelafornecedor.Controls.Add(txtestado);
            tabelafornecedor.Controls.Add(txtcidade);
            tabelafornecedor.Controls.Add(lblcidade);
            tabelafornecedor.Controls.Add(txtbairro);
            tabelafornecedor.Controls.Add(lblbairro);
            tabelafornecedor.Controls.Add(txtcomplemento);
            tabelafornecedor.Controls.Add(lblcomplemento);
            tabelafornecedor.Controls.Add(txtnumero);
            tabelafornecedor.Controls.Add(lblnumero);
            tabelafornecedor.Controls.Add(lblestado);
            tabelafornecedor.Controls.Add(txtemail);
            tabelafornecedor.Controls.Add(lblemail);
            tabelafornecedor.Controls.Add(txttelefone);
            tabelafornecedor.Controls.Add(txtcelular);
            tabelafornecedor.Controls.Add(lblcelular);
            tabelafornecedor.Controls.Add(lbltlf);
            tabelafornecedor.Controls.Add(txtcep);
            tabelafornecedor.Controls.Add(lblcep);
            tabelafornecedor.Controls.Add(txtcnpj);
            tabelafornecedor.Controls.Add(lblcp);
            tabelafornecedor.Controls.Add(txtmorada);
            tabelafornecedor.Controls.Add(lblmorada);
            tabelafornecedor.Controls.Add(txtnome);
            tabelafornecedor.Controls.Add(lblnome);
            tabelafornecedor.Controls.Add(txtcodigo);
            tabelafornecedor.Controls.Add(lblcodigo);
            tabelafornecedor.Location = new Point(4, 29);
            tabelafornecedor.Name = "tabelafornecedor";
            tabelafornecedor.Padding = new Padding(3);
            tabelafornecedor.Size = new Size(1324, 384);
            tabelafornecedor.TabIndex = 0;
            tabelafornecedor.Text = "Fornecedores";
            tabelafornecedor.UseVisualStyleBackColor = true;
            tabelafornecedor.Click += tabelafornecedor_Click;
            // 
            // txtestado
            // 
            txtestado.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtestado.Location = new Point(831, 181);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(164, 38);
            txtestado.TabIndex = 49;
            // 
            // txtcidade
            // 
            txtcidade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcidade.Location = new Point(514, 261);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(168, 38);
            txtcidade.TabIndex = 48;
            // 
            // lblcidade
            // 
            lblcidade.AutoSize = true;
            lblcidade.Location = new Point(433, 273);
            lblcidade.Name = "lblcidade";
            lblcidade.Size = new Size(56, 20);
            lblcidade.TabIndex = 47;
            lblcidade.Text = "Cidade";
            // 
            // txtbairro
            // 
            txtbairro.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbairro.Location = new Point(133, 261);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(203, 38);
            txtbairro.TabIndex = 46;
            // 
            // lblbairro
            // 
            lblbairro.AutoSize = true;
            lblbairro.Location = new Point(37, 273);
            lblbairro.Name = "lblbairro";
            lblbairro.Size = new Size(49, 20);
            lblbairro.TabIndex = 45;
            lblbairro.Text = "Bairro";
            // 
            // txtcomplemento
            // 
            txtcomplemento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcomplemento.Location = new Point(1164, 181);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(128, 38);
            txtcomplemento.TabIndex = 44;
            // 
            // lblcomplemento
            // 
            lblcomplemento.AutoSize = true;
            lblcomplemento.Location = new Point(1043, 193);
            lblcomplemento.Name = "lblcomplemento";
            lblcomplemento.Size = new Size(104, 20);
            lblcomplemento.TabIndex = 43;
            lblcomplemento.Text = "Complemento";
            // 
            // txtnumero
            // 
            txtnumero.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnumero.Location = new Point(514, 186);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(164, 38);
            txtnumero.TabIndex = 42;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(433, 198);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(63, 20);
            lblnumero.TabIndex = 41;
            lblnumero.Text = "Numero";
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Location = new Point(723, 193);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(54, 20);
            lblestado.TabIndex = 37;
            lblestado.Text = "Estado";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(133, 186);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(245, 38);
            txtemail.TabIndex = 36;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(37, 193);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 20);
            lblemail.TabIndex = 35;
            lblemail.Text = "Email";
            // 
            // txttelefone
            // 
            txttelefone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttelefone.Location = new Point(776, 97);
            txttelefone.Mask = "##-#######";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(200, 38);
            txttelefone.TabIndex = 34;
            // 
            // txtcelular
            // 
            txtcelular.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcelular.Location = new Point(1154, 97);
            txtcelular.Mask = "#########";
            txtcelular.Name = "txtcelular";
            txtcelular.Size = new Size(138, 38);
            txtcelular.TabIndex = 33;
            // 
            // lblcelular
            // 
            lblcelular.AutoSize = true;
            lblcelular.Location = new Point(1043, 109);
            lblcelular.Name = "lblcelular";
            lblcelular.Size = new Size(55, 20);
            lblcelular.TabIndex = 32;
            lblcelular.Text = "Celular";
            // 
            // lbltlf
            // 
            lbltlf.AutoSize = true;
            lbltlf.Location = new Point(681, 109);
            lbltlf.Name = "lbltlf";
            lbltlf.Size = new Size(66, 20);
            lbltlf.TabIndex = 31;
            lbltlf.Text = "Telefone";
            // 
            // txtcep
            // 
            txtcep.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcep.Location = new Point(424, 97);
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(164, 38);
            txtcep.TabIndex = 30;
            // 
            // lblcep
            // 
            lblcep.AutoSize = true;
            lblcep.Location = new Point(343, 109);
            lblcep.Name = "lblcep";
            lblcep.Size = new Size(35, 20);
            lblcep.TabIndex = 29;
            lblcep.Text = "Cep";
            // 
            // txtcnpj
            // 
            txtcnpj.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcnpj.Location = new Point(133, 97);
            txtcnpj.Mask = "####-###";
            txtcnpj.Name = "txtcnpj";
            txtcnpj.Size = new Size(125, 38);
            txtcnpj.TabIndex = 28;
            // 
            // lblcp
            // 
            lblcp.AutoSize = true;
            lblcp.Location = new Point(46, 109);
            lblcp.Name = "lblcp";
            lblcp.Size = new Size(37, 20);
            lblcp.TabIndex = 27;
            lblcp.Text = "cnpj";
            // 
            // txtmorada
            // 
            txtmorada.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmorada.Location = new Point(944, 36);
            txtmorada.Name = "txtmorada";
            txtmorada.Size = new Size(347, 38);
            txtmorada.TabIndex = 26;
            // 
            // lblmorada
            // 
            lblmorada.AutoSize = true;
            lblmorada.Location = new Point(848, 43);
            lblmorada.Name = "lblmorada";
            lblmorada.Size = new Size(61, 20);
            lblmorada.TabIndex = 25;
            lblmorada.Text = "Morada";
            // 
            // txtnome
            // 
            txtnome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnome.Location = new Point(424, 36);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(365, 38);
            txtnome.TabIndex = 24;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(328, 43);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(50, 20);
            lblnome.TabIndex = 23;
            lblnome.Text = "Nome";
            // 
            // txtcodigo
            // 
            txtcodigo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcodigo.Location = new Point(133, 36);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(125, 38);
            txtcodigo.TabIndex = 22;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(37, 43);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(58, 20);
            lblcodigo.TabIndex = 21;
            lblcodigo.Text = "Codigo";
            // 
            // tablistaforn
            // 
            tablistaforn.Controls.Add(tabelafornecedorgrid);
            tablistaforn.Location = new Point(4, 29);
            tablistaforn.Name = "tablistaforn";
            tablistaforn.Padding = new Padding(3);
            tablistaforn.Size = new Size(1324, 384);
            tablistaforn.TabIndex = 1;
            tablistaforn.Text = "Lista de Fornecedores";
            tablistaforn.UseVisualStyleBackColor = true;
            // 
            // tabelafornecedorgrid
            // 
            tabelafornecedorgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelafornecedorgrid.Location = new Point(6, 6);
            tabelafornecedorgrid.Name = "tabelafornecedorgrid";
            tabelafornecedorgrid.RowHeadersWidth = 51;
            tabelafornecedorgrid.Size = new Size(1298, 372);
            tabelafornecedorgrid.TabIndex = 0;
            tabelafornecedorgrid.CellClick += tabelafornecedorgrid_CellClick;
            // 
            // frmFornecedores
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1362, 722);
            Controls.Add(tabfornecedor1);
            Controls.Add(btnnovo);
            Controls.Add(btnapagar);
            Controls.Add(btneditar);
            Controls.Add(cmdgravar);
            Controls.Add(panel1);
            Name = "frmFornecedores";
            Text = "frmFornecedores";
            Load += frmFornecedores_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabfornecedor1.ResumeLayout(false);
            tabelafornecedor.ResumeLayout(false);
            tabelafornecedor.PerformLayout();
            tablistaforn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabelafornecedorgrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txttitulo;
        private Button btnnovo;
        private Button btnapagar;
        private Button btneditar;
        private Button cmdgravar;
        private Label lblestado;
        private TextBox txtemail;
        private Label lblemail;
        private MaskedTextBox txttelefone;
        private MaskedTextBox txtcelular;
        private Label lblcelular;
        private Label lbltlf;
        private TextBox txtcep;
        private Label lblcep;
        private MaskedTextBox txtcnpj;
        private Label lblcp;
        private TextBox txtmorada;
        private Label lblmorada;
        private TextBox txtnome;
        private Label lblnome;
        private TextBox txtcodigo;
        private Label lblcodigo;
        private TextBox txtcidade;
        private Label lblcidade;
        private TextBox txtbairro;
        private Label lblbairro;
        private TextBox txtcomplemento;
        private Label lblcomplemento;
        private TextBox txtnumero;
        private Label lblnumero;
        private TextBox txtestado;
        public TabControl tabfornecedor1;
        public TabPage tabelafornecedor;
        public DataGridView tabelafornecedorgrid;
        public TabPage tablistaforn;
    }
}