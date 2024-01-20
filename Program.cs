//Musicas

Genero indie = new Genero("Indie");

Banda tameImpala = new Banda("Tame Impala");

Album albumTI = new Album("Currents", indie);


Musica musica1 = new Musica(tameImpala, "Let It Happen")
{
    Duracao = 482,
    Disponivel = true,
};

Musica musica2 = new Musica(tameImpala, "Eventually")
{
    Duracao = 310,
    Disponivel = false,
};


albumTI.AdicionarMusica(musica1);
albumTI.AdicionarMusica(musica2);
tameImpala.AdicionarAlbum(albumTI);


tameImpala.ExibirDiscografia();
albumTI.ExibirMusicasDoAlbum();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

Console.WriteLine("\nx--0--x\n");
//PodCast

PodCast podcat = new PodCast("Godinha", "PodCat");

Episodio racaoCastrados = new Episodio("Ração para Gatos Castrados", 37, 1);
racaoCastrados.AdicionarConvidado("Perola");
racaoCastrados.AdicionarConvidado("Frederico");

Episodio bolasDePelo = new Episodio("Bolas de Pelo", 40, 2);
bolasDePelo.AdicionarConvidado("Bola de Neve");

podcat.AdicionarEpisodio(racaoCastrados);
podcat.AdicionarEpisodio(bolasDePelo);

podcat.ExibirDetalhes();

