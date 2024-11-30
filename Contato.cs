public class Contato
{
    public string Nome { get; set; } = string.Empty;
    public string Telefone {  get; set; } = string.Empty;
    public string Email {  get; set; } = string.Empty;

    public Contato(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }

    public override string ToString()
    {
        return $"Nome: {Nome}, Telefone: {Telefone}, Email: {Email}";
    }
}