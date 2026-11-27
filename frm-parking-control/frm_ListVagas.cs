using back_parking_control;
using back_parking_control.Data.Repository;
using back_parking_control.Model;
using frm_parking_control.Parts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frm_parking_control
{
    public partial class frm_ListVagas : Form
    {
        public frm_ListVagas()
        {
            InitializeComponent();
        }

        private void frm_ListVagas_Load(object sender, EventArgs e)
        {
            CarregarDadosEMontarVisualizacao();
        }

        private void CarregarDadosEMontarVisualizacao()
        {
            IEnumerable<Vaga> listaVagas = VagaRepository.BuscarTodas();

            flw_CardVagas.Controls.Clear();

            foreach(var vaga in listaVagas)
            {
                string strNumeroVaga = vaga.NumeroVaga.ToString();
                EStatusVagas statusVaga = Enum.Parse<EStatusVagas>(vaga.StatusVaga.ToString());
                int idVaga = vaga.Id;
                ETipoVagas tipoVaga = Enum.Parse<ETipoVagas>(vaga.TipoVaga.ToString());
                
                ctr_StatusVagas cardVaga = new();

                cardVaga.IdVaga = idVaga;
                cardVaga.StatusVaga = statusVaga;
                cardVaga.NumVaga = strNumeroVaga;
                cardVaga.TipoVaga = tipoVaga;

                cardVaga.CardClicado += cardVaga_Click;

                flw_CardVagas.Controls.Add(cardVaga);
            }
        }

        public void cardVaga_Click(object sender, EventArgs e)
        {
            ctr_StatusVagas cardSelecionado = (ctr_StatusVagas)sender;

            if(cardSelecionado.StatusVaga == EStatusVagas.Livre)
            {
                frm_RegistrarEntrada frmRegistrarEntrada = new frm_RegistrarEntrada();
                frmRegistrarEntrada.ShowDialog();
            }
            else
            {
                frm_RegistrarSaida frmRegistrarSaida = new frm_RegistrarSaida();
                frmRegistrarSaida.ShowDialog();
            }
        }
    }
}
