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
            this.txtVagaSelecionada.Text = numVaga.ToString();
        }


    }
}
