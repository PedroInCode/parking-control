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
        private ETipoVagas _tipoVaga;

        public event EventHandler CardClicado;

        private Color _verdeClaro = Color.FromArgb(223, 247, 231);
        private Color _vermelhoClaro = Color.FromArgb(254, 224, 221);

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public EStatusVagas StatusVaga { get => _statusVaga; set => _statusVaga = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string NumVaga { get => _numVaga; set => _numVaga = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int IdVaga { get => _idVaga; set => _idVaga = value; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ETipoVagas TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }

        public ctr_StatusVagas()
        {
            InitializeComponent();
        }

        private void ctr_StatusVagas_Load(object sender, EventArgs e)
        {
            AtualizarAparenciaCard();

            this.Click += AoClicarNoCard;
            this.lbl_NumeroVaga.Click += AoClicarNoCard;
            this.pic_VagaStatus.Click += AoClicarNoCard;

        }

        private void Lbl_NumeroVaga_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AoClicarNoCard(object sender, EventArgs e)
        {
            CardClicado?.Invoke(this, EventArgs.Empty);

        }



        private void AtualizarAparenciaCard()
        {
            this.lbl_NumeroVaga.Text = this.NumVaga;
            this.lbl_TipoVaga.Text = this.TipoVaga.ToString();

            // Define a cor de fundo conforme o status
            this.BackColor = this.StatusVaga switch
            {
                EStatusVagas.Livre => _verdeClaro,
                EStatusVagas.Ocupada => _vermelhoClaro,
                _ => this.BackColor
            };

            // Define o ícone conforme o tipo e status da vaga
            this.pic_VagaStatus.Image = (this.TipoVaga, this.StatusVaga) switch
            {
                (ETipoVagas.Carro, EStatusVagas.Livre) => Properties.Resources.carIconVerde,
                (ETipoVagas.Carro, EStatusVagas.Ocupada) => Properties.Resources.carIconVermlho,

                (ETipoVagas.Moto, EStatusVagas.Livre) => Properties.Resources.MotoGreen,
                (ETipoVagas.Moto, EStatusVagas.Ocupada) => Properties.Resources.MotoRed,

                (ETipoVagas.PCD, EStatusVagas.Livre) => Properties.Resources.pcdVerde,
                (ETipoVagas.PCD, EStatusVagas.Ocupada) => Properties.Resources.pcdVermelho,

                (ETipoVagas.Idoso, EStatusVagas.Livre) => Properties.Resources.idosoVerde,
                (ETipoVagas.Idoso, EStatusVagas.Ocupada) => Properties.Resources.idosoVermelho,

                _ => null
            };
        }
    }
}
