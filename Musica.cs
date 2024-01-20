class Musica
{
    public Musica(Banda artista, string nomeMusica)
    {
        Artista = artista;
        Nome = nomeMusica;
    }

    public string Nome { get; }
    public Banda Artista { get;}
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A Musica {Nome} Pertence à Banda/Artista: {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Musica: {Nome}");
        Console.WriteLine($"Banda/Artista: {Artista.NomeBanda}");
        Duracao /= 60 ;
        Console.WriteLine($"Duração de {Duracao} Minutos");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no Plano");
        } else
        {
            Console.WriteLine("Adquira o Plano+");
        }
        Console.WriteLine("\n");
    }
}
