
using back_parking_control.Model;
using MySqlConnector;
using System.Data;

namespace back_parking_control.Data.Repository;

public class VagaRepository
{
    /// <summary>
    /// Insere uma vaga no banco de dados
    /// </summary>
    /// <param name="vaga"></param>
    /// <returns></returns>
    public static int Inserir(Vaga vaga)
    {
        return 1;
    }

    /// <summary>
    /// Busca uma vaga especifica pelo id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public Vaga? BuscarPorId(int id)
    {
        using (var cmd = new MySqlCommand("sp_buscarVagaPorId"))
        {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@p_id", id);

            using (var reader = Banco.ExecutarConsulta(cmd))
            {
                if (reader.Read())
                {
                    return MapearVaga(reader);
                }
            }
        }

        return null;
    }

    /// <summary>
    /// Função que retorna todas as vagas cadastradas
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public IEnumerable<Vaga> BuscarTodas()
    {
        List<Vaga> vagas = new List<Vaga>();

        using (var cmd = new MySqlCommand("sp_listarTodasVagas"))
        {
            cmd.CommandType = CommandType.StoredProcedure;

            using (var reader = Banco.ExecutarConsulta(cmd))
            {
                while (reader.Read())
                {
                    vagas.Add(MapearVaga(reader));
                }
            }
        }

        return vagas;
    }

    private Vaga MapearVaga(MySqlDataReader reader)
    {
        int id_vaga = reader.GetInt32("id_vaga");
        int numero_vaga = reader.GetInt32("numero_vaga");
        TipoVaga tipoVaga = Enum.Parse<TipoVaga>(reader.GetString("tipo"));
        StatusVaga statusVaga = Enum.Parse<StatusVaga>(reader.GetString("status"));

        return new Vaga(id_vaga, numero_vaga, tipoVaga, statusVaga);
    }
}
