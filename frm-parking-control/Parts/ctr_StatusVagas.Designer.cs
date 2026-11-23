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
            pic_VagaDisponivel = new PictureBox();
            lbl_StatusVaga = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_VagaDisponivel).BeginInit();
            SuspendLayout();
            // 
            // pic_VagaDisponivel
            // 
            pic_VagaDisponivel.Image = Properties.Resources.carIconVerde;
            pic_VagaDisponivel.Location = new Point(47, 66);
            pic_VagaDisponivel.Margin = new Padding(4, 4, 4, 4);
            pic_VagaDisponivel.Name = "pic_VagaDisponivel";
            pic_VagaDisponivel.Size = new Size(50, 50);
            pic_VagaDisponivel.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_VagaDisponivel.TabIndex = 0;
            pic_VagaDisponivel.TabStop = false;
            // 
            // lbl_StatusVaga
            // 
            lbl_StatusVaga.AutoSize = true;
            lbl_StatusVaga.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_StatusVaga.Location = new Point(44, 38);
            lbl_StatusVaga.Margin = new Padding(4, 0, 4, 0);
            lbl_StatusVaga.Name = "lbl_StatusVaga";
            lbl_StatusVaga.Size = new Size(57, 19);
            lbl_StatusVaga.TabIndex = 1;
            lbl_StatusVaga.Text = "LIVRE";
            // 
            // ctr_StatusVagas
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(223, 247, 231);
            Controls.Add(lbl_StatusVaga);
            Controls.Add(pic_VagaDisponivel);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "ctr_StatusVagas";
            ((System.ComponentModel.ISupportInitialize)pic_VagaDisponivel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_VagaDisponivel;
        private Label lbl_StatusVaga;
    }
}
