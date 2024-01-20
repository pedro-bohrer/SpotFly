class Banda
{

    private List<Album> albuns = new List<Album>();

    public Banda(string nome)
    {
        NomeBanda = nome;
    }

    public string NomeBanda { get; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {NomeBanda}:\n");
        foreach(var album in albuns)
        {
            Console.WriteLine($"Album: {album.NomeAlbum} ({album.DuracaoTotal} minutos)");
        }
        Console.WriteLine("\n--0--");
    } 
}
