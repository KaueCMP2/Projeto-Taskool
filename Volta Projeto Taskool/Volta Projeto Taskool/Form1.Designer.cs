namespace Volta_Projeto_Taskool
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRelogio = new System.Windows.Forms.Label();
            this.lblCumprimento = new System.Windows.Forms.Label();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btIngles = new System.Windows.Forms.Button();
            this.btPurtugues = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 476);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(661, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 63);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Font = new System.Drawing.Font("Microsoft Tai Le", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelogio.Location = new System.Drawing.Point(263, 219);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(162, 71);
            this.lblRelogio.TabIndex = 2;
            this.lblRelogio.Text = "12:00";
            this.lblRelogio.Visible = false;
            // 
            // lblCumprimento
            // 
            this.lblCumprimento.AutoSize = true;
            this.lblCumprimento.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumprimento.Location = new System.Drawing.Point(247, 286);
            this.lblCumprimento.Name = "lblCumprimento";
            this.lblCumprimento.Size = new System.Drawing.Size(227, 34);
            this.lblCumprimento.TabIndex = 3;
            this.lblCumprimento.Text = "Boa Noite, Nome!";
            this.lblCumprimento.Visible = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(249, 341);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(302, 20);
            this.lblMensagem.TabIndex = 4;
            this.lblMensagem.Text = "Para estar preso, basta idealizar a liberdade.";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft JhengHei Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(250, 361);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(83, 15);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Por eu, para eu";
            // 
            // btIngles
            // 
            this.btIngles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btIngles.Location = new System.Drawing.Point(696, 406);
            this.btIngles.Name = "btIngles";
            this.btIngles.Size = new System.Drawing.Size(35, 35);
            this.btIngles.TabIndex = 5;
            this.btIngles.Text = "En";
            this.btIngles.UseVisualStyleBackColor = false;
            this.btIngles.Click += new System.EventHandler(this.btIngles_Click);
            // 
            // btPurtugues
            // 
            this.btPurtugues.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btPurtugues.Location = new System.Drawing.Point(655, 406);
            this.btPurtugues.Name = "btPurtugues";
            this.btPurtugues.Size = new System.Drawing.Size(35, 35);
            this.btPurtugues.TabIndex = 5;
            this.btPurtugues.Text = "Pt";
            this.btPurtugues.UseVisualStyleBackColor = false;
            this.btPurtugues.Click += new System.EventHandler(this.btPurtugues_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 453);
            this.Controls.Add(this.btPurtugues);
            this.Controls.Add(this.btIngles);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.lblCumprimento);
            this.Controls.Add(this.lblRelogio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.Text = "Menu Principal | Taskool";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Label lblCumprimento;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Button btIngles;
        private System.Windows.Forms.Button btPurtugues;
    }
}