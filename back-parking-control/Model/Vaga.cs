
namespace back_parking_control.Model;

public class Vaga
{
    private int _id;
    private string _numeroVaga;
    private TipoVaga _tipoVaga;
    private StatusVaga _statusVaga;

    public int Id { get => _id; set => _id = value; }
    public string NumeroVaga { get => _numeroVaga; set => _numeroVaga = value; }
    public TipoVaga TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }
    public StatusVaga StatusVaga { get => _statusVaga; set => _statusVaga = value; }

    public Vaga(int id, string numeroVaga, TipoVaga tipoVaga, StatusVaga statusVaga)
    {
        Id = id;
        NumeroVaga = numeroVaga;
        TipoVaga = tipoVaga;
        StatusVaga = statusVaga;
    }

    public Vaga(string numeroVaga, TipoVaga tipoVaga, StatusVaga statusVaga)
    {
        NumeroVaga = numeroVaga;
        TipoVaga = tipoVaga;
        StatusVaga = statusVaga;
    }
}
