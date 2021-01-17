namespace PrimeiroProjeto_BancoDeDados
{
    partial class login
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
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLoginNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxLoginSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.Location = new System.Drawing.Point(44, 116);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(110, 35);
            this.buttonEntrar.TabIndex = 0;
            this.buttonEntrar.Text = "&Logar";
            this.buttonEntrar.UseVisualStyleBackColor = true;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // textBoxLoginNome
            // 
            this.textBoxLoginNome.Location = new System.Drawing.Point(66, 32);
            this.textBoxLoginNome.Name = "textBoxLoginNome";
            this.textBoxLoginNome.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // textBoxLoginSenha
            // 
            this.textBoxLoginSenha.Location = new System.Drawing.Point(66, 65);
            this.textBoxLoginSenha.Name = "textBoxLoginSenha";
            this.textBoxLoginSenha.PasswordChar = '*';
            this.textBoxLoginSenha.Size = new System.Drawing.Size(100, 20);
            this.textBoxLoginSenha.TabIndex = 4;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 171);
            this.Controls.Add(this.textBoxLoginSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLoginNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonEntrar);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLoginNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxLoginSenha;
    }
}