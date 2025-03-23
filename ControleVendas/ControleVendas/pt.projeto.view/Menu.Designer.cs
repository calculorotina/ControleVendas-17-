namespace ControleVendas.pt.projeto.view
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            MenuPrincipal = new MenuStrip();
            menuclientes = new ToolStripMenuItem();
            menucriarcliente = new ToolStripMenuItem();
            menulistarcliente = new ToolStripMenuItem();
            menufornecedores = new ToolStripMenuItem();
            menucriarfornecedor = new ToolStripMenuItem();
            menulistarfornecedor = new ToolStripMenuItem();
            menuprodutos = new ToolStripMenuItem();
            menucriarproduto = new ToolStripMenuItem();
            menulistarproduto = new ToolStripMenuItem();
            menuvendas = new ToolStripMenuItem();
            menucriarvenda = new ToolStripMenuItem();
            menulistarvenda = new ToolStripMenuItem();
            menufuncionarios = new ToolStripMenuItem();
            menucriarfuncionario = new ToolStripMenuItem();
            menulistarfuncionario = new ToolStripMenuItem();
            menuhistorico = new ToolStripMenuItem();
            menuconfiguracoes = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            Data = new ToolStripStatusLabel();
            menudata = new ToolStripStatusLabel();
            hora = new ToolStripStatusLabel();
            menuhora = new ToolStripStatusLabel();
            utilizador = new ToolStripStatusLabel();
            menuutilizador = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            MenuPrincipal.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.ImageScalingSize = new Size(20, 20);
            MenuPrincipal.Items.AddRange(new ToolStripItem[] { menuclientes, menufornecedores, menuprodutos, menuvendas, menufuncionarios, menuhistorico, menuconfiguracoes });
            MenuPrincipal.Location = new Point(0, 0);
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(1743, 39);
            MenuPrincipal.TabIndex = 0;
            MenuPrincipal.Text = "Data";
            MenuPrincipal.ItemClicked += menuStrip1_ItemClicked;
            // 
            // menuclientes
            // 
            menuclientes.DropDownItems.AddRange(new ToolStripItem[] { menucriarcliente, menulistarcliente });
            menuclientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuclientes.Image = Properties.Resources._4850489_clients_communication_discussion_media_social_icon;
            menuclientes.Name = "menuclientes";
            menuclientes.Size = new Size(129, 35);
            menuclientes.Text = "Clientes";
            // 
            // menucriarcliente
            // 
            menucriarcliente.Name = "menucriarcliente";
            menucriarcliente.Size = new Size(244, 36);
            menucriarcliente.Text = "Criar Cliente";
            menucriarcliente.Click += menucriarcliente_Click;
            // 
            // menulistarcliente
            // 
            menulistarcliente.Name = "menulistarcliente";
            menulistarcliente.Size = new Size(244, 36);
            menulistarcliente.Text = "Listar Clientes";
            menulistarcliente.Click += menulistarcliente_Click;
            // 
            // menufornecedores
            // 
            menufornecedores.DropDownItems.AddRange(new ToolStripItem[] { menucriarfornecedor, menulistarfornecedor });
            menufornecedores.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menufornecedores.Image = Properties.Resources._4308186_advancement_career_employee_ladder_promotion_icon;
            menufornecedores.Name = "menufornecedores";
            menufornecedores.Size = new Size(185, 35);
            menufornecedores.Text = "Fornecedores";
            // 
            // menucriarfornecedor
            // 
            menucriarfornecedor.Name = "menucriarfornecedor";
            menucriarfornecedor.Size = new Size(300, 36);
            menucriarfornecedor.Text = "Criar Fornecedor";
            menucriarfornecedor.Click += menucriarfornecedor_Click;
            // 
            // menulistarfornecedor
            // 
            menulistarfornecedor.Name = "menulistarfornecedor";
            menulistarfornecedor.Size = new Size(300, 36);
            menulistarfornecedor.Text = "Listar Fornecedores";
            menulistarfornecedor.Click += menulistarfornecedor_Click;
            // 
            // menuprodutos
            // 
            menuprodutos.DropDownItems.AddRange(new ToolStripItem[] { menucriarproduto, menulistarproduto });
            menuprodutos.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuprodutos.Image = Properties.Resources._4172394_goods_merchandise_stock_supply_vendibles_icon;
            menuprodutos.Name = "menuprodutos";
            menuprodutos.Size = new Size(140, 35);
            menuprodutos.Text = "Produtos";
            // 
            // menucriarproduto
            // 
            menucriarproduto.Name = "menucriarproduto";
            menucriarproduto.Size = new Size(255, 36);
            menucriarproduto.Text = "Criar Produtos";
            menucriarproduto.Click += menucriarproduto_Click;
            // 
            // menulistarproduto
            // 
            menulistarproduto.Name = "menulistarproduto";
            menulistarproduto.Size = new Size(255, 36);
            menulistarproduto.Text = "Listar Produtos";
            menulistarproduto.Click += menulistarproduto_Click;
            // 
            // menuvendas
            // 
            menuvendas.DropDownItems.AddRange(new ToolStripItem[] { menucriarvenda, menulistarvenda });
            menuvendas.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuvendas.Image = Properties.Resources._7898384_sales_business_finance_office_marketing_icon;
            menuvendas.Name = "menuvendas";
            menuvendas.Size = new Size(122, 35);
            menuvendas.Text = "Vendas";
            // 
            // menucriarvenda
            // 
            menucriarvenda.Name = "menucriarvenda";
            menucriarvenda.Size = new Size(237, 36);
            menucriarvenda.Text = "Criar Venda";
            menucriarvenda.Click += menucriarvenda_Click;
            // 
            // menulistarvenda
            // 
            menulistarvenda.Name = "menulistarvenda";
            menulistarvenda.Size = new Size(237, 36);
            menulistarvenda.Text = "Listar Vendas";
            // 
            // menufuncionarios
            // 
            menufuncionarios.DropDownItems.AddRange(new ToolStripItem[] { menucriarfuncionario, menulistarfuncionario });
            menufuncionarios.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menufuncionarios.Image = Properties.Resources._4850489_clients_communication_discussion_media_social_icon;
            menufuncionarios.Name = "menufuncionarios";
            menufuncionarios.Size = new Size(177, 35);
            menufuncionarios.Text = "Funcionarios";
            // 
            // menucriarfuncionario
            // 
            menucriarfuncionario.Name = "menucriarfuncionario";
            menucriarfuncionario.Size = new Size(292, 36);
            menucriarfuncionario.Text = "Criar Funcionarios";
            menucriarfuncionario.Click += menucriarfuncionario_Click;
            // 
            // menulistarfuncionario
            // 
            menulistarfuncionario.Name = "menulistarfuncionario";
            menulistarfuncionario.Size = new Size(292, 36);
            menulistarfuncionario.Text = "Listar Funcionarios";
            menulistarfuncionario.Click += menulistarfuncionario_Click;
            // 
            // menuhistorico
            // 
            menuhistorico.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuhistorico.Name = "menuhistorico";
            menuhistorico.Size = new Size(119, 35);
            menuhistorico.Text = "Historico";
            // 
            // menuconfiguracoes
            // 
            menuconfiguracoes.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuconfiguracoes.Image = Properties.Resources._2528046_cellphone_configurations_development_gear_mobile_icon;
            menuconfiguracoes.Name = "menuconfiguracoes";
            menuconfiguracoes.Size = new Size(194, 35);
            menuconfiguracoes.Text = "Configuraçoes";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { Data, menudata, hora, menuhora, utilizador, menuutilizador });
            statusStrip1.Location = new Point(0, 538);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1743, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // Data
            // 
            Data.Name = "Data";
            Data.Size = new Size(44, 20);
            Data.Text = "Data:";
            // 
            // menudata
            // 
            menudata.Name = "menudata";
            menudata.Size = new Size(85, 20);
            menudata.Text = "12/10/2025";
            // 
            // hora
            // 
            hora.Name = "hora";
            hora.Size = new Size(45, 20);
            hora.Text = "Hora:";
            // 
            // menuhora
            // 
            menuhora.Name = "menuhora";
            menuhora.Size = new Size(44, 20);
            menuhora.Text = "10:20";
            // 
            // utilizador
            // 
            utilizador.Name = "utilizador";
            utilizador.Size = new Size(77, 20);
            utilizador.Text = "Utilizador:";
            // 
            // menuutilizador
            // 
            menuutilizador.Name = "menuutilizador";
            menuutilizador.Size = new Size(55, 20);
            menuutilizador.Text = "Nelson";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1743, 564);
            Controls.Add(statusStrip1);
            Controls.Add(MenuPrincipal);
            MainMenuStrip = MenuPrincipal;
            Name = "Menu";
            Text = "Menu";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Load;
            MenuPrincipal.ResumeLayout(false);
            MenuPrincipal.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MenuPrincipal;
        public ToolStripMenuItem menuclientes;
        public ToolStripMenuItem menucriarcliente;
        public ToolStripMenuItem menulistarcliente;
        public ToolStripMenuItem menufornecedores;
        public ToolStripMenuItem menucriarfornecedor;
        public ToolStripMenuItem menulistarfornecedor;
        public ToolStripMenuItem menuprodutos;
        public ToolStripMenuItem menucriarproduto;
        public ToolStripMenuItem menulistarproduto;
        public ToolStripMenuItem menuvendas;
        public ToolStripMenuItem menucriarvenda;
        public ToolStripMenuItem menulistarvenda;
        public ToolStripMenuItem menuhistorico;
        public ToolStripMenuItem menuconfiguracoes;
        public ToolStripMenuItem menufuncionarios;
        public ToolStripMenuItem menucriarfuncionario;
        public ToolStripMenuItem menulistarfuncionario;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Data;
        public ToolStripStatusLabel menudata;
        private ToolStripStatusLabel hora;
        public ToolStripStatusLabel menuhora;
        private ToolStripStatusLabel utilizador;
        public ToolStripStatusLabel menuutilizador;
        private System.Windows.Forms.Timer timer1;
    }
}