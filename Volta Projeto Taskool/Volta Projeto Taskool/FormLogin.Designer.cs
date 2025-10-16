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
            this.BtTecladoVt = new System.Windows.Forms.LinkLabel();
            this.btCadastrarse = new System.Windows.Forms.LinkLabel();
            this.LblCredencial = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.BtEntrar = new System.Windows.Forms.Button();
            this.linkCadastro = new System.Windows.Forms.LinkLabel();
            this.btCredencial = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.BordaTxtUsuario = new System.Windows.Forms.PictureBox();
            this.lblCapsLock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtUsuario)).BeginInit();
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
            // BtEntrar
            // 
            this.BtEntrar.BackColor = System.Drawing.Color.LightGray;
            this.BtEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtEntrar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtEntrar.Location = new System.Drawing.Point(176, 309);
            this.BtEntrar.Name = "BtEntrar";
            this.BtEntrar.Size = new System.Drawing.Size(119, 35);
            this.BtEntrar.TabIndex = 4;
            this.BtEntrar.Text = "Entrar";
            this.BtEntrar.UseVisualStyleBackColor = false;
            this.BtEntrar.Click += new System.EventHandler(this.BtEntrar_Click);
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
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(127, 140);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(222, 20);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // BordaTxtUsuario
            // 
            this.BordaTxtUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.BordaTxtUsuario.Location = new System.Drawing.Point(124, 137);
            this.BordaTxtUsuario.Name = "BordaTxtUsuario";
            this.BordaTxtUsuario.Size = new System.Drawing.Size(228, 24);
            this.BordaTxtUsuario.TabIndex = 6;
            this.BordaTxtUsuario.TabStop = false;
            this.BordaTxtUsuario.Visible = false;
            // 
            // lblCapsLock
            // 
            this.lblCapsLock.AutoSize = true;
            this.lblCapsLock.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapsLock.ForeColor = System.Drawing.Color.Red;
            this.lblCapsLock.Location = new System.Drawing.Point(200, 163);
            this.lblCapsLock.Name = "lblCapsLock";
            this.lblCapsLock.Size = new System.Drawing.Size(68, 7);
            this.lblCapsLock.TabIndex = 7;
            this.lblCapsLock.Text = "CAPS LOCK ATIVO";
            this.lblCapsLock.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(477, 417);
            this.Controls.Add(this.lblCapsLock);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.BordaTxtUsuario);
            this.Controls.Add(this.btCredencial);
            this.Controls.Add(this.BtEntrar);
            this.Controls.Add(this.btCadastrarse);
            this.Controls.Add(this.linkCadastro);
            this.Controls.Add(this.BtTecladoVt);
            this.Controls.Add(this.LblCredencial);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.LblUsuario);
            this.KeyPreview = true;
            this.Name = "FormLogin";
            this.Text = "Login | Taskool";
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.LinkLabel BtTecladoVt;
        private System.Windows.Forms.LinkLabel btCadastrarse;
        private System.Windows.Forms.Label LblCredencial;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BtEntrar;
        private System.Windows.Forms.LinkLabel linkCadastro;
        private System.Windows.Forms.Button btCredencial;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox BordaTxtUsuario;
        private System.Windows.Forms.Label lblCapsLock;
    }
}

