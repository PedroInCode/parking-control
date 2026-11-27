namespace frm_parking_control
{
    partial class frm_RegistrarEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RegistrarEntrada));
            pnlCabecalho = new Panel();
            lbl_Subtitulo2 = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            picLogo = new PictureBox();
            grpBuscarVeiculo = new GroupBox();
            btnBuscarPorPlaca = new Button();
            mskPlacaveiculo = new MaskedTextBox();
            lblPlacaVeiculo = new Label();
            grpDadosVeiculo = new GroupBox();
            txtCorModelo = new TextBox();
            txtNomeCliente = new TextBox();
            lblCorModelo = new Label();
            lblCliente = new Label();
            gpb_Movimentacao = new GroupBox();
            dtInfoHrEntrada = new DateTimePicker();
            dtInfoDtEntrada = new DateTimePicker();
            lblHoraEntrada = new Label();
            txtVagaSelecionada = new TextBox();
            lblDataEntrada = new Label();
            lblVagaSelecionada = new Label();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnRegistrarEntrada = new Button();
            pnlCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            gpb_Movimentacao.SuspendLayout();
            panel2.SuspendLayout();
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
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1050, 95);
            pnlCabecalho.TabIndex = 0;
            // 
            // lbl_Subtitulo2
            // 
            lbl_Subtitulo2.AutoSize = true;
            lbl_Subtitulo2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Subtitulo2.ForeColor = Color.White;
            lbl_Subtitulo2.Location = new Point(420, 51);
            lbl_Subtitulo2.Name = "lbl_Subtitulo2";
            lbl_Subtitulo2.Size = new Size(322, 24);
            lbl_Subtitulo2.TabIndex = 3;
            lbl_Subtitulo2.Text = "Inicia a movimentação do veículo";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Font = new Font("Arial Narrow", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.White;
            lblSubtitulo.Location = new Point(420, 19);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(215, 33);
            lblSubtitulo.TabIndex = 2;
            lblSubtitulo.Text = "Registrar Entrada";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(120, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(294, 56);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "UrbanPark |";
            // 
            // picLogo
            // 
            picLogo.BackColor = Color.Transparent;
            picLogo.Image = Properties.Resources.iconePark;
            picLogo.Location = new Point(14, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(100, 95);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(btnBuscarPorPlaca);
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.FromArgb(5, 31, 71);
            grpBuscarVeiculo.Location = new Point(14, 126);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Size = new Size(1024, 124);
            grpBuscarVeiculo.TabIndex = 1;
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
            btnBuscarPorPlaca.Location = new Point(355, 53);
            btnBuscarPorPlaca.Name = "btnBuscarPorPlaca";
            btnBuscarPorPlaca.Size = new Size(194, 33);
            btnBuscarPorPlaca.TabIndex = 2;
            btnBuscarPorPlaca.Text = "🔍 Buscar por Placa";
            btnBuscarPorPlaca.UseVisualStyleBackColor = false;
            btnBuscarPorPlaca.Click += btnBuscarPorPlaca_Click;
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskPlacaveiculo.Location = new Point(230, 55);
            mskPlacaveiculo.Mask = "AAAAAAA";
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(103, 29);
            mskPlacaveiculo.TabIndex = 1;
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(57, 58);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(158, 22);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // grpDadosVeiculo
            // 
            grpDadosVeiculo.Controls.Add(txtCorModelo);
            grpDadosVeiculo.Controls.Add(txtNomeCliente);
            grpDadosVeiculo.Controls.Add(lblCorModelo);
            grpDadosVeiculo.Controls.Add(lblCliente);
            grpDadosVeiculo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpDadosVeiculo.ForeColor = Color.FromArgb(5, 31, 71);
            grpDadosVeiculo.Location = new Point(14, 271);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Size = new Size(465, 281);
            grpDadosVeiculo.TabIndex = 2;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // txtCorModelo
            // 
            txtCorModelo.BorderStyle = BorderStyle.FixedSingle;
            txtCorModelo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorModelo.Location = new Point(187, 82);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(213, 29);
            txtCorModelo.TabIndex = 4;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.BorderStyle = BorderStyle.FixedSingle;
            txtNomeCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(187, 42);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(213, 29);
            txtNomeCliente.TabIndex = 3;
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(57, 85);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(124, 22);
            lblCorModelo.TabIndex = 2;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(57, 45);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(74, 22);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // gpb_Movimentacao
            // 
            gpb_Movimentacao.Controls.Add(dtInfoHrEntrada);
            gpb_Movimentacao.Controls.Add(dtInfoDtEntrada);
            gpb_Movimentacao.Controls.Add(lblHoraEntrada);
            gpb_Movimentacao.Controls.Add(txtVagaSelecionada);
            gpb_Movimentacao.Controls.Add(lblDataEntrada);
            gpb_Movimentacao.Controls.Add(lblVagaSelecionada);
            gpb_Movimentacao.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpb_Movimentacao.ForeColor = Color.FromArgb(5, 31, 71);
            gpb_Movimentacao.Location = new Point(509, 271);
            gpb_Movimentacao.Name = "gpb_Movimentacao";
            gpb_Movimentacao.Size = new Size(529, 281);
            gpb_Movimentacao.TabIndex = 3;
            gpb_Movimentacao.TabStop = false;
            gpb_Movimentacao.Text = "Movimentações";
            // 
            // dtInfoHrEntrada
            // 
            dtInfoHrEntrada.CustomFormat = "HH:mm";
            dtInfoHrEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoHrEntrada.Format = DateTimePickerFormat.Custom;
            dtInfoHrEntrada.Location = new Point(238, 118);
            dtInfoHrEntrada.Name = "dtInfoHrEntrada";
            dtInfoHrEntrada.Size = new Size(224, 29);
            dtInfoHrEntrada.TabIndex = 5;
            // 
            // dtInfoDtEntrada
            // 
            dtInfoDtEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtEntrada.Format = DateTimePickerFormat.Short;
            dtInfoDtEntrada.Location = new Point(238, 80);
            dtInfoDtEntrada.Name = "dtInfoDtEntrada";
            dtInfoDtEntrada.Size = new Size(224, 29);
            dtInfoDtEntrada.TabIndex = 4;
            // 
            // lblHoraEntrada
            // 
            lblHoraEntrada.AutoSize = true;
            lblHoraEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHoraEntrada.ForeColor = Color.Black;
            lblHoraEntrada.Location = new Point(26, 124);
            lblHoraEntrada.Name = "lblHoraEntrada";
            lblHoraEntrada.Size = new Size(152, 22);
            lblHoraEntrada.TabIndex = 3;
            lblHoraEntrada.Text = "Hora de Entrada:";
            // 
            // txtVagaSelecionada
            // 
            txtVagaSelecionada.BorderStyle = BorderStyle.FixedSingle;
            txtVagaSelecionada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVagaSelecionada.ForeColor = Color.Black;
            txtVagaSelecionada.Location = new Point(238, 41);
            txtVagaSelecionada.Name = "txtVagaSelecionada";
            txtVagaSelecionada.Size = new Size(224, 29);
            txtVagaSelecionada.TabIndex = 2;
            // 
            // lblDataEntrada
            // 
            lblDataEntrada.AutoSize = true;
            lblDataEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDataEntrada.ForeColor = Color.Black;
            lblDataEntrada.Location = new Point(26, 86);
            lblDataEntrada.Name = "lblDataEntrada";
            lblDataEntrada.Size = new Size(151, 22);
            lblDataEntrada.TabIndex = 1;
            lblDataEntrada.Text = "Data de Entrada:";
            // 
            // lblVagaSelecionada
            // 
            lblVagaSelecionada.AutoSize = true;
            lblVagaSelecionada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVagaSelecionada.ForeColor = Color.Black;
            lblVagaSelecionada.Location = new Point(26, 45);
            lblVagaSelecionada.Name = "lblVagaSelecionada";
            lblVagaSelecionada.Size = new Size(168, 22);
            lblVagaSelecionada.TabIndex = 0;
            lblVagaSelecionada.Text = "Vaga Selecionada:";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnRegistrarEntrada);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 574);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 77);
            panel2.TabIndex = 4;
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
            btnCancelar.Location = new Point(914, 33);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 32);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarEntrada
            // 
            btnRegistrarEntrada.BackColor = Color.FromArgb(39, 133, 43);
            btnRegistrarEntrada.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnRegistrarEntrada.FlatStyle = FlatStyle.Flat;
            btnRegistrarEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrarEntrada.ForeColor = Color.White;
            btnRegistrarEntrada.Image = Properties.Resources.iconCheck;
            btnRegistrarEntrada.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegistrarEntrada.Location = new Point(706, 33);
            btnRegistrarEntrada.Name = "btnRegistrarEntrada";
            btnRegistrarEntrada.Size = new Size(193, 32);
            btnRegistrarEntrada.TabIndex = 0;
            btnRegistrarEntrada.Text = "Registrar Entrada";
            btnRegistrarEntrada.TextAlign = ContentAlignment.MiddleRight;
            btnRegistrarEntrada.UseVisualStyleBackColor = false;
            // 
            // frm_RegistrarEntrada
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 651);
            Controls.Add(panel2);
            Controls.Add(gpb_Movimentacao);
            Controls.Add(grpDadosVeiculo);
            Controls.Add(grpBuscarVeiculo);
            Controls.Add(pnlCabecalho);
            Font = new Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 5, 3, 5);
            Name = "frm_RegistrarEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrbanPark | Registrar Entrada";
            Load += frm_RegistrarEntrada_Load;
            pnlCabecalho.ResumeLayout(false);
            pnlCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            gpb_Movimentacao.ResumeLayout(false);
            gpb_Movimentacao.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private GroupBox grpBuscarVeiculo;
        private GroupBox grpDadosVeiculo;
        private GroupBox gpb_Movimentacao;
        private Panel panel2;
        private Label lblPlacaVeiculo;
        private MaskedTextBox mskPlacaveiculo;
        private Button btnBuscarPorPlaca;
        private Label lblCliente;
        private Label lblCorModelo;
        private TextBox txtNomeCliente;
        private TextBox txtCorModelo;
        private Label lblVagaSelecionada;
        private Label lblDataEntrada;
        private TextBox txtVagaSelecionada;
        private Label lblHoraEntrada;
        private DateTimePicker dtInfoDtEntrada;
        private DateTimePicker dtInfoHrEntrada;
        private Button btnRegistrarEntrada;
        private Button btnCancelar;
        private PictureBox picLogo;
        private Label lblTitulo;
        private Label lblSubtitulo;
        private Label lbl_Subtitulo2;
    }
}
