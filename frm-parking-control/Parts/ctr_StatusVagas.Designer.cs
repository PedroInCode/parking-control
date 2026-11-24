namespace frm_parking_control.Parts
{
    partial class ctr_StatusVagas
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            pic_VagaStatus = new PictureBox();
            lbl_NumeroVaga = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_VagaStatus).BeginInit();
            SuspendLayout();
            // 
            // pic_VagaStatus
            // 
            pic_VagaStatus.Image = Properties.Resources.carIconVerde;
            pic_VagaStatus.Location = new Point(43, 63);
            pic_VagaStatus.Margin = new Padding(4);
            pic_VagaStatus.Name = "pic_VagaStatus";
            pic_VagaStatus.Size = new Size(61, 59);
            pic_VagaStatus.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_VagaStatus.TabIndex = 0;
            pic_VagaStatus.TabStop = false;
            // 
            // lbl_NumeroVaga
            // 
            lbl_NumeroVaga.AutoSize = true;
            lbl_NumeroVaga.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NumeroVaga.Location = new Point(51, 27);
            lbl_NumeroVaga.Margin = new Padding(4, 0, 4, 0);
            lbl_NumeroVaga.Name = "lbl_NumeroVaga";
            lbl_NumeroVaga.Size = new Size(44, 32);
            lbl_NumeroVaga.TabIndex = 1;
            lbl_NumeroVaga.Text = "01";
            // 
            // ctr_StatusVagas
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 247, 231);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lbl_NumeroVaga);
            Controls.Add(pic_VagaStatus);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "ctr_StatusVagas";
            Size = new Size(148, 148);
            Load += ctr_StatusVagas_Load;
            ((System.ComponentModel.ISupportInitialize)pic_VagaStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_VagaStatus;
        private Label lbl_NumeroVaga;
    }
}
