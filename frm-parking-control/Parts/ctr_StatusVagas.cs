using back_parking_control;
using back_parking_control.Model;
using System.ComponentModel;



namespace frm_parking_control.Parts
{

    public partial class ctr_StatusVagas : UserControl
    {
        private EStatusVagas _statusVaga;
        private string _numVaga;
        private int _idVaga;
        private TipoVaga _tipoVaga;

        private Color _verdeClaro = Color.FromArgb(223, 247, 231);
        private Color _vermelhoClaro = Color.FromArgb(254, 224, 221);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EStatusVagas StatusVaga { get => _statusVaga; set => _statusVaga = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumVaga { get => _numVaga; set => _numVaga = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdVaga { get => _idVaga; set => _idVaga = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public TipoVaga TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }

        public ctr_StatusVagas()
        {
            InitializeComponent();
        }

        private void ctr_StatusVagas_Load(object sender, EventArgs e)
        {
            AtualizarAparenciaCard();
        }





        private void AtualizarAparenciaCard()
        {
            this.lbl_NumeroVaga.Text = this.NumVaga;
            this.lbl_TipoVaga.Text = this.TipoVaga.ToString();
            if (this.StatusVaga == EStatusVagas.Livre)
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
