public class Episodio
{ 
    private List<string> convidados = new();

    public Episodio(string titulo, int duracao, int ordem)
    {
        Titulo = titulo;
        Duracao = duracao;
        Ordem = ordem;
    }
    public string Titulo { get; }
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"Episdio #{Ordem} {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";

    public void AdicionarConvidado(string convidado)
    {
        convidados.Add(convidado);
    }
}


