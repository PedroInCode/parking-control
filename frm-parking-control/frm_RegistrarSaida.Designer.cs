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
            pnlCabecalho = new Panel();
            panel2 = new Panel();
            grpBuscarVeiculo = new GroupBox();
            lblPlacaVeiculo = new Label();
            mskPlacaveiculo = new MaskedTextBox();
            button1 = new Button();
            grpDadosVeiculo = new GroupBox();
            lblCliente = new Label();
            lblCorModelo = new Label();
            lblVaga = new Label();
            txtNumeroVaga = new TextBox();
            txtCorModelo = new TextBox();
            txtNomeCliente = new TextBox();
            grpMovimentacao = new GroupBox();
            lblDataHoraEntrada = new Label();
            txtDtHoraEntrada = new TextBox();
            lblDataSaida = new Label();
            lblHoraSaida = new Label();
            dtInfoDtSaida = new DateTimePicker();
            dtInfoHrSaida = new DateTimePicker();
            grpCalculo = new GroupBox();
            lblTempoPermanencia = new Label();
            lblTarifaVigente = new Label();
            txtInfoTempoPermanencia = new TextBox();
            txtInfoTarifa = new TextBox();
            lblValorPagar = new Label();
            txtValorAPagar = new TextBox();
            btnRegistrarSaida = new Button();
            btnCancelar = new Button();
            panel2.SuspendLayout();
            grpBuscarVeiculo.SuspendLayout();
            grpDadosVeiculo.SuspendLayout();
            grpMovimentacao.SuspendLayout();
            grpCalculo.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCabecalho
            // 
            pnlCabecalho.BackColor = Color.FromArgb(5, 31, 71);
            pnlCabecalho.Dock = DockStyle.Top;
            pnlCabecalho.Location = new Point(0, 0);
            pnlCabecalho.Margin = new Padding(4, 4, 4, 4);
            pnlCabecalho.Name = "pnlCabecalho";
            pnlCabecalho.Size = new Size(1050, 83);
            pnlCabecalho.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnRegistrarSaida);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 562);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1050, 89);
            panel2.TabIndex = 1;
            // 
            // grpBuscarVeiculo
            // 
            grpBuscarVeiculo.Controls.Add(button1);
            grpBuscarVeiculo.Controls.Add(mskPlacaveiculo);
            grpBuscarVeiculo.Controls.Add(lblPlacaVeiculo);
            grpBuscarVeiculo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpBuscarVeiculo.ForeColor = Color.FromArgb(5, 31, 71);
            grpBuscarVeiculo.Location = new Point(17, 91);
            grpBuscarVeiculo.Margin = new Padding(4, 4, 4, 4);
            grpBuscarVeiculo.Name = "grpBuscarVeiculo";
            grpBuscarVeiculo.Padding = new Padding(4, 4, 4, 4);
            grpBuscarVeiculo.Size = new Size(1016, 111);
            grpBuscarVeiculo.TabIndex = 2;
            grpBuscarVeiculo.TabStop = false;
            grpBuscarVeiculo.Text = "Buscar Veículo";
            // 
            // lblPlacaVeiculo
            // 
            lblPlacaVeiculo.AutoSize = true;
            lblPlacaVeiculo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPlacaVeiculo.ForeColor = Color.Black;
            lblPlacaVeiculo.Location = new Point(45, 57);
            lblPlacaVeiculo.Margin = new Padding(4, 0, 4, 0);
            lblPlacaVeiculo.Name = "lblPlacaVeiculo";
            lblPlacaVeiculo.Size = new Size(158, 22);
            lblPlacaVeiculo.TabIndex = 0;
            lblPlacaVeiculo.Text = "Placa do Veículo:";
            // 
            // mskPlacaveiculo
            // 
            mskPlacaveiculo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskPlacaveiculo.Location = new Point(247, 57);
            mskPlacaveiculo.Margin = new Padding(4, 4, 4, 4);
            mskPlacaveiculo.Name = "mskPlacaveiculo";
            mskPlacaveiculo.Size = new Size(304, 29);
            mskPlacaveiculo.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(585, 57);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 31);
            button1.TabIndex = 2;
            button1.Text = "Buscar Por Placa";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
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
            grpDadosVeiculo.Location = new Point(17, 210);
            grpDadosVeiculo.Margin = new Padding(4, 4, 4, 4);
            grpDadosVeiculo.Name = "grpDadosVeiculo";
            grpDadosVeiculo.Padding = new Padding(4, 4, 4, 4);
            grpDadosVeiculo.Size = new Size(448, 335);
            grpDadosVeiculo.TabIndex = 3;
            grpDadosVeiculo.TabStop = false;
            grpDadosVeiculo.Text = "Dados do Veículo";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Location = new Point(17, 57);
            lblCliente.Margin = new Padding(4, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(74, 22);
            lblCliente.TabIndex = 0;
            lblCliente.Text = "Cliente:";
            // 
            // lblCorModelo
            // 
            lblCorModelo.AutoSize = true;
            lblCorModelo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorModelo.ForeColor = Color.Black;
            lblCorModelo.Location = new Point(17, 96);
            lblCorModelo.Margin = new Padding(4, 0, 4, 0);
            lblCorModelo.Name = "lblCorModelo";
            lblCorModelo.Size = new Size(124, 22);
            lblCorModelo.TabIndex = 1;
            lblCorModelo.Text = "Cor / Modelo:";
            // 
            // lblVaga
            // 
            lblVaga.AutoSize = true;
            lblVaga.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVaga.ForeColor = Color.Black;
            lblVaga.Location = new Point(17, 140);
            lblVaga.Margin = new Padding(4, 0, 4, 0);
            lblVaga.Name = "lblVaga";
            lblVaga.Size = new Size(58, 22);
            lblVaga.TabIndex = 2;
            lblVaga.Text = "Vaga:";
            // 
            // txtNumeroVaga
            // 
            txtNumeroVaga.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumeroVaga.Location = new Point(140, 137);
            txtNumeroVaga.Margin = new Padding(4, 4, 4, 4);
            txtNumeroVaga.Name = "txtNumeroVaga";
            txtNumeroVaga.Size = new Size(260, 29);
            txtNumeroVaga.TabIndex = 3;
            // 
            // txtCorModelo
            // 
            txtCorModelo.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCorModelo.Location = new Point(140, 91);
            txtCorModelo.Margin = new Padding(4, 4, 4, 4);
            txtCorModelo.Name = "txtCorModelo";
            txtCorModelo.Size = new Size(260, 29);
            txtCorModelo.TabIndex = 4;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNomeCliente.Location = new Point(140, 50);
            txtNomeCliente.Margin = new Padding(4, 4, 4, 4);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.Size = new Size(260, 29);
            txtNomeCliente.TabIndex = 5;
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
            grpMovimentacao.Location = new Point(494, 210);
            grpMovimentacao.Margin = new Padding(4, 4, 4, 4);
            grpMovimentacao.Name = "grpMovimentacao";
            grpMovimentacao.Padding = new Padding(4, 4, 4, 4);
            grpMovimentacao.Size = new Size(539, 153);
            grpMovimentacao.TabIndex = 4;
            grpMovimentacao.TabStop = false;
            grpMovimentacao.Text = "Movimentação";
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
            // txtDtHoraEntrada
            // 
            txtDtHoraEntrada.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDtHoraEntrada.Location = new Point(232, 30);
            txtDtHoraEntrada.Margin = new Padding(4, 4, 4, 4);
            txtDtHoraEntrada.Name = "txtDtHoraEntrada";
            txtDtHoraEntrada.Size = new Size(284, 29);
            txtDtHoraEntrada.TabIndex = 1;
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
            // dtInfoDtSaida
            // 
            dtInfoDtSaida.CustomFormat = "HH:mm";
            dtInfoDtSaida.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoDtSaida.Format = DateTimePickerFormat.Short;
            dtInfoDtSaida.Location = new Point(232, 76);
            dtInfoDtSaida.Margin = new Padding(4, 4, 4, 4);
            dtInfoDtSaida.Name = "dtInfoDtSaida";
            dtInfoDtSaida.Size = new Size(284, 29);
            dtInfoDtSaida.TabIndex = 4;
            // 
            // dtInfoHrSaida
            // 
            dtInfoHrSaida.CustomFormat = "HH:mm";
            dtInfoHrSaida.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtInfoHrSaida.Format = DateTimePickerFormat.Custom;
            dtInfoHrSaida.Location = new Point(232, 113);
            dtInfoHrSaida.Margin = new Padding(4, 4, 4, 4);
            dtInfoHrSaida.Name = "dtInfoHrSaida";
            dtInfoHrSaida.Size = new Size(284, 29);
            dtInfoHrSaida.TabIndex = 5;
            // 
            // grpCalculo
            // 
            grpCalculo.Controls.Add(txtValorAPagar);
            grpCalculo.Controls.Add(lblValorPagar);
            grpCalculo.Controls.Add(txtInfoTarifa);
            grpCalculo.Controls.Add(txtInfoTempoPermanencia);
            grpCalculo.Controls.Add(lblTarifaVigente);
            grpCalculo.Controls.Add(lblTempoPermanencia);
            grpCalculo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpCalculo.ForeColor = Color.FromArgb(5, 31, 71);
            grpCalculo.Location = new Point(494, 371);
            grpCalculo.Margin = new Padding(4, 4, 4, 4);
            grpCalculo.Name = "grpCalculo";
            grpCalculo.Padding = new Padding(4, 4, 4, 4);
            grpCalculo.Size = new Size(539, 174);
            grpCalculo.TabIndex = 5;
            grpCalculo.TabStop = false;
            grpCalculo.Text = "Cálculo do Estacionamento";
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
            // txtInfoTempoPermanencia
            // 
            txtInfoTempoPermanencia.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInfoTempoPermanencia.Location = new Point(243, 38);
            txtInfoTempoPermanencia.Margin = new Padding(4, 4, 4, 4);
            txtInfoTempoPermanencia.Name = "txtInfoTempoPermanencia";
            txtInfoTempoPermanencia.Size = new Size(273, 29);
            txtInfoTempoPermanencia.TabIndex = 2;
            // 
            // txtInfoTarifa
            // 
            txtInfoTarifa.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInfoTarifa.Location = new Point(243, 75);
            txtInfoTarifa.Margin = new Padding(4, 4, 4, 4);
            txtInfoTarifa.Name = "txtInfoTarifa";
            txtInfoTarifa.Size = new Size(273, 29);
            txtInfoTarifa.TabIndex = 3;
            // 
            // lblValorPagar
            // 
            lblValorPagar.AutoSize = true;
            lblValorPagar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValorPagar.ForeColor = Color.Black;
            lblValorPagar.Location = new Point(25, 124);
            lblValorPagar.Margin = new Padding(4, 0, 4, 0);
            lblValorPagar.Name = "lblValorPagar";
            lblValorPagar.Size = new Size(248, 22);
            lblValorPagar.TabIndex = 4;
            lblValorPagar.Text = "Valor a Pagar:                   R$";
            // 
            // txtValorAPagar
            // 
            txtValorAPagar.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtValorAPagar.Location = new Point(281, 121);
            txtValorAPagar.Margin = new Padding(4, 4, 4, 4);
            txtValorAPagar.Name = "txtValorAPagar";
            txtValorAPagar.Size = new Size(235, 29);
            txtValorAPagar.TabIndex = 5;
            // 
            // btnRegistrarSaida
            // 
            btnRegistrarSaida.Location = new Point(626, 26);
            btnRegistrarSaida.Margin = new Padding(4, 4, 4, 4);
            btnRegistrarSaida.Name = "btnRegistrarSaida";
            btnRegistrarSaida.Size = new Size(155, 39);
            btnRegistrarSaida.TabIndex = 0;
            btnRegistrarSaida.Text = "Registrar Saída";
            btnRegistrarSaida.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(812, 26);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 39);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "frm_RegistrarSaida";
            Text = "frm_RegistrarSaida";
            panel2.ResumeLayout(false);
            grpBuscarVeiculo.ResumeLayout(false);
            grpBuscarVeiculo.PerformLayout();
            grpDadosVeiculo.ResumeLayout(false);
            grpDadosVeiculo.PerformLayout();
            grpMovimentacao.ResumeLayout(false);
            grpMovimentacao.PerformLayout();
            grpCalculo.ResumeLayout(false);
            grpCalculo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCabecalho;
        private Panel panel2;
        private GroupBox grpBuscarVeiculo;
        private Label lblPlacaVeiculo;
        private MaskedTextBox mskPlacaveiculo;
        private Button button1;
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
        private TextBox txtValorAPagar;
        private Button btnRegistrarSaida;
        private Button btnCancelar;
    }
}