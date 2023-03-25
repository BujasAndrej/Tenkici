
namespace Tenkici
{
    partial class Tenkici
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tenkici));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pucaj = new System.Windows.Forms.Button();
            this.Pomeri_levo = new System.Windows.Forms.Button();
            this.Pomeri_desno = new System.Windows.Forms.Button();
            this.Tank = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tank)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.Tank);
            this.splitContainer1.Size = new System.Drawing.Size(990, 516);
            this.splitContainer1.SplitterDistance = 743;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.Pucaj);
            this.panel1.Controls.Add(this.Pomeri_levo);
            this.panel1.Controls.Add(this.Pomeri_desno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 100);
            this.panel1.TabIndex = 3;
            // 
            // Pucaj
            // 
            this.Pucaj.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pucaj.Location = new System.Drawing.Point(319, 31);
            this.Pucaj.Name = "Pucaj";
            this.Pucaj.Size = new System.Drawing.Size(75, 43);
            this.Pucaj.TabIndex = 1;
            this.Pucaj.Text = "+";
            this.Pucaj.UseVisualStyleBackColor = true;
            // 
            // Pomeri_levo
            // 
            this.Pomeri_levo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pomeri_levo.Location = new System.Drawing.Point(219, 31);
            this.Pomeri_levo.Name = "Pomeri_levo";
            this.Pomeri_levo.Size = new System.Drawing.Size(75, 43);
            this.Pomeri_levo.TabIndex = 0;
            this.Pomeri_levo.Text = "<";
            this.Pomeri_levo.UseVisualStyleBackColor = true;
            // 
            // Pomeri_desno
            // 
            this.Pomeri_desno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Pomeri_desno.Location = new System.Drawing.Point(420, 31);
            this.Pomeri_desno.Name = "Pomeri_desno";
            this.Pomeri_desno.Size = new System.Drawing.Size(75, 43);
            this.Pomeri_desno.TabIndex = 2;
            this.Pomeri_desno.Text = ">";
            this.Pomeri_desno.UseVisualStyleBackColor = true;
            // 
            // Tank
            // 
            this.Tank.BackColor = System.Drawing.Color.Transparent;
            this.Tank.Image = ((System.Drawing.Image)(resources.GetObject("Tank.Image")));
            this.Tank.Location = new System.Drawing.Point(319, 291);
            this.Tank.Name = "Tank";
            this.Tank.Size = new System.Drawing.Size(70, 100);
            this.Tank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Tank.TabIndex = 1;
            this.Tank.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(743, 100);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 516);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Pomeri_desno;
        private System.Windows.Forms.Button Pucaj;
        private System.Windows.Forms.Button Pomeri_levo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Tank;
        private System.Windows.Forms.Panel panel2;
    }
}

