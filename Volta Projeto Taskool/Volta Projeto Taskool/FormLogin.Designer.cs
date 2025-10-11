namespace Volta_Projeto_Taskool
{
    partial class FormLogin
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
            this.LblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.BtTecladoVt = new System.Windows.Forms.LinkLabel();
            this.btCadastrarse = new System.Windows.Forms.LinkLabel();
            this.LblCredencial = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            this.btCredencial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(213, 109);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(126, 137);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(222, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // BtTecladoVt
            // 
            this.BtTecladoVt.AutoSize = true;
            this.BtTecladoVt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtTecladoVt.Location = new System.Drawing.Point(355, 143);
            this.BtTecladoVt.Name = "BtTecladoVt";
            this.BtTecladoVt.Size = new System.Drawing.Size(78, 13);
            this.BtTecladoVt.TabIndex = 3;
            this.BtTecladoVt.TabStop = true;
            this.BtTecladoVt.Text = "Teclado Virtual";
            this.BtTecladoVt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtTecladoVt_LinkClicked);
            // 
            // btCadastrarse
            // 
            this.btCadastrarse.Location = new System.Drawing.Point(0, 0);
            this.btCadastrarse.Name = "btCadastrarse";
            this.btCadastrarse.Size = new System.Drawing.Size(100, 23);
            this.btCadastrarse.TabIndex = 5;
            // 
            // LblCredencial
            // 
            this.LblCredencial.AutoSize = true;
            this.LblCredencial.Location = new System.Drawing.Point(207, 188);
            this.LblCredencial.Name = "LblCredencial";
            this.LblCredencial.Size = new System.Drawing.Size(57, 13);
            this.LblCredencial.TabIndex = 0;
            this.LblCredencial.Text = "Credencial";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(57, 41);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(362, 37);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Bem-Vindo ao Taskool";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(176, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Entrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkCadastro
            // 
            this.linkCadastro.AutoSize = true;
            this.linkCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkCadastro.Location = new System.Drawing.Point(204, 395);
            this.linkCadastro.Name = "linkCadastro";
            this.linkCadastro.Size = new System.Drawing.Size(63, 13);
            this.linkCadastro.TabIndex = 5;
            this.linkCadastro.TabStop = true;
            this.linkCadastro.Text = "Cadastre-se";
            this.linkCadastro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCadastro_Click);
            // 
            // btCredencial
            // 
            this.btCredencial.BackgroundImage = global::Volta_Projeto_Taskool.Properties.Resources.user;
            this.btCredencial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCredencial.Location = new System.Drawing.Point(198, 205);
            this.btCredencial.Name = "btCredencial";
            this.btCredencial.Size = new System.Drawing.Size(75, 73);
            this.btCredencial.TabIndex = 2;
            this.btCredencial.UseVisualStyleBackColor = true;
            this.btCredencial.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(477, 417);
            this.Controls.Add(this.btCredencial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btCadastrarse);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.BtTecladoVt);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.LblCredencial);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.LblUsuario);
            this.Name = "FormLogin";
            this.Text = "Cadastre-se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.LinkLabel BtTecladoVt;
        private System.Windows.Forms.LinkLabel btCadastrarse;
        private System.Windows.Forms.Label LblCredencial;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkCadastro;
        private System.Windows.Forms.Button btCredencial;
    }
}

