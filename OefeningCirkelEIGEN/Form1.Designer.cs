
namespace OefeningCirkelEIGEN
{
    partial class FrmCirkel
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
			this.btnBereken = new System.Windows.Forms.Button();
			this.lblstraal = new System.Windows.Forms.Label();
			this.txtStraal = new System.Windows.Forms.TextBox();
			this.lblbijRes = new System.Windows.Forms.Label();
			this.lblRes = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBereken
			// 
			this.btnBereken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.btnBereken.Location = new System.Drawing.Point(97, 107);
			this.btnBereken.Name = "btnBereken";
			this.btnBereken.Size = new System.Drawing.Size(122, 43);
			this.btnBereken.TabIndex = 0;
			this.btnBereken.Text = "BerekenOmtrek";
			this.btnBereken.UseVisualStyleBackColor = false;
			this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
			// 
			// lblstraal
			// 
			this.lblstraal.AutoSize = true;
			this.lblstraal.Location = new System.Drawing.Point(56, 46);
			this.lblstraal.Name = "lblstraal";
			this.lblstraal.Size = new System.Drawing.Size(42, 16);
			this.lblstraal.TabIndex = 1;
			this.lblstraal.Text = "Straal";
			// 
			// txtStraal
			// 
			this.txtStraal.Location = new System.Drawing.Point(180, 46);
			this.txtStraal.Name = "txtStraal";
			this.txtStraal.Size = new System.Drawing.Size(126, 22);
			this.txtStraal.TabIndex = 3;
			// 
			// lblbijRes
			// 
			this.lblbijRes.AutoSize = true;
			this.lblbijRes.Location = new System.Drawing.Point(36, 191);
			this.lblbijRes.Name = "lblbijRes";
			this.lblbijRes.Size = new System.Drawing.Size(64, 16);
			this.lblbijRes.TabIndex = 5;
			this.lblbijRes.Text = "Resultaat";
			// 
			// lblRes
			// 
			this.lblRes.Location = new System.Drawing.Point(206, 191);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(412, 124);
			this.lblRes.TabIndex = 6;
			// 
			// FrmCirkel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblRes);
			this.Controls.Add(this.lblbijRes);
			this.Controls.Add(this.txtStraal);
			this.Controls.Add(this.lblstraal);
			this.Controls.Add(this.btnBereken);
			this.Name = "FrmCirkel";
			this.Text = "CirkelPresentatielaag";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label lblstraal;
        private System.Windows.Forms.TextBox txtStraal;
        private System.Windows.Forms.Label lblbijRes;
        private System.Windows.Forms.Label lblRes;
    }
}

