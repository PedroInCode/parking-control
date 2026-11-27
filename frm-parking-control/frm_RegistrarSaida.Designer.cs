namespace frm_parking_control
{
    partial class frm_RegistrarSaida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RegistrarSaida));
            pnlCabecalho = new Panel();
            lbl_Subtitulo2 = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnRegistrarSaida = new Button();
            grpBuscarVeiculo = new GroupBox();
            btnBuscarPorPlaca = new Button();
            mskPlacaveiculo = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            grpDadosVeiculo = new GroupBox();
            txtNomeCliente = new TextBox();
            txtCorModelo = new TextBox();
            txtNumeroVaga = new TextBox();
            lblVaga = new Label();
            lblCorModelo = new Label();
            lblCliente = new Label();
            grpMovimentacao = new GroupBox();
            dtInfoHrSaida = new DateTimePicker();
            dtInfoDtSaida = new DateTimePicker();
            lblHoraSaida = new Label();
            lblDataSaida = new Label();
            txtDtHoraEntrada = new TextBox();
            lblDataHoraEntrada = new Label();
            grpCalculo = new GroupBox();
            panel1 = new Panel();
            lblValorAPagar = new Label();
            lbl_rs = new Label();
            lblValorPagar = new Label();
            txtInfoTarifa = new TextBox();
            txtInfoTempoPermanencia = new TextBox();
            lblTarifaVigente = new Label();
            lblTempoPermanencia = new Label();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            panel2.SuspendLayout();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpCalculo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(5, 31, 71);
            pnlCabecalho.Controls.Add(lbl_Subtitulo2);
            pnlCabecalho.Controls.Add(lblSubtitulo);
            pnlCabecalho.Controls.Add(lblTitulo);
            pnlCabecalho.Controls.Add(picLogo);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Margin = new Padding(4);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1050, 91);
            pnlCabecalho.TabIndex = 0;
            // 
            // lbl_Subtitulo2
            // 
            lbl_Subtitulo2.AutoSize = true;
            lbl_Subtitulo2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subtitulo2.ForeColor = Color.White;
            lbl_Subtitulo2.Location = new Point(417, 46);
            lbl_Subtitulo2.Name = "lbl_Subtitulo2";
            lbl_Subtitulo2.Size = new Size(343, 24);
            lbl_Subtitulo2.TabIndex = 4;
            lbl_Subtitulo2.Text = "Finaliza a movimentação do veículo";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(417, 11);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(190, 33);
            lblSubtitulo.TabIndex = 3;
            lblSubtitulo.Text = "Registrar Saída";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(122, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 56);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "UrbanPark |";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.iconePark;
            picLogo.Location = new Point(17, -5);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 96);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnRegistrarSaida);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 572);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 79);
            panel2.TabIndex = 1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(218, 218, 218);
            btnCancelar.FlatAppearance.BorderColor = Color.Silver;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.Image = Properties.Resources.iconClose;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(911, 36);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.BackColor = Color.FromArgb(39, 133, 43);
            btnRegistrarSaida.FlatStyle = FlatStyle.Flat;
            btnRegistrarSaida.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarSaida.ForeColor = Color.White;
            btnRegistrarSaida.Image = Properties.Resources.iconCheck;
            btnRegistrarSaida.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarSaida.Location = new Point(723, 36);
            btnRegistrarSaida.Margin = new Padding(4);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(180, 31);
            btnRegistrarSaida.TabIndex = 0;
            btnRegistrarSaida.Text = "Registrar Saída";
            btnRegistrarSaida.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarSaida.UseVisualStyleBackColor = false;
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.FromArgb(5, 31, 71);
            grpBuscarVeiculo.Location = new Point(17, 119);
            grpBuscarVeiculo.Margin = new Padding(4);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Padding = new Padding(4);
            grpBuscarVeiculo.Size = new Size(1016, 98);
            grpBuscarVeiculo.TabIndex = 2;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // btnBuscarPorPlaca
            // 
            btnBuscarPorPlaca.BackColor = Color.FromArgb(5, 31, 71);
            btnBuscarPorPlaca.FlatAppearance.BorderColor = Color.Silver;
            btnBuscarPorPlaca.FlatStyle = FlatStyle.Flat;
            btnBuscarPorPlaca.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscarPorPlaca.ForeColor = Color.White;
            btnBuscarPorPlaca.Location = new Point(317, 39);
            btnBuscarPorPlaca.Margin = new Padding(4);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(196, 31);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "🔍 Buscar Por Placa";
            btnBuscarPorPlaca.TextAlign = ContentAlignment.MiddleLeft;
            btnBuscarPorPlaca.UseVisualStyleBackColor = false;
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskPlacaveiculo.Location = new Point(209, 40);
            mskPlacaveiculo.Margin = new Padding(4);
            mskPlacaveiculo.Mask = "AAA-0000";
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(100, 29);
            mskPlacaveiculo.TabIndex = 1;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(43, 43);
            lblPlacaVeiculo.Margin = new Padding(4, 0, 4, 0);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(158, 22);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(txtNumeroVaga);
            grpDadosVeiculo.Controls.Add(lblVaga);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = Color.FromArgb(5, 31, 71);
            grpDadosVeiculo.Location = new Point(17, 225);
            grpDadosVeiculo.Margin = new Padding(4);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Padding = new Padding(4);
            grpDadosVeiculo.Size = new Size(448, 335);
            grpDadosVeiculo.TabIndex = 3;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(139, 37);
            txtNomeCliente.Margin = new Padding(4);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(260, 29);
            txtNomeCliente.TabIndex = 5;
            // 
            // txtCorModelo
            // 
            txtCorModelo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorModelo.Location = new Point(139, 78);
            txtCorModelo.Margin = new Padding(4);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(260, 29);
            txtCorModelo.TabIndex = 4;
            // 
            // txtNumeroVaga
            // 
            txtNumeroVaga.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroVaga.Location = new Point(139, 124);
            txtNumeroVaga.Margin = new Padding(4);
            txtNumeroVaga.Name = "txtNumeroVaga";
            txtNumeroVaga.Size = new Size(260, 29);
            txtNumeroVaga.TabIndex = 3;
            // 
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVaga.ForeColor = Color.Black;
            lblVaga.Location = new Point(16, 127);
            lblVaga.Margin = new Padding(4, 0, 4, 0);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(58, 22);
            lblVaga.TabIndex = 2;
            lblVaga.Text = "Vaga:";
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(16, 83);
            lblCorModelo.Margin = new Padding(4, 0, 4, 0);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(124, 22);
            lblCorModelo.TabIndex = 1;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(16, 44);
            lblCliente.Margin = new Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(74, 22);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // grpMovimentacao
            // 
            grpMovimentacao.Controls.Add(dtInfoHrSaida);
            grpMovimentacao.Controls.Add(dtInfoDtSaida);
            grpMovimentacao.Controls.Add(lblHoraSaida);
            grpMovimentacao.Controls.Add(lblDataSaida);
            grpMovimentacao.Controls.Add(txtDtHoraEntrada);
            grpMovimentacao.Controls.Add(lblDataHoraEntrada);
            grpMovimentacao.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMovimentacao.ForeColor = Color.FromArgb(5, 31, 71);
            grpMovimentacao.Location = new Point(494, 225);
            grpMovimentacao.Margin = new Padding(4);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Padding = new Padding(4);
            grpMovimentacao.Size = new Size(539, 153);
            grpMovimentacao.TabIndex = 4;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
            // 
            // dtInfoHrSaida
            // 
            dtInfoHrSaida.CustomFormat = "HH:mm";
            dtInfoHrSaida.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoHrSaida.Format = DateTimePickerFormat.Custom;
            dtInfoHrSaida.Location = new Point(232, 113);
            dtInfoHrSaida.Margin = new Padding(4);
            dtInfoHrSaida.Name = "dtInfoHrSaida";
            dtInfoHrSaida.ShowUpDown = true;
            dtInfoHrSaida.Size = new Size(284, 29);
            dtInfoHrSaida.TabIndex = 5;
            // 
            // dtInfoDtSaida
            // 
            dtInfoDtSaida.CustomFormat = "HH:mm";
            dtInfoDtSaida.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtSaida.Format = DateTimePickerFormat.Short;
            dtInfoDtSaida.Location = new Point(232, 76);
            dtInfoDtSaida.Margin = new Padding(4);
            dtInfoDtSaida.Name = "dtInfoDtSaida";
            dtInfoDtSaida.Size = new Size(284, 29);
            dtInfoDtSaida.TabIndex = 4;
            // 
            // lblHoraSaida
            // 
            lblHoraSaida.AutoSize = true;
            lblHoraSaida.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraSaida.ForeColor = Color.Black;
            lblHoraSaida.Location = new Point(18, 120);
            lblHoraSaida.Margin = new Padding(4, 0, 4, 0);
            lblHoraSaida.Name = "lblHoraSaida";
            lblHoraSaida.Size = new Size(137, 22);
            lblHoraSaida.TabIndex = 3;
            lblHoraSaida.Text = "Hora de Saída:";
            // 
            // lblDataSaida
            // 
            lblDataSaida.AutoSize = true;
            lblDataSaida.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataSaida.ForeColor = Color.Black;
            lblDataSaida.Location = new Point(18, 76);
            lblDataSaida.Margin = new Padding(4, 0, 4, 0);
            lblDataSaida.Name = "lblDataSaida";
            lblDataSaida.Size = new Size(136, 22);
            lblDataSaida.TabIndex = 2;
            lblDataSaida.Text = "Data de Saída:";
            // 
            // txtDtHoraEntrada
            // 
            txtDtHoraEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDtHoraEntrada.Location = new Point(232, 30);
            txtDtHoraEntrada.Margin = new Padding(4);
            txtDtHoraEntrada.Name = "txtDtHoraEntrada";
            txtDtHoraEntrada.Size = new Size(284, 29);
            txtDtHoraEntrada.TabIndex = 1;
            // 
            // lblDataHoraEntrada
            // 
            lblDataHoraEntrada.AutoSize = true;
            lblDataHoraEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataHoraEntrada.ForeColor = Color.Black;
            lblDataHoraEntrada.Location = new Point(18, 37);
            lblDataHoraEntrada.Margin = new Padding(4, 0, 4, 0);
            lblDataHoraEntrada.Name = "lblDataHoraEntrada";
            lblDataHoraEntrada.Size = new Size(206, 22);
            lblDataHoraEntrada.TabIndex = 0;
            lblDataHoraEntrada.Text = "Data / Hora de Entrada:";
            // 
            // grpCalculo
            // 
            grpCalculo.Controls.Add(panel1);
            grpCalculo.Controls.Add(txtInfoTarifa);
            grpCalculo.Controls.Add(txtInfoTempoPermanencia);
            grpCalculo.Controls.Add(lblTarifaVigente);
            grpCalculo.Controls.Add(lblTempoPermanencia);
            grpCalculo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCalculo.ForeColor = Color.FromArgb(5, 31, 71);
            grpCalculo.Location = new Point(494, 386);
            grpCalculo.Margin = new Padding(4);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Padding = new Padding(4);
            grpCalculo.Size = new Size(539, 174);
            grpCalculo.TabIndex = 5;
            grpCalculo.TabStop = false;
            grpCalculo.Text = "Cálculo do Estacionamento";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(223, 247, 231);
            panel1.Controls.Add(lblValorAPagar);
            panel1.Controls.Add(lbl_rs);
            panel1.Controls.Add(lblValorPagar);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(24, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 46);
            panel1.TabIndex = 6;
            // 
            // lblValorAPagar
            // 
            lblValorAPagar.AutoSize = true;
            lblValorAPagar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorAPagar.ForeColor = Color.Black;
            lblValorAPagar.Location = new Point(417, 12);
            lblValorAPagar.Name = "lblValorAPagar";
            lblValorAPagar.Size = new Size(59, 22);
            lblValorAPagar.TabIndex = 6;
            lblValorAPagar.Text = "00,00";
            // 
            // lbl_rs
            // 
            lbl_rs.AutoSize = true;
            lbl_rs.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_rs.ForeColor = Color.Black;
            lbl_rs.Location = new Point(367, 12);
            lbl_rs.Name = "lbl_rs";
            lbl_rs.Size = new Size(34, 22);
            lbl_rs.TabIndex = 5;
            lbl_rs.Text = "R$";
            // 
            // lblValorPagar
            // 
            lblValorPagar.AutoSize = true;
            lblValorPagar.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValorPagar.ForeColor = Color.Black;
            lblValorPagar.Location = new Point(15, 12);
            lblValorPagar.Margin = new Padding(4, 0, 4, 0);
            lblValorPagar.Name = "lblValorPagar";
            lblValorPagar.Size = new Size(141, 22);
            lblValorPagar.TabIndex = 4;
            lblValorPagar.Text = "Valor a Pagar:";
            // 
            // txtInfoTarifa
            // 
            txtInfoTarifa.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInfoTarifa.Location = new Point(243, 75);
            txtInfoTarifa.Margin = new Padding(4);
            txtInfoTarifa.Name = "txtInfoTarifa";
            txtInfoTarifa.Size = new Size(273, 29);
            txtInfoTarifa.TabIndex = 3;
            // 
            // txtInfoTempoPermanencia
            // 
            txtInfoTempoPermanencia.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInfoTempoPermanencia.Location = new Point(243, 38);
            txtInfoTempoPermanencia.Margin = new Padding(4);
            txtInfoTempoPermanencia.Name = "txtInfoTempoPermanencia";
            txtInfoTempoPermanencia.Size = new Size(273, 29);
            txtInfoTempoPermanencia.TabIndex = 2;
            // 
            // lblTarifaVigente
            // 
            lblTarifaVigente.AutoSize = true;
            lblTarifaVigente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTarifaVigente.ForeColor = Color.Black;
            lblTarifaVigente.Location = new Point(18, 78);
            lblTarifaVigente.Margin = new Padding(4, 0, 4, 0);
            lblTarifaVigente.Name = "lblTarifaVigente";
            lblTarifaVigente.Size = new Size(131, 22);
            lblTarifaVigente.TabIndex = 1;
            lblTarifaVigente.Text = "Tarifa Vigente:";
            // 
            // lblTempoPermanencia
            // 
            lblTempoPermanencia.AutoSize = true;
            lblTempoPermanencia.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTempoPermanencia.ForeColor = Color.Black;
            lblTempoPermanencia.Location = new Point(18, 41);
            lblTempoPermanencia.Margin = new Padding(4, 0, 4, 0);
            lblTempoPermanencia.Name = "lblTempoPermanencia";
            lblTempoPermanencia.Size = new Size(217, 22);
            lblTempoPermanencia.TabIndex = 0;
            lblTempoPermanencia.Text = "Tempo de Permanência:";
            // 
            // frm_RegistrarSaida
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 651);
            Controls.Add(grpCalculo);
            Controls.Add(grpMovimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(panel2);
            Controls.Add(pnlCabecalho);
            Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frm_RegistrarSaida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrbanPark | Registrar Saída";
            Load += frm_RegistrarSaida_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            panel2.ResumeLayout(false);
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpCalculo.ResumeLayout(false);
            grpCalculo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Panel panel2;
        private GroupBox grpBuscarVeiculo;
        private Label lblPlacaVeiculo;
        private MaskedTextBox mskPlacaveiculo;
        private Button btnBuscarPorPlaca;
        private GroupBox grpDadosVeiculo;
        private Label lblCliente;
        private Label lblCorModelo;
        private Label lblVaga;
        private TextBox txtNumeroVaga;
        private TextBox txtCorModelo;
        private TextBox txtNomeCliente;
        private GroupBox grpMovimentacao;
        private Label lblDataHoraEntrada;
        private TextBox txtDtHoraEntrada;
        private Label lblDataSaida;
        private Label lblHoraSaida;
        private DateTimePicker dtInfoDtSaida;
        private DateTimePicker dtInfoHrSaida;
        private GroupBox grpCalculo;
        private Label lblTempoPermanencia;
        private Label lblTarifaVigente;
        private TextBox txtInfoTempoPermanencia;
        private TextBox txtInfoTarifa;
        private Label lblValorPagar;
        private Button btnRegistrarSaida;
        private Button btnCancelar;
        private Panel panel1;
        private Label lbl_rs;
        private Label lblValorAPagar;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lbl_Subtitulo2;
    }
}