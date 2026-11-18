
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
    public int Inserir(Vaga vaga)
    {
        return 1;
    }

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
                    return new Vaga(
                        reader.GetInt32("id_vaga"),
                        reader.GetInt32("numero_vaga"),
                        Enum.Parse<TipoVaga>(reader.GetString("tipo")),
                        Enum.Parse<StatusVaga>(reader.GetString("status"))
                    );
                }
            }
        }

        return null;
    }
}
