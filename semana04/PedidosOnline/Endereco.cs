
public class Endereco
{
    private string _rua;
    private string _cidade;
    private string _estado;
    private string _pais;

    public Endereco(string rua, string cidade, string estado, string pais)
    {
        _rua = rua;
        _cidade = cidade;
        _estado = estado;
        _pais = pais;
    }

    public string GetPais()
    {
        return _pais;
    }

    public void SetRua(string rua)
    {
        _rua = rua;
    }

    public bool EhNosEUA()
    {
        return _pais == "USA" || _pais == "United States";
    }

    public string FormatarEndereco()
    {
        return _rua + "\n" +
               _cidade + "\n" +
               _estado + "\n" +
               _pais;
    }
}