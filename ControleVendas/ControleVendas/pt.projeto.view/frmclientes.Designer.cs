namespace ControleVendas.pt.projeto.view
{
    partial class frmclientes
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
            lista = new TabControl();
            FichaCliente = new TabPage();
            txtmodopag = new ComboBox();
            lblmodop = new Label();
            txtcpag = new ComboBox();
            label1 = new Label();
            txtemail = new TextBox();
            lblemail = new Label();
            txttelefone = new MaskedTextBox();
            txttelemovel = new MaskedTextBox();
            lbltlm = new Label();
            lbltlf = new Label();
            txtlocalidade = new TextBox();
            lbllocalidade = new Label();
            txtcp = new MaskedTextBox();
            lblcp = new Label();
            txtmorada = new TextBox();
            lblmorada = new Label();
            txtnome = new TextBox();
            lblnome = new Label();
            txtcodigo = new TextBox();
            lblcodigo = new Label();
            ListaClientes = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            tabelacliente = new DataGridView();
            btnapagar = new Button();
            btneditar = new Button();
            cmdgravar = new Button();
            btnnovo = new Button();
            panel1.SuspendLayout();
            lista.SuspendLayout();
            FichaCliente.SuspendLayout();
            ListaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelacliente).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(txttitulo);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1403, 166);
            panel1.TabIndex = 0;
            // 
            // txttitulo
            // 
            txttitulo.AutoSize = true;
            txttitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttitulo.ForeColor = SystemColors.ButtonHighlight;
            txttitulo.Location = new Point(55, 55);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(343, 54);
            txttitulo.TabIndex = 0;
            txttitulo.Text = "Tabela de Clientes";
            // 
            // lista
            // 
            lista.Controls.Add(FichaCliente);
            lista.Controls.Add(ListaClientes);
            lista.Location = new Point(12, 296);
            lista.Name = "lista";
            lista.SelectedIndex = 0;
            lista.Size = new Size(1403, 426);
            lista.TabIndex = 1;
            // 
            // FichaCliente
            // 
            FichaCliente.Controls.Add(txtmodopag);
            FichaCliente.Controls.Add(lblmodop);
            FichaCliente.Controls.Add(txtcpag);
            FichaCliente.Controls.Add(label1);
            FichaCliente.Controls.Add(txtemail);
            FichaCliente.Controls.Add(lblemail);
            FichaCliente.Controls.Add(txttelefone);
            FichaCliente.Controls.Add(txttelemovel);
            FichaCliente.Controls.Add(lbltlm);
            FichaCliente.Controls.Add(lbltlf);
            FichaCliente.Controls.Add(txtlocalidade);
            FichaCliente.Controls.Add(lbllocalidade);
            FichaCliente.Controls.Add(txtcp);
            FichaCliente.Controls.Add(lblcp);
            FichaCliente.Controls.Add(txtmorada);
            FichaCliente.Controls.Add(lblmorada);
            FichaCliente.Controls.Add(txtnome);
            FichaCliente.Controls.Add(lblnome);
            FichaCliente.Controls.Add(txtcodigo);
            FichaCliente.Controls.Add(lblcodigo);
            FichaCliente.Location = new Point(4, 29);
            FichaCliente.Name = "FichaCliente";
            FichaCliente.Padding = new Padding(3);
            FichaCliente.Size = new Size(1395, 393);
            FichaCliente.TabIndex = 0;
            FichaCliente.Text = "Clientes";
            FichaCliente.UseVisualStyleBackColor = true;
            FichaCliente.Click += FichaCliente_Click;
            FichaCliente.MouseClick += FichaCliente_MouseClick;
            // 
            // txtmodopag
            // 
            txtmodopag.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmodopag.FormattingEnabled = true;
            txtmodopag.Items.AddRange(new object[] { "Cheque", "Dinheiro", "Multibanco", "Transferencia Bancaria" });
            txtmodopag.Location = new Point(1122, 176);
            txtmodopag.Name = "txtmodopag";
            txtmodopag.Size = new Size(244, 39);
            txtmodopag.TabIndex = 20;
            // 
            // lblmodop
            // 
            lblmodop.AutoSize = true;
            lblmodop.Location = new Point(957, 184);
            lblmodop.Name = "lblmodop";
            lblmodop.Size = new Size(151, 20);
            lblmodop.TabIndex = 19;
            lblmodop.Text = "Modo de pagamento";
            // 
            // txtcpag
            // 
            txtcpag.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcpag.FormattingEnabled = true;
            txtcpag.Items.AddRange(new object[] { "Pronto Pagamento", "Pagamento a 15 Dias", "Pagamento a 30 Dias", "Pagamento a 60 Dias" });
            txtcpag.Location = new Point(649, 177);
            txtcpag.Name = "txtcpag";
            txtcpag.Size = new Size(267, 39);
            txtcpag.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 184);
            label1.Name = "label1";
            label1.Size = new Size(174, 20);
            label1.TabIndex = 17;
            label1.Text = "Condiçao de pagamento";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(131, 177);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(245, 38);
            txtemail.TabIndex = 16;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Location = new Point(35, 184);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(46, 20);
            lblemail.TabIndex = 15;
            lblemail.Text = "Email";
            // 
            // txttelefone
            // 
            txttelefone.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttelefone.Location = new Point(729, 88);
            txttelefone.Mask = "##-#########";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(200, 38);
            txttelefone.TabIndex = 14;
            // 
            // txttelemovel
            // 
            txttelemovel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttelemovel.Location = new Point(1107, 88);
            txttelemovel.Mask = "###########";
            txttelemovel.Name = "txttelemovel";
            txttelemovel.Size = new Size(138, 38);
            txttelemovel.TabIndex = 13;
            // 
            // lbltlm
            // 
            lbltlm.AutoSize = true;
            lbltlm.Location = new Point(996, 100);
            lbltlm.Name = "lbltlm";
            lbltlm.Size = new Size(77, 20);
            lbltlm.TabIndex = 12;
            lbltlm.Text = "Telemovel";
            // 
            // lbltlf
            // 
            lbltlf.AutoSize = true;
            lbltlf.Location = new Point(634, 100);
            lbltlf.Name = "lbltlf";
            lbltlf.Size = new Size(66, 20);
            lbltlf.TabIndex = 10;
            lbltlf.Text = "Telefone";
            // 
            // txtlocalidade
            // 
            txtlocalidade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlocalidade.Location = new Point(422, 88);
            txtlocalidade.Name = "txtlocalidade";
            txtlocalidade.Size = new Size(164, 38);
            txtlocalidade.TabIndex = 9;
            // 
            // lbllocalidade
            // 
            lbllocalidade.AutoSize = true;
            lbllocalidade.Location = new Point(294, 100);
            lbllocalidade.Name = "lbllocalidade";
            lbllocalidade.Size = new Size(82, 20);
            lbllocalidade.TabIndex = 8;
            lbllocalidade.Text = "Localidade";
            // 
            // txtcp
            // 
            txtcp.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcp.Location = new Point(131, 88);
            txtcp.Mask = "####-###";
            txtcp.Name = "txtcp";
            txtcp.Size = new Size(125, 38);
            txtcp.TabIndex = 7;
            // 
            // lblcp
            // 
            lblcp.AutoSize = true;
            lblcp.Location = new Point(6, 95);
            lblcp.Name = "lblcp";
            lblcp.Size = new Size(101, 20);
            lblcp.TabIndex = 6;
            lblcp.Text = "Codigo Postal";
            // 
            // txtmorada
            // 
            txtmorada.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmorada.Location = new Point(942, 27);
            txtmorada.Name = "txtmorada";
            txtmorada.Size = new Size(411, 38);
            txtmorada.TabIndex = 5;
            // 
            // lblmorada
            // 
            lblmorada.AutoSize = true;
            lblmorada.Location = new Point(846, 34);
            lblmorada.Name = "lblmorada";
            lblmorada.Size = new Size(61, 20);
            lblmorada.TabIndex = 4;
            lblmorada.Text = "Morada";
            // 
            // txtnome
            // 
            txtnome.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnome.Location = new Point(422, 27);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(391, 38);
            txtnome.TabIndex = 3;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(326, 34);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(50, 20);
            lblnome.TabIndex = 2;
            lblnome.Text = "Nome";
            // 
            // txtcodigo
            // 
            txtcodigo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcodigo.Location = new Point(131, 27);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(125, 38);
            txtcodigo.TabIndex = 1;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Location = new Point(35, 34);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(58, 20);
            lblcodigo.TabIndex = 0;
            lblcodigo.Text = "Codigo";
            // 
            // ListaClientes
            // 
            ListaClientes.Controls.Add(button1);
            ListaClientes.Controls.Add(textBox1);
            ListaClientes.Controls.Add(tabelacliente);
            ListaClientes.Location = new Point(4, 29);
            ListaClientes.Name = "ListaClientes";
            ListaClientes.Padding = new Padding(3);
            ListaClientes.Size = new Size(1395, 393);
            ListaClientes.TabIndex = 1;
            ListaClientes.Text = "Lista de Clientes";
            ListaClientes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(473, 22);
            button1.Name = "button1";
            button1.Size = new Size(189, 51);
            button1.TabIndex = 22;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(96, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 38);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // tabelacliente
            // 
            tabelacliente.AllowUserToAddRows = false;
            tabelacliente.AllowUserToDeleteRows = false;
            tabelacliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelacliente.Location = new Point(6, 102);
            tabelacliente.Name = "tabelacliente";
            tabelacliente.ReadOnly = true;
            tabelacliente.RowHeadersWidth = 51;
            tabelacliente.Size = new Size(1383, 391);
            tabelacliente.TabIndex = 0;
            tabelacliente.CellClick += tabelacliente_CellClick;
            tabelacliente.CellContentClick += tabelacliente_CellContentClick;
            // 
            // btnapagar
            // 
            btnapagar.BackColor = Color.DodgerBlue;
            btnapagar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnapagar.ForeColor = SystemColors.ButtonHighlight;
            btnapagar.Location = new Point(1063, 206);
            btnapagar.Name = "btnapagar";
            btnapagar.Size = new Size(189, 66);
            btnapagar.TabIndex = 23;
            btnapagar.Text = "Apagar";
            btnapagar.UseVisualStyleBackColor = false;
            btnapagar.Click += btnapagar_Click;
            // 
            // btneditar
            // 
            btneditar.BackColor = Color.DodgerBlue;
            btneditar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btneditar.ForeColor = SystemColors.ButtonHighlight;
            btneditar.Location = new Point(745, 206);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(189, 66);
            btneditar.TabIndex = 22;
            btneditar.Text = "Editar";
            btneditar.UseVisualStyleBackColor = false;
            btneditar.Click += btneditar_Click;
            // 
            // cmdgravar
            // 
            cmdgravar.BackColor = Color.DodgerBlue;
            cmdgravar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdgravar.ForeColor = SystemColors.ButtonHighlight;
            cmdgravar.Location = new Point(460, 206);
            cmdgravar.Name = "cmdgravar";
            cmdgravar.Size = new Size(189, 66);
            cmdgravar.TabIndex = 21;
            cmdgravar.Text = "Gravar";
            cmdgravar.UseVisualStyleBackColor = false;
            cmdgravar.Click += cmdgravar_Click;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.DodgerBlue;
            btnnovo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnovo.ForeColor = SystemColors.ButtonHighlight;
            btnnovo.Location = new Point(172, 206);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(189, 66);
            btnnovo.TabIndex = 24;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = false;
            btnnovo.Click += btnnovo_Click;
            // 
            // frmclientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 729);
            Controls.Add(btnnovo);
            Controls.Add(btnapagar);
            Controls.Add(lista);
            Controls.Add(btneditar);
            Controls.Add(panel1);
            Controls.Add(cmdgravar);
            Name = "frmclientes";
            Text = "frmclientes";
            Load += frmclientes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            lista.ResumeLayout(false);
            FichaCliente.ResumeLayout(false);
            FichaCliente.PerformLayout();
            ListaClientes.ResumeLayout(false);
            ListaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabelacliente).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label txttitulo;
        private MaskedTextBox txtcp;
        private Label lblcp;
        private TextBox txtmorada;
        private Label lblmorada;
        private TextBox txtnome;
        private Label lblnome;
        private TextBox txtcodigo;
        private Label lblcodigo;
        private TextBox txtlocalidade;
        private Label lbllocalidade;
        private Label lbltlf;
        private MaskedTextBox txttelefone;
        private MaskedTextBox txttelemovel;
        private Label lbltlm;
        private ComboBox txtmodopag;
        private Label lblmodop;
        private ComboBox txtcpag;
        private Label label1;
        private TextBox txtemail;
        private Label lblemail;
        private Button btnapagar;
        private Button btneditar;
        private Button cmdgravar;
        private DataGridView tabelacliente;
        private Button button1;
        private TextBox textBox1;
        private Button btnnovo;
        public TabPage ListaClientes;
        public TabPage FichaCliente;
        public TabControl lista;
    }
}