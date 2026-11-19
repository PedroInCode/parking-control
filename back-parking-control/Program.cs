
using back_parking_control.Data;
using back_parking_control.Data.Repository;
using back_parking_control.Model;

namespace backUrbanPark;

public class Program
{
    public static void Main(string[] args)
    {
        VagaRepository vagaRepository = new VagaRepository();
        Vaga vaga1 = vagaRepository.BuscarPorId(1);

        Console.WriteLine($"ID: {vaga1.Id}");
        Console.WriteLine($"Número: {vaga1.NumeroVaga}");
        Console.WriteLine($"Tipo: {vaga1.TipoVaga}");
        Console.WriteLine($"Status: {vaga1.StatusVaga}");
    }
}
