public class PodCast
{
    private List<Episodio> episodios = new();

    public PodCast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }
    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"PodCast {Nome} Apresentado por {Host}");
        Console.WriteLine("--0--");
        Console.WriteLine($"Lista de Episodios ({TotalEpisodios})");

        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }
    }
}


