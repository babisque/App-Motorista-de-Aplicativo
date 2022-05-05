namespace AppMotorista
{
    partial class RelatorioGeral
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
            this.lblMot01 = new System.Windows.Forms.Label();
            this.lblMot02 = new System.Windows.Forms.Label();
            this.lblMot03 = new System.Windows.Forms.Label();
            this.lblMot04 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMot01
            // 
            this.lblMot01.AutoSize = true;
            this.lblMot01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot01.Location = new System.Drawing.Point(12, 9);
            this.lblMot01.Name = "lblMot01";
            this.lblMot01.Size = new System.Drawing.Size(534, 20);
            this.lblMot01.TabIndex = 0;
            this.lblMot01.Text = "Motorista: {Nome} fez {Viagens} viagens, ganhou o total de R$ {ValorTotal}";
            // 
            // lblMot02
            // 
            this.lblMot02.AutoSize = true;
            this.lblMot02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot02.Location = new System.Drawing.Point(12, 43);
            this.lblMot02.Name = "lblMot02";
            this.lblMot02.Size = new System.Drawing.Size(534, 20);
            this.lblMot02.TabIndex = 0;
            this.lblMot02.Text = "Motorista: {Nome} fez {Viagens} viagens, ganhou o total de R$ {ValorTotal}";
            // 
            // lblMot03
            // 
            this.lblMot03.AutoSize = true;
            this.lblMot03.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot03.Location = new System.Drawing.Point(12, 78);
            this.lblMot03.Name = "lblMot03";
            this.lblMot03.Size = new System.Drawing.Size(534, 20);
            this.lblMot03.TabIndex = 0;
            this.lblMot03.Text = "Motorista: {Nome} fez {Viagens} viagens, ganhou o total de R$ {ValorTotal}";
            // 
            // lblMot04
            // 
            this.lblMot04.AutoSize = true;
            this.lblMot04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMot04.Location = new System.Drawing.Point(12, 115);
            this.lblMot04.Name = "lblMot04";
            this.lblMot04.Size = new System.Drawing.Size(534, 20);
            this.lblMot04.TabIndex = 0;
            this.lblMot04.Text = "Motorista: {Nome} fez {Viagens} viagens, ganhou o total de R$ {ValorTotal}";
            // 
            // RelatorioGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.lblMot04);
            this.Controls.Add(this.lblMot03);
            this.Controls.Add(this.lblMot02);
            this.Controls.Add(this.lblMot01);
            this.Name = "RelatorioGeral";
            this.Text = "RelatorioGeral";
            this.Load += new System.EventHandler(this.RelatorioGeral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMot01;
        private System.Windows.Forms.Label lblMot02;
        private System.Windows.Forms.Label lblMot03;
        private System.Windows.Forms.Label lblMot04;
    }
}