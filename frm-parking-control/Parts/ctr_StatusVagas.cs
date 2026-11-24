

namespace frm_parking_control.Parts
{
    public enum StatusVaga
    {
        Livre, 
        Ocupada
    }

    public partial class ctr_StatusVagas : UserControl
    {
        private StatusVaga _statusVaga;
        private string _numVaga;
        private int _idVaga;
        private Color _verdeClaro = Color.FromArgb(223, 247, 231);
        private Color _vermelhoClaro = Color.FromArgb(254, 224, 221); //

        public ctr_StatusVagas()
        {
            InitializeComponent();
        }

        private void ctr_StatusVagas_Load(object sender, EventArgs e)
        {

        }





        private void AtualizarAparenciaCard()
        {
            this.lbl_NumeroVaga.Text = this._numVaga;
            if(this._statusVaga == StatusVaga.Livre)
            {
                this.BackColor = _verdeClaro;
                this.pic_VagaStatus.Image = Properties.Resources.carIconVerde;
            }
            else
            {
                this.BackColor = _vermelhoClaro;
                this.pic_VagaStatus.Image = Properties.Resources.carIconVermlho;
            }
        }
    }
}
