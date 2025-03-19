namespace ControleVendas.pt.projeto.view
{
    partial class frmLogin
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
            label1 = new Label();
            txtemail = new TextBox();
            lblemail = new Label();
            txtpassword = new TextBox();
            lblsenha = new Label();
            btnlogin = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 106);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(250, 19);
            label1.Name = "label1";
            label1.Size = new Size(299, 62);
            label1.TabIndex = 0;
            label1.Text = "Autenticaçao";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(281, 166);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(399, 38);
            txtemail.TabIndex = 3;
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblemail.Location = new Point(148, 166);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(83, 38);
            lblemail.TabIndex = 2;
            lblemail.Text = "Email";
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpassword.Location = new Point(281, 253);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(399, 38);
            txtpassword.TabIndex = 5;
            // 
            // lblsenha
            // 
            lblsenha.AutoSize = true;
            lblsenha.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblsenha.Location = new Point(99, 251);
            lblsenha.Name = "lblsenha";
            lblsenha.Size = new Size(132, 38);
            lblsenha.TabIndex = 4;
            lblsenha.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.DodgerBlue;
            btnlogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = SystemColors.ButtonHighlight;
            btnlogin.Location = new Point(281, 341);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(399, 55);
            btnlogin.TabIndex = 25;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(txtpassword);
            Controls.Add(lblsenha);
            Controls.Add(txtemail);
            Controls.Add(lblemail);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "Pagina de Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblemail;
        private Label lblsenha;
        private Button btnlogin;
        public TextBox txtemail;
        public TextBox txtpassword;
    }
}