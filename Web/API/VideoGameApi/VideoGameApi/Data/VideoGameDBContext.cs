using Microsoft.EntityFrameworkCore;

namespace VideoGameApi.Data;

public class VideoGameDBContext(DbContextOptions<VideoGameDBContext> options) : DbContext(options)
{
    public DbSet<VideoGame> VideoGames { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<VideoGame>().HasData(
            new VideoGame()
            {
                Id = 1,
                Title = "Spider-man 2",
                Platform = "PS5",
                Developer = "Insomniac Games",
                Publisher = "Sony Interactive Entertainment"
            },
            new VideoGame()
            {
                Id = 2,
                Title = "The Legend of Zelda: Breat of the Wild.",
                Platform = "Nintendo Switch",
                Developer = "Nintendo EPD",
                Publisher = "Nintendo"
            },
            new VideoGame()
            {
                Id = 3,
                Title = "Cyberpunk 2077",
                Platform = "PC",
                Developer = "CD Project Red",
                Publisher = "CD Project"
            }
            );
    }
}
