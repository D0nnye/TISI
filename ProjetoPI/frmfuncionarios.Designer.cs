﻿
namespace ProjetoPI
{
    partial class frmfuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmfuncionarios));
            this.pnlParceiros = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.gpbInfoMedico = new System.Windows.Forms.GroupBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.pctlogo = new System.Windows.Forms.PictureBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lblNum = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlParceiros.SuspendLayout();
            this.gpbInfoMedico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlParceiros
            // 
            this.pnlParceiros.Controls.Add(this.btnLimpar);
            this.pnlParceiros.Controls.Add(this.btnNovo);
            this.pnlParceiros.Controls.Add(this.btnVoltar);
            this.pnlParceiros.Controls.Add(this.btnPesquisar);
            this.pnlParceiros.Controls.Add(this.btnExcluir);
            this.pnlParceiros.Controls.Add(this.btnAlterar);
            this.pnlParceiros.Controls.Add(this.btnCadastrar);
            this.pnlParceiros.Location = new System.Drawing.Point(15, 521);
            this.pnlParceiros.Name = "pnlParceiros";
            this.pnlParceiros.Size = new System.Drawing.Size(771, 86);
            this.pnlParceiros.TabIndex = 20;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(554, 18);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(96, 46);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(7, 18);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(96, 46);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(666, 18);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(96, 46);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(439, 18);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(96, 46);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(327, 18);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(96, 46);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(218, 18);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(96, 46);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(114, 18);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(96, 46);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gpbInfoMedico
            // 
            this.gpbInfoMedico.Controls.Add(this.txtCargo);
            this.gpbInfoMedico.Controls.Add(this.lblCargo);
            this.gpbInfoMedico.Controls.Add(this.pctlogo);
            this.gpbInfoMedico.Controls.Add(this.txtComplemento);
            this.gpbInfoMedico.Controls.Add(this.lblComplemento);
            this.gpbInfoMedico.Controls.Add(this.txtNum);
            this.gpbInfoMedico.Controls.Add(this.lblNum);
            this.gpbInfoMedico.Controls.Add(this.mskCEP);
            this.gpbInfoMedico.Controls.Add(this.txtCodigo);
            this.gpbInfoMedico.Controls.Add(this.mskCPF);
            this.gpbInfoMedico.Controls.Add(this.lblCPF);
            this.gpbInfoMedico.Controls.Add(this.cbbEstado);
            this.gpbInfoMedico.Controls.Add(this.lblEstado);
            this.gpbInfoMedico.Controls.Add(this.txtCidade);
            this.gpbInfoMedico.Controls.Add(this.lblCidade);
            this.gpbInfoMedico.Controls.Add(this.txtBairro);
            this.gpbInfoMedico.Controls.Add(this.lblBairro);
            this.gpbInfoMedico.Controls.Add(this.lblCEP);
            this.gpbInfoMedico.Controls.Add(this.txtEndereco);
            this.gpbInfoMedico.Controls.Add(this.lblEndereco);
            this.gpbInfoMedico.Controls.Add(this.mskTelefone);
            this.gpbInfoMedico.Controls.Add(this.lblTelefon);
            this.gpbInfoMedico.Controls.Add(this.lblCRM);
            this.gpbInfoMedico.Controls.Add(this.txtNome);
            this.gpbInfoMedico.Controls.Add(this.txtEmail);
            this.gpbInfoMedico.Controls.Add(this.lblNome);
            this.gpbInfoMedico.Controls.Add(this.lblEmail);
            this.gpbInfoMedico.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInfoMedico.Location = new System.Drawing.Point(15, 13);
            this.gpbInfoMedico.Name = "gpbInfoMedico";
            this.gpbInfoMedico.Size = new System.Drawing.Size(766, 502);
            this.gpbInfoMedico.TabIndex = 19;
            this.gpbInfoMedico.TabStop = false;
            this.gpbInfoMedico.Text = "Informações do Parceiro";
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(343, 70);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 26);
            this.txtCargo.TabIndex = 1;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(339, 44);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 18);
            this.lblCargo.TabIndex = 101;
            this.lblCargo.Text = "Cargo";
            // 
            // pctlogo
            // 
            this.pctlogo.Location = new System.Drawing.Point(10, 44);
            this.pctlogo.Name = "pctlogo";
            this.pctlogo.Size = new System.Drawing.Size(150, 145);
            this.pctlogo.TabIndex = 30;
            this.pctlogo.TabStop = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplemento.Location = new System.Drawing.Point(514, 456);
            this.txtComplemento.MaxLength = 50;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(157, 26);
            this.txtComplemento.TabIndex = 12;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplemento.Location = new System.Drawing.Point(513, 430);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(106, 18);
            this.lblComplemento.TabIndex = 112;
            this.lblComplemento.Text = "Complemento";
            // 
            // txtNum
            // 
            this.txtNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(407, 454);
            this.txtNum.MaxLength = 10;
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(91, 26);
            this.txtNum.TabIndex = 11;
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(403, 430);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(63, 18);
            this.lblNum.TabIndex = 111;
            this.lblNum.Text = "Número";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(10, 396);
            this.mskCEP.Mask = "00000-000";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(92, 26);
            this.mskCEP.TabIndex = 7;
            this.mskCEP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCEP_KeyDown);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(180, 70);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // mskCPF
            // 
            this.mskCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskCPF.Location = new System.Drawing.Point(163, 340);
            this.mskCPF.Mask = "000,000,000-00";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(122, 26);
            this.mskCPF.TabIndex = 6;
            this.mskCPF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mskCPF_KeyDown);
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(161, 316);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(41, 18);
            this.lblCPF.TabIndex = 106;
            this.lblCPF.Text = "CPF";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(163, 394);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(73, 26);
            this.cbbEstado.TabIndex = 8;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(161, 372);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(58, 18);
            this.lblEstado.TabIndex = 108;
            this.lblEstado.Text = "Estado";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCidade.Location = new System.Drawing.Point(11, 456);
            this.txtCidade.MaxLength = 50;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(132, 26);
            this.txtCidade.TabIndex = 9;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(10, 431);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 18);
            this.lblCidade.TabIndex = 109;
            this.lblCidade.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(163, 456);
            this.txtBairro.MaxLength = 50;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(215, 26);
            this.txtBairro.TabIndex = 10;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(161, 431);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 18);
            this.lblBairro.TabIndex = 110;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(10, 372);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(42, 18);
            this.lblCEP.TabIndex = 107;
            this.lblCEP.Text = "CEP";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndereco.Location = new System.Drawing.Point(10, 281);
            this.txtEndereco.MaxLength = 100;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(424, 26);
            this.txtEndereco.TabIndex = 4;
            this.txtEndereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndereco_KeyDown);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(10, 255);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(76, 18);
            this.lblEndereco.TabIndex = 104;
            this.lblEndereco.Text = "Endereço";
            // 
            // mskTelefone
            // 
            this.mskTelefone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskTelefone.Location = new System.Drawing.Point(10, 340);
            this.mskTelefone.Mask = "(00) 00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(133, 26);
            this.mskTelefone.TabIndex = 5;
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefon.Location = new System.Drawing.Point(7, 316);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(66, 18);
            this.lblTelefon.TabIndex = 105;
            this.lblTelefon.Text = "Telefone";
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCRM.Location = new System.Drawing.Point(185, 45);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(60, 18);
            this.lblCRM.TabIndex = 100;
            this.lblCRM.Text = "Código";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(180, 136);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(415, 26);
            this.txtNome.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(10, 222);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(424, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(185, 111);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 18);
            this.lblNome.TabIndex = 102;
            this.lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(10, 197);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 18);
            this.lblEmail.TabIndex = 103;
            this.lblEmail.Text = "E-mail";
            // 
            // frmfuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.pnlParceiros);
            this.Controls.Add(this.gpbInfoMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmfuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de controle Aqui Seu Lixo - Funcionarios";
            this.pnlParceiros.ResumeLayout(false);
            this.gpbInfoMedico.ResumeLayout(false);
            this.gpbInfoMedico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlParceiros;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox gpbInfoMedico;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.PictureBox pctlogo;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
    }
}