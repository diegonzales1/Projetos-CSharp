namespace ListaDeExercicios
{
    partial class ConcessionariaB
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUnitaryValue = new System.Windows.Forms.TextBox();
            this.groupBoxFormaPagamento = new System.Windows.Forms.GroupBox();
            this.radioButtonCard = new System.Windows.Forms.RadioButton();
            this.radioButtonInCash = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxTotalCard = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTotalCash = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonCalculator = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxFormaPagamento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(71, 45);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(53, 25);
            this.textBoxCode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(227, 45);
            this.textBoxQuantity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(53, 25);
            this.textBoxQuantity.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor unitário:";
            // 
            // textBoxUnitaryValue
            // 
            this.textBoxUnitaryValue.Location = new System.Drawing.Point(392, 45);
            this.textBoxUnitaryValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxUnitaryValue.Name = "textBoxUnitaryValue";
            this.textBoxUnitaryValue.Size = new System.Drawing.Size(62, 25);
            this.textBoxUnitaryValue.TabIndex = 5;
            this.textBoxUnitaryValue.TextChanged += new System.EventHandler(this.textBoxValorUnitario_TextChanged);
            // 
            // groupBoxFormaPagamento
            // 
            this.groupBoxFormaPagamento.Controls.Add(this.radioButtonCard);
            this.groupBoxFormaPagamento.Controls.Add(this.radioButtonInCash);
            this.groupBoxFormaPagamento.Location = new System.Drawing.Point(17, 104);
            this.groupBoxFormaPagamento.Name = "groupBoxFormaPagamento";
            this.groupBoxFormaPagamento.Size = new System.Drawing.Size(204, 94);
            this.groupBoxFormaPagamento.TabIndex = 6;
            this.groupBoxFormaPagamento.TabStop = false;
            this.groupBoxFormaPagamento.Text = "Forma de Pagamento:";
            this.groupBoxFormaPagamento.Visible = false;
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Location = new System.Drawing.Point(94, 40);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(64, 24);
            this.radioButtonCard.TabIndex = 7;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Cartão";
            this.radioButtonCard.UseVisualStyleBackColor = true;
            // 
            // radioButtonInCash
            // 
            this.radioButtonInCash.AutoSize = true;
            this.radioButtonInCash.Location = new System.Drawing.Point(27, 40);
            this.radioButtonInCash.Name = "radioButtonInCash";
            this.radioButtonInCash.Size = new System.Drawing.Size(61, 24);
            this.radioButtonInCash.TabIndex = 0;
            this.radioButtonInCash.TabStop = true;
            this.radioButtonInCash.Text = "À vista";
            this.radioButtonInCash.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxTotalCard);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxTotalCash);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(235, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(219, 94);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // textBoxTotalCard
            // 
            this.textBoxTotalCard.Enabled = false;
            this.textBoxTotalCard.Location = new System.Drawing.Point(100, 52);
            this.textBoxTotalCard.Name = "textBoxTotalCard";
            this.textBoxTotalCard.Size = new System.Drawing.Size(100, 25);
            this.textBoxTotalCard.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Cartão";
            // 
            // textBoxTotalCash
            // 
            this.textBoxTotalCash.Enabled = false;
            this.textBoxTotalCash.Location = new System.Drawing.Point(100, 23);
            this.textBoxTotalCash.Name = "textBoxTotalCash";
            this.textBoxTotalCash.Size = new System.Drawing.Size(100, 25);
            this.textBoxTotalCash.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total à vista";
            // 
            // buttonCalculator
            // 
            this.buttonCalculator.Location = new System.Drawing.Point(44, 225);
            this.buttonCalculator.Name = "buttonCalculator";
            this.buttonCalculator.Size = new System.Drawing.Size(100, 30);
            this.buttonCalculator.TabIndex = 8;
            this.buttonCalculator.Text = "&Calculadora";
            this.buttonCalculator.UseVisualStyleBackColor = true;
            this.buttonCalculator.Click += new System.EventHandler(this.buttonCalculadora_Click);
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(190, 225);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(100, 30);
            this.buttonPayment.TabIndex = 9;
            this.buttonPayment.Text = "&Pagamento";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPagamento_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(335, 225);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 10;
            this.buttonClose.Text = "&Sair";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // ConcessionariaB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(473, 278);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonCalculator);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxFormaPagamento);
            this.Controls.Add(this.textBoxUnitaryValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ConcessionariaB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concessionária B";
            this.groupBoxFormaPagamento.ResumeLayout(false);
            this.groupBoxFormaPagamento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUnitaryValue;
        private System.Windows.Forms.GroupBox groupBoxFormaPagamento;
        private System.Windows.Forms.RadioButton radioButtonCard;
        private System.Windows.Forms.RadioButton radioButtonInCash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxTotalCard;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTotalCash;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCalculator;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonClose;
    }
}