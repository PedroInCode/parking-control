
using back_parking_control.Data;
using back_parking_control.Data.Repository;
using back_parking_control.Model;

namespace backUrbanPark;

public class Program
{
    public static void Main(string[] args)
    {
        //VagaRepository vagaRepository = new VagaRepository();
        //Vaga vaga1 = vagaRepository.BuscarPorId(1);

        //Console.WriteLine($"ID: {vaga1.Id}");
        //Console.WriteLine($"Número: {vaga1.NumeroVaga}");
        //Console.WriteLine($"Tipo: {vaga1.TipoVaga}");
        //Console.WriteLine($"Status: {vaga1.StatusVaga}");

        VagaRepository repositories = new VagaRepository();
        IEnumerable<Vaga> vagas = repositories.BuscarTodas();

        foreach(var vaga in vagas)
        {
            Console.WriteLine($"ID: {vaga.Id}");
            Console.WriteLine($"Número: {vaga.NumeroVaga}");
            Console.WriteLine($"Tipo: {vaga.TipoVaga}");
            Console.WriteLine($"Status: {vaga.StatusVaga}");
            Console.WriteLine("------------------------------");
        }
    }
}
