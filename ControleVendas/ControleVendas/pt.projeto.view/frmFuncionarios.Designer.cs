namespace ControleVendas.pt.projeto.view
{
    partial class frmFuncionarios
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
            panelFunc = new Panel();
            lblfunc = new Label();
            listafunc = new TabControl();
            tabfunc = new TabPage();
            txtestado = new TextBox();
            lblestado = new Label();
            txtcidade = new TextBox();
            lblcidade = new Label();
            txtbairro = new TextBox();
            txtcomplemento = new TextBox();
            txtnumero = new TextBox();
            lblnumero = new Label();
            txtmorfunc = new TextBox();
            lblmor = new Label();
            txtcep = new TextBox();
            lblcep = new Label();
            txtacesso = new ComboBox();
            txtsenha = new TextBox();
            txtemailfunc = new TextBox();
            lblemail2 = new Label();
            txtcpf = new TextBox();
            lblcpf = new Label();
            lblbairro = new Label();
            lblcomplemento = new Label();
            txttlmfunc = new TextBox();
            lbltelfunc = new Label();
            txttelfunc = new MaskedTextBox();
            lbltlmfunc = new Label();
            lblnivel = new Label();
            txtcargo = new TextBox();
            lblcargo = new Label();
            lblsenha = new Label();
            txtrg = new TextBox();
            lblrg = new Label();
            txtnomefunc = new TextBox();
            lblnomefunc = new Label();
            tablistfunc = new TabPage();
            tabelafunc = new DataGridView();
            btnnovo = new Button();
            btnapagar = new Button();
            btneditar = new Button();
            cmdgravar = new Button();
            panelFunc.SuspendLayout();
            listafunc.SuspendLayout();
            tabfunc.SuspendLayout();
            tablistfunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabelafunc).BeginInit();
            SuspendLayout();
            // 
            // panelFunc
            // 
            panelFunc.BackColor = SystemColors.Highlight;
            panelFunc.Controls.Add(lblfunc);
            panelFunc.Location = new Point(12, 10);
            panelFunc.Name = "panelFunc";
            panelFunc.Size = new Size(1751, 127);
            panelFunc.TabIndex = 0;
            // 
            // lblfunc
            // 
            lblfunc.AutoSize = true;
            lblfunc.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfunc.ForeColor = SystemColors.ButtonHighlight;
            lblfunc.Location = new Point(35, 31);
            lblfunc.Name = "lblfunc";
            lblfunc.Size = new Size(271, 60);
            lblfunc.TabIndex = 0;
            lblfunc.Text = "Funcionarios";
            // 
            // listafunc
            // 
            listafunc.Controls.Add(tabfunc);
            listafunc.Controls.Add(tablistfunc);
            listafunc.Location = new Point(12, 148);
            listafunc.Name = "listafunc";
            listafunc.SelectedIndex = 0;
            listafunc.Size = new Size(1752, 441);
            listafunc.TabIndex = 1;
            // 
            // tabfunc
            // 
            tabfunc.Controls.Add(txtestado);
            tabfunc.Controls.Add(lblestado);
            tabfunc.Controls.Add(txtcidade);
            tabfunc.Controls.Add(lblcidade);
            tabfunc.Controls.Add(txtbairro);
            tabfunc.Controls.Add(txtcomplemento);
            tabfunc.Controls.Add(txtnumero);
            tabfunc.Controls.Add(lblnumero);
            tabfunc.Controls.Add(txtmorfunc);
            tabfunc.Controls.Add(lblmor);
            tabfunc.Controls.Add(txtcep);
            tabfunc.Controls.Add(lblcep);
            tabfunc.Controls.Add(txtacesso);
            tabfunc.Controls.Add(txtsenha);
            tabfunc.Controls.Add(txtemailfunc);
            tabfunc.Controls.Add(lblemail2);
            tabfunc.Controls.Add(txtcpf);
            tabfunc.Controls.Add(lblcpf);
            tabfunc.Controls.Add(lblbairro);
            tabfunc.Controls.Add(lblcomplemento);
            tabfunc.Controls.Add(txttlmfunc);
            tabfunc.Controls.Add(lbltelfunc);
            tabfunc.Controls.Add(txttelfunc);
            tabfunc.Controls.Add(lbltlmfunc);
            tabfunc.Controls.Add(lblnivel);
            tabfunc.Controls.Add(txtcargo);
            tabfunc.Controls.Add(lblcargo);
            tabfunc.Controls.Add(lblsenha);
            tabfunc.Controls.Add(txtrg);
            tabfunc.Controls.Add(lblrg);
            tabfunc.Controls.Add(txtnomefunc);
            tabfunc.Controls.Add(lblnomefunc);
            tabfunc.Location = new Point(4, 29);
            tabfunc.Name = "tabfunc";
            tabfunc.Padding = new Padding(3);
            tabfunc.Size = new Size(1744, 408);
            tabfunc.TabIndex = 0;
            tabfunc.Text = "Funcionarios";
            tabfunc.UseVisualStyleBackColor = true;
            tabfunc.Click += tabfunc_Click;
            // 
            // txtestado
            // 
            txtestado.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtestado.Location = new Point(1303, 306);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(268, 38);
            txtestado.TabIndex = 56;
            // 
            // lblestado
            // 
            lblestado.AutoSize = true;
            lblestado.Location = new Point(1214, 313);
            lblestado.Name = "lblestado";
            lblestado.Size = new Size(54, 20);
            lblestado.TabIndex = 55;
            lblestado.Text = "Estado";
            // 
            // txtcidade
            // 
            txtcidade.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcidade.Location = new Point(961, 306);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(194, 38);
            txtcidade.TabIndex = 54;
            // 
            // lblcidade
            // 
            lblcidade.AutoSize = true;
            lblcidade.Location = new Point(851, 313);
            lblcidade.Name = "lblcidade";
            lblcidade.Size = new Size(56, 20);
            lblcidade.TabIndex = 53;
            lblcidade.Text = "Cidade";
            // 
            // txtbairro
            // 
            txtbairro.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtbairro.Location = new Point(575, 306);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(194, 38);
            txtbairro.TabIndex = 52;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcomplemento.Location = new Point(230, 306);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(190, 38);
            txtcomplemento.TabIndex = 51;
            // 
            // txtnumero
            // 
            txtnumero.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnumero.Location = new Point(1586, 210);
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(131, 38);
            txtnumero.TabIndex = 50;
            // 
            // lblnumero
            // 
            lblnumero.AutoSize = true;
            lblnumero.Location = new Point(1486, 222);
            lblnumero.Name = "lblnumero";
            lblnumero.Size = new Size(63, 20);
            lblnumero.TabIndex = 49;
            lblnumero.Text = "Numero";
            // 
            // txtmorfunc
            // 
            txtmorfunc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtmorfunc.Location = new Point(1058, 210);
            txtmorfunc.Name = "txtmorfunc";
            txtmorfunc.Size = new Size(364, 38);
            txtmorfunc.TabIndex = 48;
            // 
            // lblmor
            // 
            lblmor.AutoSize = true;
            lblmor.Location = new Point(938, 222);
            lblmor.Name = "lblmor";
            lblmor.Size = new Size(61, 20);
            lblmor.TabIndex = 47;
            lblmor.Text = "Morada";
            // 
            // txtcep
            // 
            txtcep.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcep.Location = new Point(662, 210);
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(197, 38);
            txtcep.TabIndex = 46;
            // 
            // lblcep
            // 
            lblcep.AutoSize = true;
            lblcep.Location = new Point(544, 222);
            lblcep.Name = "lblcep";
            lblcep.Size = new Size(35, 20);
            lblcep.TabIndex = 45;
            lblcep.Text = "Cep";
            // 
            // txtacesso
            // 
            txtacesso.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtacesso.FormattingEnabled = true;
            txtacesso.Items.AddRange(new object[] { "Administrador", "Gerente", "Empregado" });
            txtacesso.Location = new Point(1003, 126);
            txtacesso.Name = "txtacesso";
            txtacesso.Size = new Size(244, 39);
            txtacesso.TabIndex = 44;
            // 
            // txtsenha
            // 
            txtsenha.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtsenha.Location = new Point(172, 126);
            txtsenha.Name = "txtsenha";
            txtsenha.Size = new Size(164, 38);
            txtsenha.TabIndex = 43;
            // 
            // txtemailfunc
            // 
            txtemailfunc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemailfunc.Location = new Point(1448, 38);
            txtemailfunc.Name = "txtemailfunc";
            txtemailfunc.Size = new Size(269, 38);
            txtemailfunc.TabIndex = 42;
            // 
            // lblemail2
            // 
            lblemail2.AutoSize = true;
            lblemail2.Location = new Point(1353, 50);
            lblemail2.Name = "lblemail2";
            lblemail2.Size = new Size(46, 20);
            lblemail2.TabIndex = 41;
            lblemail2.Text = "Email";
            // 
            // txtcpf
            // 
            txtcpf.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcpf.Location = new Point(1124, 38);
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(152, 38);
            txtcpf.TabIndex = 40;
            // 
            // lblcpf
            // 
            lblcpf.AutoSize = true;
            lblcpf.Location = new Point(1029, 50);
            lblcpf.Name = "lblcpf";
            lblcpf.Size = new Size(32, 20);
            lblcpf.TabIndex = 39;
            lblcpf.Text = "Cpf";
            // 
            // lblbairro
            // 
            lblbairro.AutoSize = true;
            lblbairro.Location = new Point(486, 313);
            lblbairro.Name = "lblbairro";
            lblbairro.Size = new Size(49, 20);
            lblbairro.TabIndex = 37;
            lblbairro.Text = "Bairro";
            // 
            // lblcomplemento
            // 
            lblcomplemento.AutoSize = true;
            lblcomplemento.Location = new Point(83, 313);
            lblcomplemento.Name = "lblcomplemento";
            lblcomplemento.Size = new Size(104, 20);
            lblcomplemento.TabIndex = 35;
            lblcomplemento.Text = "Complemento";
            // 
            // txttlmfunc
            // 
            txttlmfunc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttlmfunc.Location = new Point(204, 215);
            txttlmfunc.Name = "txttlmfunc";
            txttlmfunc.Size = new Size(245, 38);
            txttlmfunc.TabIndex = 34;
            // 
            // lbltelfunc
            // 
            lbltelfunc.AutoSize = true;
            lbltelfunc.Location = new Point(83, 222);
            lbltelfunc.Name = "lbltelfunc";
            lbltelfunc.Size = new Size(77, 20);
            lbltelfunc.TabIndex = 33;
            lbltelfunc.Text = "Telemovel";
            // 
            // txttelfunc
            // 
            txttelfunc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttelfunc.Location = new Point(1467, 120);
            txttelfunc.Mask = "###########";
            txttelfunc.Name = "txttelfunc";
            txttelfunc.Size = new Size(122, 38);
            txttelfunc.TabIndex = 31;
            // 
            // lbltlmfunc
            // 
            lbltlmfunc.AutoSize = true;
            lbltlmfunc.Location = new Point(1356, 132);
            lbltlmfunc.Name = "lbltlmfunc";
            lbltlmfunc.Size = new Size(66, 20);
            lbltlmfunc.TabIndex = 30;
            lbltlmfunc.Text = "Telefone";
            // 
            // lblnivel
            // 
            lblnivel.AutoSize = true;
            lblnivel.Location = new Point(830, 138);
            lblnivel.Name = "lblnivel";
            lblnivel.Size = new Size(114, 20);
            lblnivel.TabIndex = 29;
            lblnivel.Text = "Nivel de Acesso";
            // 
            // txtcargo
            // 
            txtcargo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcargo.Location = new Point(554, 126);
            txtcargo.Name = "txtcargo";
            txtcargo.Size = new Size(197, 38);
            txtcargo.TabIndex = 28;
            // 
            // lblcargo
            // 
            lblcargo.AutoSize = true;
            lblcargo.Location = new Point(436, 138);
            lblcargo.Name = "lblcargo";
            lblcargo.Size = new Size(49, 20);
            lblcargo.TabIndex = 27;
            lblcargo.Text = "Cargo";
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Location = new Point(79, 133);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(49, 20);
            lblsenha.TabIndex = 25;
            lblsenha.Text = "Senha";
            // 
            // txtrg
            // 
            txtrg.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtrg.Location = new Point(802, 38);
            txtrg.Name = "txtrg";
            txtrg.Size = new Size(152, 38);
            txtrg.TabIndex = 24;
            // 
            // lblrg
            // 
            lblrg.AutoSize = true;
            lblrg.Location = new Point(707, 50);
            lblrg.Name = "lblrg";
            lblrg.Size = new Size(27, 20);
            lblrg.TabIndex = 23;
            lblrg.Text = "Rg";
            // 
            // txtnomefunc
            // 
            txtnomefunc.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtnomefunc.Location = new Point(252, 38);
            txtnomefunc.Name = "txtnomefunc";
            txtnomefunc.Size = new Size(391, 38);
            txtnomefunc.TabIndex = 22;
            // 
            // lblnomefunc
            // 
            lblnomefunc.AutoSize = true;
            lblnomefunc.Location = new Point(79, 50);
            lblnomefunc.Name = "lblnomefunc";
            lblnomefunc.Size = new Size(50, 20);
            lblnomefunc.TabIndex = 21;
            lblnomefunc.Text = "Nome";
            // 
            // tablistfunc
            // 
            tablistfunc.Controls.Add(tabelafunc);
            tablistfunc.Location = new Point(4, 29);
            tablistfunc.Name = "tablistfunc";
            tablistfunc.Padding = new Padding(3);
            tablistfunc.Size = new Size(1744, 408);
            tablistfunc.TabIndex = 1;
            tablistfunc.Text = "Lista Funcionarios";
            tablistfunc.UseVisualStyleBackColor = true;
            // 
            // tabelafunc
            // 
            tabelafunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelafunc.Location = new Point(6, 6);
            tabelafunc.Name = "tabelafunc";
            tabelafunc.RowHeadersWidth = 51;
            tabelafunc.Size = new Size(1732, 398);
            tabelafunc.TabIndex = 0;
            tabelafunc.CellClick += tabelafunc_CellClick;
            tabelafunc.CellContentClick += tabelafunc_CellContentClick;
            // 
            // btnnovo
            // 
            btnnovo.BackColor = Color.DodgerBlue;
            btnnovo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnnovo.ForeColor = SystemColors.ButtonHighlight;
            btnnovo.Location = new Point(330, 616);
            btnnovo.Name = "btnnovo";
            btnnovo.Size = new Size(189, 66);
            btnnovo.TabIndex = 28;
            btnnovo.Text = "Novo";
            btnnovo.UseVisualStyleBackColor = false;
            // 
            // btnapagar
            // 
            btnapagar.BackColor = Color.DodgerBlue;
            btnapagar.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnapagar.ForeColor = SystemColors.ButtonHighlight;
            btnapagar.Location = new Point(1221, 616);
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
            btneditar.Location = new Point(903, 616);
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
            cmdgravar.Location = new Point(618, 616);
            cmdgravar.Name = "cmdgravar";
            cmdgravar.Size = new Size(189, 66);
            cmdgravar.TabIndex = 25;
            cmdgravar.Text = "Gravar";
            cmdgravar.UseVisualStyleBackColor = false;
            cmdgravar.Click += cmdgravar_Click;
            // 
            // frmFuncionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1772, 724);
            Controls.Add(btnnovo);
            Controls.Add(btnapagar);
            Controls.Add(btneditar);
            Controls.Add(cmdgravar);
            Controls.Add(listafunc);
            Controls.Add(panelFunc);
            Name = "frmFuncionarios";
            Text = "Funcionarios";
            Load += frmFuncionarios_Load;
            panelFunc.ResumeLayout(false);
            panelFunc.PerformLayout();
            listafunc.ResumeLayout(false);
            tabfunc.ResumeLayout(false);
            tabfunc.PerformLayout();
            tablistfunc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tabelafunc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFunc;
        private Label lblfunc;
        private ComboBox txtmodopag;
        private Label lblbairro;
        private ComboBox txtcpag;
        private Label lblcomplemento;
        private TextBox txttlmfunc;
        private Label lbltelfunc;
        private MaskedTextBox txttelefone;
        private MaskedTextBox txttelfunc;
        private Label lbltlmfunc;
        private Label lblnivel;
        private TextBox txtcargo;
        private Label lblcargo;
        private Label lblsenha;
        private Label lblrg;
        private Label lblnomefunc;
        private TextBox txtcpf;
        private Label lblcpf;
        private TextBox txtemailfunc;
        private Label lblemail2;
        private TextBox txtsenha;
        private ComboBox txtacesso;
        private TextBox txtnumero;
        private Label lblnumero;
        private TextBox txtmorfunc;
        private Label lblmor;
        private TextBox txtcep;
        private Label lblcep;
        private Button btnnovo;
        private Button btnapagar;
        private Button btneditar;
        private Button cmdgravar;
        private TextBox txtbairro;
        private TextBox txtcomplemento;
        private TextBox txtestado;
        private Label lblestado;
        private TextBox txtcidade;
        private Label lblcidade;
        public TabControl listafunc;
        public TabPage tabfunc;
        public DataGridView tabelafunc;
        public TabPage tablistfunc;
        public TextBox txtrg;
        public TextBox txtnomefunc;
    }
}