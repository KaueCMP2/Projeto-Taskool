namespace Comparador_Imagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btComparar = new System.Windows.Forms.Button();
            this.btImagem2 = new System.Windows.Forms.PictureBox();
            this.btImagem1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btImagem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btImagem1)).BeginInit();
            this.SuspendLayout();
            // 
            // btComparar
            // 
            this.btComparar.Location = new System.Drawing.Point(278, 324);
            this.btComparar.Name = "btComparar";
            this.btComparar.Size = new System.Drawing.Size(233, 66);
            this.btComparar.TabIndex = 0;
            this.btComparar.Text = "Comparar";
            this.btComparar.UseVisualStyleBackColor = true;
            // 
            // btImagem2
            // 
            this.btImagem2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImagem2.BackgroundImage")));
            this.btImagem2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImagem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImagem2.Location = new System.Drawing.Point(405, 38);
            this.btImagem2.Name = "btImagem2";
            this.btImagem2.Size = new System.Drawing.Size(292, 259);
            this.btImagem2.TabIndex = 1;
            this.btImagem2.TabStop = false;
            this.btImagem2.Click += new System.EventHandler(this.btImagem2_Click);
            // 
            // btImagem1
            // 
            this.btImagem1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btImagem1.BackgroundImage")));
            this.btImagem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btImagem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btImagem1.Location = new System.Drawing.Point(107, 38);
            this.btImagem1.Name = "btImagem1";
            this.btImagem1.Size = new System.Drawing.Size(292, 259);
            this.btImagem1.TabIndex = 1;
            this.btImagem1.TabStop = false;
            this.btImagem1.Click += new System.EventHandler(this.btImagem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btImagem1);
            this.Controls.Add(this.btImagem2);
            this.Controls.Add(this.btComparar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btImagem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btImagem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btComparar;
        private System.Windows.Forms.PictureBox btImagem2;
        private System.Windows.Forms.PictureBox btImagem1;
    }
}

