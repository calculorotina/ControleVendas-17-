namespace ControleVendas.pt.projeto.view
{
    partial class frmPagamento
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
            txtdinheiro = new TextBox();
            lblcodigo = new Label();
            txtcartao = new TextBox();
            label1 = new Label();
            txttroco = new TextBox();
            label2 = new Label();
            txttotal = new TextBox();
            label3 = new Label();
            btnpagamento = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(txttitulo);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(526, 115);
            panel1.TabIndex = 1;
            // 
            // txttitulo
            // 
            txttitulo.AutoSize = true;
            txttitulo.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttitulo.ForeColor = SystemColors.ButtonHighlight;
            txttitulo.Location = new Point(144, 31);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(223, 54);
            txttitulo.TabIndex = 0;
            txttitulo.Text = "Pagamento";
            // 
            // txtdinheiro
            // 
            txtdinheiro.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtdinheiro.Location = new Point(189, 149);
            txtdinheiro.Name = "txtdinheiro";
            txtdinheiro.Size = new Size(269, 47);
            txtdinheiro.TabIndex = 3;
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcodigo.Location = new Point(32, 152);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(131, 41);
            lblcodigo.TabIndex = 2;
            lblcodigo.Text = "Dinheiro";
            // 
            // txtcartao
            // 
            txtcartao.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcartao.Location = new Point(189, 217);
            txtcartao.Name = "txtcartao";
            txtcartao.Size = new Size(269, 47);
            txtcartao.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 220);
            label1.Name = "label1";
            label1.Size = new Size(105, 41);
            label1.TabIndex = 4;
            label1.Text = "Cartao";
            // 
            // txttroco
            // 
            txttroco.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttroco.Location = new Point(189, 288);
            txttroco.Name = "txttroco";
            txttroco.ReadOnly = true;
            txttroco.Size = new Size(269, 47);
            txttroco.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 291);
            label2.Name = "label2";
            label2.Size = new Size(91, 41);
            label2.TabIndex = 6;
            label2.Text = "Troco";
            // 
            // txttotal
            // 
            txttotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttotal.Location = new Point(189, 357);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(269, 47);
            txttotal.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(78, 360);
            label3.Name = "label3";
            label3.Size = new Size(81, 41);
            label3.TabIndex = 8;
            label3.Text = "Total";
            label3.Click += label3_Click;
            // 
            // btnpagamento
            // 
            btnpagamento.BackColor = Color.DodgerBlue;
            btnpagamento.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnpagamento.ForeColor = SystemColors.ButtonHighlight;
            btnpagamento.Location = new Point(58, 440);
            btnpagamento.Name = "btnpagamento";
            btnpagamento.Size = new Size(417, 66);
            btnpagamento.TabIndex = 25;
            btnpagamento.Text = "Pagamento";
            btnpagamento.UseVisualStyleBackColor = false;
            btnpagamento.Click += btnpagamento_Click;
            // 
            // frmPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(529, 518);
            Controls.Add(btnpagamento);
            Controls.Add(txttotal);
            Controls.Add(label3);
            Controls.Add(txttroco);
            Controls.Add(label2);
            Controls.Add(txtcartao);
            Controls.Add(label1);
            Controls.Add(txtdinheiro);
            Controls.Add(lblcodigo);
            Controls.Add(panel1);
            Name = "frmPagamento";
            Text = "frmPagamento";
            Load += frmPagamento_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txttitulo;
        private TextBox txtdinheiro;
        private Label lblcodigo;
        private TextBox txtcartao;
        private Label label1;
        private TextBox txttroco;
        private Label label2;
        private Label label3;
        private Button btnpagamento;
        public TextBox txttotal;
    }
}