using System.Text.Json;
using cs_consumingAPI_writingFiles_usingLINQ.Modelos;
using cs_consumingAPI_writingFiles_usingLINQ.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;


        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        ///Lin/Filter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        //var musicasPreferidasPaineli = new MusicasPreferidas("Paineli");
        //musicasPreferidasPaineli.AdicionarMusicasFavoritas(musicas[7]);
        //musicasPreferidasPaineli.AdicionarMusicasFavoritas(musicas[14]);
        //musicasPreferidasPaineli.AdicionarMusicasFavoritas(musicas[21]);
        //musicasPreferidasPaineli.AdicionarMusicasFavoritas(musicas[28]);
        //musicasPreferidasPaineli.AdicionarMusicasFavoritas(musicas[35]);

        //musicasPreferidasPaineli.ExibirMusicasFavoritas();

        var musicasPreferidasGimenes = new MusicasPreferidas("Gimenes");
        musicasPreferidasGimenes.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasGimenes.AdicionarMusicasFavoritas(musicas[12]);
        musicasPreferidasGimenes.AdicionarMusicasFavoritas(musicas[18]);
        musicasPreferidasGimenes.AdicionarMusicasFavoritas(musicas[24]);
        musicasPreferidasGimenes.AdicionarMusicasFavoritas(musicas[30]);

        musicasPreferidasGimenes.ExibirMusicasFavoritas();
        musicasPreferidasGimenes.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
