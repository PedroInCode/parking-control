
namespace back_parking_control.Model;

public class Vaga
{
    private int _id;
    private int _numeroVaga;
    private ETipoVagas _tipoVaga;
    private EStatusVagas _statusVaga;

    public int Id { get => _id; set => _id = value; }
    public int NumeroVaga { get => _numeroVaga; set => _numeroVaga = value; }
    public ETipoVagas TipoVaga { get => _tipoVaga; set => _tipoVaga = value; }
    public EStatusVagas StatusVaga { get => _statusVaga; set => _statusVaga = value; }

    public Vaga(int id, int numeroVaga, ETipoVagas tipoVaga, EStatusVagas statusVaga)
    {
        Id = id;
        NumeroVaga = numeroVaga;
        TipoVaga = tipoVaga;
        StatusVaga = statusVaga;
    }

    public Vaga(int numeroVaga, ETipoVagas tipoVaga, EStatusVagas statusVaga)
    {
        NumeroVaga = numeroVaga;
        TipoVaga = tipoVaga;
        StatusVaga = statusVaga;
    }
}
