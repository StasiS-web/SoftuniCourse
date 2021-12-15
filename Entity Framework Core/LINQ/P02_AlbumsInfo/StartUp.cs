namespace MusicHub
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using Data;
    using Initializer;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);

            //Test your solutions here

            //Console.WriteLine("Databse created!!!");

            Console.WriteLine(ExportAlbumsInfo(context, 9));

            //Console.WriteLine(ExportSongsAboveDuration(context, 4));
        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            var albumsInfo = context.Producers
                 .FirstOrDefault(p => p.Id == producerId)
                 .Albums
                 .Select(p => new
                 {
                     AlbumName = p.Name,
                     ReleaseDate = p.ReleaseDate,
                     ProducerName = p.Producer.Name,
                     Songs = p.Songs
                          .Select(s => new
                          {
                              SongName = s.Name,
                              Price = s.Price,
                              Writer = s.Writer.Name
                          })
                          .OrderByDescending(s => s.SongName)
                          .ThenBy(s => s.Writer)
                          .ToList(),
                     totalAlbumPrice = p.Price
                 })
                 .OrderByDescending(a => a.totalAlbumPrice)
                 .ToList();

            var sb = new StringBuilder();

            foreach (var album in albumsInfo)
            {
                sb
                    .AppendLine($"-AlbumName: {album.AlbumName}")
                    .AppendLine($"-ReleaseDate: {album.ReleaseDate.ToString("MM/dd/yyyy")}")
                    .AppendLine($"-ProducerName: {album.ProducerName}")
                    .AppendLine("-Songs:");

                int count = 1;
                foreach (var song in album.Songs)
                {
                    sb
                      .AppendLine($"---#{count++}")
                      .AppendLine($"---SongName: {song.SongName}")
                      .AppendLine($"---Price: {song.Price:F2}")
                      .AppendLine($"---Writer: {song.Writer}");
                }

                sb.AppendLine($"-AlbumPrice: {album.totalAlbumPrice:F2}");
            }

            return sb.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            var songsExtract = context.Songs
                    .AsEnumerable()
                    .Where(s => s.Duration.TotalSeconds > duration)
                    .Select(s => new
                    {
                        SongName = s.Name,
                        WriterName = s.Writer.Name,
                        PerformerFullName = s.SongPerformers
                                 .Select(sp => $"{sp.Performer.FirstName} {sp.Performer.LastName}")
                                 .FirstOrDefault(),
                        ProducerName = s.Album.Producer.Name,
                        Duration = s.Duration
                    })
                    .OrderBy(s => s.SongName)
                    .ThenBy(s => s.WriterName)
                    .ThenBy(s => s.PerformerFullName)
                    .ToList();

            var sb = new StringBuilder();

            int songCounter = 1;

            foreach (var song in songsExtract)
            {
                sb
                    .AppendLine($"-Song #{songCounter++}")
                    .AppendLine($"---SongName: {song.SongName}")
                    .AppendLine($"---Writer: {song.WriterName}")
                    .AppendLine($"---Performer: {song.PerformerFullName}")
                    .AppendLine($"---AlbumProducer: {song.ProducerName}")
                    .AppendLine($"---Duration: {song.Duration}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
