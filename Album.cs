class Album
{
    private List<Musica> musicas = new List<Musica>();

    public Album(string nomeAlbum, Genero genero)
    {
        NomeAlbum = nomeAlbum;
        Genero = genero;
    }

    public string NomeAlbum { get; }
    public Genero Genero { get; }

    public int DuracaoTotal => (musicas.Sum(m => m.Duracao)) / 60;

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }


    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de Musicas do {NomeAlbum}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }
        Console.WriteLine("\n--0--");
        Console.WriteLine($"Album do Gênero {Genero.GeneroMusical}");
        Console.WriteLine($"A duração total de {NomeAlbum} é de {DuracaoTotal} minutos");
    }
}

