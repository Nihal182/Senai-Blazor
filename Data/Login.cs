using Newtonsoft.Json;

namespace voeairlines_blazor.Data;

public class Login
{
    public Login(string? usuario, string? senha, DateTime dataCriacao)
    {
        Usuario = usuario;
        Senha = senha;
        DataCriacao = dataCriacao;
    }
    [JsonProperty("Id")]
    public int Id { get; set; }
    [JsonProperty ("Usuario")]
    public string? Usuario { get; set; }

    [JsonProperty ("Senha")]
    public string? Senha { get; set; }

    [JsonProperty ("DataCriacao")]
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}