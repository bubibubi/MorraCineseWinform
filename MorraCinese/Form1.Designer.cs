namespace MorraCinese
{
    partial class Form1
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
            this.btnNuovo = new System.Windows.Forms.Button();
            this.btnSasso = new System.Windows.Forms.Button();
            this.btnCarta = new System.Windows.Forms.Button();
            this.btnForbici = new System.Windows.Forms.Button();
            this.lblGiocataComputer = new System.Windows.Forms.Label();
            this.lblVincitore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(13, 15);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(84, 30);
            this.btnNuovo.TabIndex = 0;
            this.btnNuovo.Text = "Nuovo";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnSasso
            // 
            this.btnSasso.Location = new System.Drawing.Point(118, 15);
            this.btnSasso.Name = "btnSasso";
            this.btnSasso.Size = new System.Drawing.Size(84, 47);
            this.btnSasso.TabIndex = 0;
            this.btnSasso.Text = "disegno del sasso";
            this.btnSasso.UseVisualStyleBackColor = true;
            this.btnSasso.Click += new System.EventHandler(this.btnSasso_Click);
            // 
            // btnCarta
            // 
            this.btnCarta.Location = new System.Drawing.Point(118, 68);
            this.btnCarta.Name = "btnCarta";
            this.btnCarta.Size = new System.Drawing.Size(84, 47);
            this.btnCarta.TabIndex = 0;
            this.btnCarta.Text = "disegno della carta";
            this.btnCarta.UseVisualStyleBackColor = true;
            // 
            // btnForbici
            // 
            this.btnForbici.Location = new System.Drawing.Point(118, 121);
            this.btnForbici.Name = "btnForbici";
            this.btnForbici.Size = new System.Drawing.Size(84, 47);
            this.btnForbici.TabIndex = 0;
            this.btnForbici.Text = "disegno delle forbici";
            this.btnForbici.UseVisualStyleBackColor = true;
            // 
            // lblGiocataComputer
            // 
            this.lblGiocataComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGiocataComputer.Location = new System.Drawing.Point(12, 189);
            this.lblGiocataComputer.Name = "lblGiocataComputer";
            this.lblGiocataComputer.Size = new System.Drawing.Size(190, 17);
            this.lblGiocataComputer.TabIndex = 1;
            this.lblGiocataComputer.Text = "lblGiocataComputer";
            // 
            // lblVincitore
            // 
            this.lblVincitore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVincitore.Location = new System.Drawing.Point(12, 218);
            this.lblVincitore.Name = "lblVincitore";
            this.lblVincitore.Size = new System.Drawing.Size(190, 17);
            this.lblVincitore.TabIndex = 1;
            this.lblVincitore.Text = "lblVincitore";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 250);
            this.Controls.Add(this.lblVincitore);
            this.Controls.Add(this.lblGiocataComputer);
            this.Controls.Add(this.btnForbici);
            this.Controls.Add(this.btnCarta);
            this.Controls.Add(this.btnSasso);
            this.Controls.Add(this.btnNuovo);
            this.Name = "Form1";
            this.Text = "Morra cinese";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnSasso;
        private System.Windows.Forms.Button btnCarta;
        private System.Windows.Forms.Button btnForbici;
        private System.Windows.Forms.Label lblGiocataComputer;
        private System.Windows.Forms.Label lblVincitore;
    }
}

