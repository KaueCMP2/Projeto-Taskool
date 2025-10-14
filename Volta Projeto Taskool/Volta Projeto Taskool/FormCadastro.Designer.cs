namespace Volta_Projeto_Taskool
{
    partial class FormCadastro
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
            this.LblNome = new System.Windows.Forms.Label();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblTelefone = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.LblDataNasc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btGeraAuto = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.BoxSelecionarCredencial = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BordaTxtNome = new System.Windows.Forms.PictureBox();
            this.BordaTxtEmail = new System.Windows.Forms.PictureBox();
            this.BordaTxtTelefone = new System.Windows.Forms.PictureBox();
            this.BordaTxtUsuario = new System.Windows.Forms.PictureBox();
            this.btIdade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BoxSelecionarCredencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtTelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastre-se";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(91, 89);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 0;
            this.LblNome.Text = "Nome";
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Location = new System.Drawing.Point(91, 122);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(32, 13);
            this.LblEmail.TabIndex = 0;
            this.LblEmail.Text = "Email";
            // 
            // LblTelefone
            // 
            this.LblTelefone.AutoSize = true;
            this.LblTelefone.Location = new System.Drawing.Point(77, 154);
            this.LblTelefone.Name = "LblTelefone";
            this.LblTelefone.Size = new System.Drawing.Size(49, 13);
            this.LblTelefone.TabIndex = 0;
            this.LblTelefone.Text = "Telefone";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(80, 188);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(43, 13);
            this.LblUsuario.TabIndex = 0;
            this.LblUsuario.Text = "Usuário";
            // 
            // LblDataNasc
            // 
            this.LblDataNasc.AutoSize = true;
            this.LblDataNasc.Location = new System.Drawing.Point(50, 224);
            this.LblDataNasc.Name = "LblDataNasc";
            this.LblDataNasc.Size = new System.Drawing.Size(76, 13);
            this.LblDataNasc.TabIndex = 0;
            this.LblDataNasc.Text = "Data de Nasc.";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(132, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(291, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.Enter += new System.EventHandler(this.txtNome_Enter);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(132, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(291, 20);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(132, 149);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(291, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.Enter += new System.EventHandler(this.txtTelefone_Enter);
            this.txtTelefone.Leave += new System.EventHandler(this.txtTelefone_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(132, 183);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(291, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // dataNascimento
            // 
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(132, 218);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(200, 20);
            this.dataNascimento.TabIndex = 6;
            // 
            // btGeraAuto
            // 
            this.btGeraAuto.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btGeraAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btGeraAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGeraAuto.Location = new System.Drawing.Point(431, 177);
            this.btGeraAuto.Name = "btGeraAuto";
            this.btGeraAuto.Size = new System.Drawing.Size(61, 33);
            this.btGeraAuto.TabIndex = 5;
            this.btGeraAuto.Text = "Gerar Aleatorio";
            this.btGeraAuto.UseVisualStyleBackColor = false;
            this.btGeraAuto.Click += new System.EventHandler(this.btGeraAuto_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.LightGray;
            this.btSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(198, 388);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(119, 26);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // BoxSelecionarCredencial
            // 
            this.BoxSelecionarCredencial.BackColor = System.Drawing.Color.Transparent;
            this.BoxSelecionarCredencial.BackgroundImage = global::Volta_Projeto_Taskool.Properties.Resources.user;
            this.BoxSelecionarCredencial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BoxSelecionarCredencial.Cursor = System.Windows.Forms.Cursors.Default;
            this.BoxSelecionarCredencial.Location = new System.Drawing.Point(152, 267);
            this.BoxSelecionarCredencial.Name = "BoxSelecionarCredencial";
            this.BoxSelecionarCredencial.Size = new System.Drawing.Size(90, 90);
            this.BoxSelecionarCredencial.TabIndex = 6;
            this.BoxSelecionarCredencial.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(263, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(208, 422);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(103, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Já tem conta? Login";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BordaTxtNome
            // 
            this.BordaTxtNome.BackColor = System.Drawing.SystemColors.Highlight;
            this.BordaTxtNome.Location = new System.Drawing.Point(130, 83);
            this.BordaTxtNome.Name = "BordaTxtNome";
            this.BordaTxtNome.Size = new System.Drawing.Size(295, 24);
            this.BordaTxtNome.TabIndex = 14;
            this.BordaTxtNome.TabStop = false;
            this.BordaTxtNome.Visible = false;
            // 
            // BordaTxtEmail
            // 
            this.BordaTxtEmail.BackColor = System.Drawing.SystemColors.Highlight;
            this.BordaTxtEmail.Location = new System.Drawing.Point(130, 116);
            this.BordaTxtEmail.Name = "BordaTxtEmail";
            this.BordaTxtEmail.Size = new System.Drawing.Size(295, 24);
            this.BordaTxtEmail.TabIndex = 14;
            this.BordaTxtEmail.TabStop = false;
            this.BordaTxtEmail.Visible = false;
            // 
            // BordaTxtTelefone
            // 
            this.BordaTxtTelefone.BackColor = System.Drawing.SystemColors.Highlight;
            this.BordaTxtTelefone.Location = new System.Drawing.Point(130, 146);
            this.BordaTxtTelefone.Name = "BordaTxtTelefone";
            this.BordaTxtTelefone.Size = new System.Drawing.Size(295, 24);
            this.BordaTxtTelefone.TabIndex = 14;
            this.BordaTxtTelefone.TabStop = false;
            this.BordaTxtTelefone.Visible = false;
            // 
            // BordaTxtUsuario
            // 
            this.BordaTxtUsuario.BackColor = System.Drawing.SystemColors.Highlight;
            this.BordaTxtUsuario.Location = new System.Drawing.Point(130, 180);
            this.BordaTxtUsuario.Name = "BordaTxtUsuario";
            this.BordaTxtUsuario.Size = new System.Drawing.Size(295, 24);
            this.BordaTxtUsuario.TabIndex = 14;
            this.BordaTxtUsuario.TabStop = false;
            this.BordaTxtUsuario.Visible = false;
            // 
            // btIdade
            // 
            this.btIdade.Location = new System.Drawing.Point(417, 255);
            this.btIdade.Name = "btIdade";
            this.btIdade.Size = new System.Drawing.Size(75, 23);
            this.btIdade.TabIndex = 15;
            this.btIdade.Text = "testeIdade";
            this.btIdade.UseVisualStyleBackColor = true;
            this.btIdade.Click += new System.EventHandler(this.btIdade_Click);
            // 
            // FormCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 447);
            this.Controls.Add(this.btIdade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.BordaTxtUsuario);
            this.Controls.Add(this.BordaTxtTelefone);
            this.Controls.Add(this.BordaTxtEmail);
            this.Controls.Add(this.BordaTxtNome);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxSelecionarCredencial);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btGeraAuto);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.LblDataNasc);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.LblTelefone);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.label1);
            this.Name = "FormCadastro";
            this.Text = "Cadastre-se";
            ((System.ComponentModel.ISupportInitialize)(this.BoxSelecionarCredencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtTelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BordaTxtUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblTelefone;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.Label LblDataNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Button btGeraAuto;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.PictureBox BoxSelecionarCredencial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox BordaTxtNome;
        private System.Windows.Forms.PictureBox BordaTxtEmail;
        private System.Windows.Forms.PictureBox BordaTxtTelefone;
        private System.Windows.Forms.PictureBox BordaTxtUsuario;
        private System.Windows.Forms.Button btIdade;
    }
}