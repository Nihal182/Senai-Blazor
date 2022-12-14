using Newtonsoft.Json;

namespace voeairlines_blazor.Data;
public class Usuario
{
    
    [JsonProperty("Nome")]
    public string? Nome { get; set; }

    private string? senha1;

    public string? GetSenha1()
    {
        return senha1;
    }

    public void SetSenha1(string? value)
    {
        senha1 = value;
    }

    [JsonProperty("DataCriacao")]
    public DateTime DataCriacao { get ; set; }

    [JsonProperty("DataAtual")]
     public DateTime DataAtual { get; set; } = DateTime.Now;

}