﻿namespace ClinicaMedica.View
{
    partial class FrmFuncionarioCadastrar
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
            this.lblFuncao = new System.Windows.Forms.Label();
            this.cmbFuncao = new System.Windows.Forms.ComboBox();
            this.tBFuncaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clinicaMedicaBDDataSet = new ClinicaMedica.ClinicaMedicaBDDataSet();
            this.lblCRM = new System.Windows.Forms.Label();
            this.txbCRM = new System.Windows.Forms.TextBox();
            this.tB_FuncaoTableAdapter = new ClinicaMedica.ClinicaMedicaBDDataSetTableAdapters.TB_FuncaoTableAdapter();
            this.lblSexo = new System.Windows.Forms.Label();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.gpbContato = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCelular = new System.Windows.Forms.Label();
            this.mskTelefoneComercial = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneComercial = new System.Windows.Forms.Label();
            this.mskTelefoneResidencial = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneResidencial = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.gpbLocalidade = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblCEP = new System.Windows.Forms.Label();
            this.mskCEP = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscarCEP = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.txbComplemento = new System.Windows.Forms.TextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dtpDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.txbRG = new System.Windows.Forms.TextBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.mskCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBFuncaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).BeginInit();
            this.gpbSexo.SuspendLayout();
            this.gpbContato.SuspendLayout();
            this.gpbLocalidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(12, 195);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(46, 13);
            this.lblFuncao.TabIndex = 58;
            this.lblFuncao.Text = "Função:";
            // 
            // cmbFuncao
            // 
            this.cmbFuncao.DataSource = this.tBFuncaoBindingSource;
            this.cmbFuncao.DisplayMember = "Nome";
            this.cmbFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuncao.FormattingEnabled = true;
            this.cmbFuncao.Location = new System.Drawing.Point(149, 192);
            this.cmbFuncao.Name = "cmbFuncao";
            this.cmbFuncao.Size = new System.Drawing.Size(269, 21);
            this.cmbFuncao.TabIndex = 59;
            this.cmbFuncao.ValueMember = "IdFuncao";
            this.cmbFuncao.SelectedIndexChanged += new System.EventHandler(this.cmbFuncao_SelectedIndexChanged);
            // 
            // tBFuncaoBindingSource
            // 
            this.tBFuncaoBindingSource.DataMember = "TB_Funcao";
            this.tBFuncaoBindingSource.DataSource = this.clinicaMedicaBDDataSet;
            // 
            // clinicaMedicaBDDataSet
            // 
            this.clinicaMedicaBDDataSet.DataSetName = "ClinicaMedicaBDDataSet";
            this.clinicaMedicaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblCRM
            // 
            this.lblCRM.AutoSize = true;
            this.lblCRM.Location = new System.Drawing.Point(12, 228);
            this.lblCRM.Name = "lblCRM";
            this.lblCRM.Size = new System.Drawing.Size(34, 13);
            this.lblCRM.TabIndex = 60;
            this.lblCRM.Text = "CRM:";
            // 
            // txbCRM
            // 
            this.txbCRM.Location = new System.Drawing.Point(149, 225);
            this.txbCRM.MaxLength = 10;
            this.txbCRM.Name = "txbCRM";
            this.txbCRM.Size = new System.Drawing.Size(269, 20);
            this.txbCRM.TabIndex = 61;
            // 
            // tB_FuncaoTableAdapter
            // 
            this.tB_FuncaoTableAdapter.ClearBeforeFill = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(12, 129);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 74;
            this.lblSexo.Text = "Sexo:";
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtFeminino);
            this.gpbSexo.Controls.Add(this.rbtMasculino);
            this.gpbSexo.Location = new System.Drawing.Point(149, 124);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(269, 55);
            this.gpbSexo.TabIndex = 73;
            this.gpbSexo.TabStop = false;
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(6, 33);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 1;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Checked = true;
            this.rbtMasculino.Location = new System.Drawing.Point(6, 10);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 0;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // gpbContato
            // 
            this.gpbContato.Controls.Add(this.maskedTextBox1);
            this.gpbContato.Controls.Add(this.lblTelefoneCelular);
            this.gpbContato.Controls.Add(this.mskTelefoneComercial);
            this.gpbContato.Controls.Add(this.lblTelefoneComercial);
            this.gpbContato.Controls.Add(this.mskTelefoneResidencial);
            this.gpbContato.Controls.Add(this.lblTelefoneResidencial);
            this.gpbContato.Controls.Add(this.lblEmail);
            this.gpbContato.Controls.Add(this.txbEmail);
            this.gpbContato.Location = new System.Drawing.Point(12, 255);
            this.gpbContato.Name = "gpbContato";
            this.gpbContato.Size = new System.Drawing.Size(406, 150);
            this.gpbContato.TabIndex = 72;
            this.gpbContato.TabStop = false;
            this.gpbContato.Text = "Contato";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(134, 82);
            this.maskedTextBox1.Mask = "(99) 00000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(256, 20);
            this.maskedTextBox1.TabIndex = 31;
            // 
            // lblTelefoneCelular
            // 
            this.lblTelefoneCelular.AutoSize = true;
            this.lblTelefoneCelular.Location = new System.Drawing.Point(10, 85);
            this.lblTelefoneCelular.Name = "lblTelefoneCelular";
            this.lblTelefoneCelular.Size = new System.Drawing.Size(87, 13);
            this.lblTelefoneCelular.TabIndex = 30;
            this.lblTelefoneCelular.Text = "Telefone Celular:";
            // 
            // mskTelefoneComercial
            // 
            this.mskTelefoneComercial.Location = new System.Drawing.Point(134, 52);
            this.mskTelefoneComercial.Mask = "(99) 0000-0000";
            this.mskTelefoneComercial.Name = "mskTelefoneComercial";
            this.mskTelefoneComercial.Size = new System.Drawing.Size(256, 20);
            this.mskTelefoneComercial.TabIndex = 29;
            // 
            // lblTelefoneComercial
            // 
            this.lblTelefoneComercial.AutoSize = true;
            this.lblTelefoneComercial.Location = new System.Drawing.Point(10, 55);
            this.lblTelefoneComercial.Name = "lblTelefoneComercial";
            this.lblTelefoneComercial.Size = new System.Drawing.Size(101, 13);
            this.lblTelefoneComercial.TabIndex = 28;
            this.lblTelefoneComercial.Text = "Telefone Comercial:";
            // 
            // mskTelefoneResidencial
            // 
            this.mskTelefoneResidencial.Location = new System.Drawing.Point(134, 22);
            this.mskTelefoneResidencial.Mask = "(99) 0000-0000";
            this.mskTelefoneResidencial.Name = "mskTelefoneResidencial";
            this.mskTelefoneResidencial.Size = new System.Drawing.Size(256, 20);
            this.mskTelefoneResidencial.TabIndex = 27;
            // 
            // lblTelefoneResidencial
            // 
            this.lblTelefoneResidencial.AutoSize = true;
            this.lblTelefoneResidencial.Location = new System.Drawing.Point(10, 25);
            this.lblTelefoneResidencial.Name = "lblTelefoneResidencial";
            this.lblTelefoneResidencial.Size = new System.Drawing.Size(110, 13);
            this.lblTelefoneResidencial.TabIndex = 26;
            this.lblTelefoneResidencial.Text = "Telefone Residencial:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(10, 115);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "E-mail:";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(134, 112);
            this.txbEmail.MaxLength = 64;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(256, 20);
            this.txbEmail.TabIndex = 9;
            // 
            // gpbLocalidade
            // 
            this.gpbLocalidade.Controls.Add(this.cmbEstado);
            this.gpbLocalidade.Controls.Add(this.lblCEP);
            this.gpbLocalidade.Controls.Add(this.mskCEP);
            this.gpbLocalidade.Controls.Add(this.btnBuscarCEP);
            this.gpbLocalidade.Controls.Add(this.lblEndereco);
            this.gpbLocalidade.Controls.Add(this.txbCidade);
            this.gpbLocalidade.Controls.Add(this.txbEndereco);
            this.gpbLocalidade.Controls.Add(this.lblEstado);
            this.gpbLocalidade.Controls.Add(this.lblCidade);
            this.gpbLocalidade.Controls.Add(this.lblNumero);
            this.gpbLocalidade.Controls.Add(this.txbNumero);
            this.gpbLocalidade.Controls.Add(this.lblComplemento);
            this.gpbLocalidade.Controls.Add(this.txbComplemento);
            this.gpbLocalidade.Controls.Add(this.txbBairro);
            this.gpbLocalidade.Controls.Add(this.lblBairro);
            this.gpbLocalidade.Location = new System.Drawing.Point(12, 415);
            this.gpbLocalidade.Name = "gpbLocalidade";
            this.gpbLocalidade.Size = new System.Drawing.Size(406, 240);
            this.gpbLocalidade.TabIndex = 71;
            this.gpbLocalidade.TabStop = false;
            this.gpbLocalidade.Text = "Endereço";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA) ",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cmbEstado.Location = new System.Drawing.Point(134, 202);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(256, 21);
            this.cmbEstado.TabIndex = 26;
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(10, 25);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 10;
            this.lblCEP.Text = "CEP:";
            // 
            // mskCEP
            // 
            this.mskCEP.Location = new System.Drawing.Point(134, 22);
            this.mskCEP.Mask = "00000-999";
            this.mskCEP.Name = "mskCEP";
            this.mskCEP.Size = new System.Drawing.Size(150, 20);
            this.mskCEP.TabIndex = 11;
            this.mskCEP.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnBuscarCEP
            // 
            this.btnBuscarCEP.Location = new System.Drawing.Point(305, 20);
            this.btnBuscarCEP.Name = "btnBuscarCEP";
            this.btnBuscarCEP.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarCEP.TabIndex = 12;
            this.btnBuscarCEP.Text = "Buscar";
            this.btnBuscarCEP.UseVisualStyleBackColor = true;
            this.btnBuscarCEP.Click += new System.EventHandler(this.btnBuscarCEP_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(10, 55);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 13;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(134, 172);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(256, 20);
            this.txbCidade.TabIndex = 25;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(134, 52);
            this.txbEndereco.MaxLength = 100;
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(256, 20);
            this.txbEndereco.TabIndex = 14;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(10, 205);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 21;
            this.lblEstado.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(10, 175);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 24;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(10, 85);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(47, 13);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Número:";
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(134, 82);
            this.txbNumero.MaxLength = 6;
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(256, 20);
            this.txbNumero.TabIndex = 16;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(10, 115);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(74, 13);
            this.lblComplemento.TabIndex = 17;
            this.lblComplemento.Text = "Complemento:";
            // 
            // txbComplemento
            // 
            this.txbComplemento.Location = new System.Drawing.Point(134, 112);
            this.txbComplemento.MaxLength = 100;
            this.txbComplemento.Name = "txbComplemento";
            this.txbComplemento.Size = new System.Drawing.Size(256, 20);
            this.txbComplemento.TabIndex = 18;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(134, 142);
            this.txbBairro.MaxLength = 100;
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(256, 20);
            this.txbBairro.TabIndex = 20;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(10, 145);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 19;
            this.lblBairro.Text = "Bairro:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(173, 665);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 70;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // dtpDataNascimento
            // 
            this.dtpDataNascimento.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtpDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNascimento.Location = new System.Drawing.Point(149, 97);
            this.dtpDataNascimento.MaxDate = new System.DateTime(2017, 6, 30, 0, 0, 0, 0);
            this.dtpDataNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDataNascimento.Name = "dtpDataNascimento";
            this.dtpDataNascimento.Size = new System.Drawing.Size(269, 20);
            this.dtpDataNascimento.TabIndex = 69;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(12, 99);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(107, 13);
            this.lblDataNascimento.TabIndex = 68;
            this.lblDataNascimento.Text = "Data de Nascimento:";
            // 
            // txbRG
            // 
            this.txbRG.Location = new System.Drawing.Point(149, 66);
            this.txbRG.MaxLength = 12;
            this.txbRG.Name = "txbRG";
            this.txbRG.Size = new System.Drawing.Size(269, 20);
            this.txbRG.TabIndex = 67;
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(12, 69);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 66;
            this.lblRG.Text = "RG:";
            // 
            // mskCPF
            // 
            this.mskCPF.Location = new System.Drawing.Point(149, 36);
            this.mskCPF.Mask = "999,999,999-99";
            this.mskCPF.Name = "mskCPF";
            this.mskCPF.Size = new System.Drawing.Size(269, 20);
            this.mskCPF.TabIndex = 65;
            this.mskCPF.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(12, 39);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 64;
            this.lblCPF.Text = "CPF:";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(149, 6);
            this.txbNome.MaxLength = 100;
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(269, 20);
            this.txbNome.TabIndex = 63;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 62;
            this.lblNome.Text = "Nome:";
            // 
            // FrmFuncionarioCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 701);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.gpbContato);
            this.Controls.Add(this.gpbLocalidade);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dtpDataNascimento);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txbRG);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.mskCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbCRM);
            this.Controls.Add(this.lblCRM);
            this.Controls.Add(this.cmbFuncao);
            this.Controls.Add(this.lblFuncao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmFuncionarioCadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Funcionários";
            this.Activated += new System.EventHandler(this.FrmFuncionarioCadastrar_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.tBFuncaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clinicaMedicaBDDataSet)).EndInit();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbContato.ResumeLayout(false);
            this.gpbContato.PerformLayout();
            this.gpbLocalidade.ResumeLayout(false);
            this.gpbLocalidade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.ComboBox cmbFuncao;
        private System.Windows.Forms.Label lblCRM;
        private System.Windows.Forms.TextBox txbCRM;
        private ClinicaMedicaBDDataSet clinicaMedicaBDDataSet;
        private System.Windows.Forms.BindingSource tBFuncaoBindingSource;
        private ClinicaMedicaBDDataSetTableAdapters.TB_FuncaoTableAdapter tB_FuncaoTableAdapter;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.GroupBox gpbContato;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label lblTelefoneCelular;
        private System.Windows.Forms.MaskedTextBox mskTelefoneComercial;
        private System.Windows.Forms.Label lblTelefoneComercial;
        private System.Windows.Forms.MaskedTextBox mskTelefoneResidencial;
        private System.Windows.Forms.Label lblTelefoneResidencial;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.GroupBox gpbLocalidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskCEP;
        private System.Windows.Forms.Button btnBuscarCEP;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblComplemento;
        private System.Windows.Forms.TextBox txbComplemento;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DateTimePicker dtpDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.TextBox txbRG;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.MaskedTextBox mskCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
    }
}