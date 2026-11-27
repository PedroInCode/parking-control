using back_parking_control.Data.Repository;
using back_parking_control.Model.DTO;

namespace frm_parking_control
{
    public partial class frm_RegistrarEntrada : Form
    {
        private string numVaga;
        private int idVaga;

        public frm_RegistrarEntrada()
        {
            InitializeComponent();
        }

        public frm_RegistrarEntrada(string numVaga, int idVaga) : this()
        {
            this.numVaga = numVaga;
            this.idVaga = idVaga;
        }

        private void frm_RegistrarEntrada_Load(object sender, EventArgs e)
        {
            this.txtVagaSelecionada.Text = numVaga;
            this.txtVagaSelecionada.Enabled = false;
        }

        private void btnBuscarPorPlaca_Click(object sender, EventArgs e)
        {
            DadosEntradaVeiculo dadosVeiculo = new();
            dadosVeiculo = EntradaRepository.BuscarDadosPorPlaca(mskPlacaveiculo.Text)!;

            if (dadosVeiculo == null)
            {
                MessageBox.Show("Veiculo não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            MessageBox.Show("Veiculo encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNomeCliente.Text = dadosVeiculo.NomeCliente;
            txtCorModelo.Text = $"{dadosVeiculo.Cor} / {dadosVeiculo.Modelo}";
        }
    }
}
