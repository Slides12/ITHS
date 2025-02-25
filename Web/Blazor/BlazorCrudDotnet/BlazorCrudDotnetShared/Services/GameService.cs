using BlazorCrudDotnet.Shared.Data;
using BlazorCrudDotnet.Shared.Entities;
using Microsoft.EntityFrameworkCore;


namespace BlazorCrudDotnet.Shared.Services
{
    public class GameService : IGameService
    {
        private readonly DataContext _db;

        public GameService(DataContext db)
        {
            _db = db;
        }

        public async Task<Game> AddGame(Game game)
        {
            _db.Games.Add(game);
            await _db.SaveChangesAsync();

            return game;
        }

        public async Task<bool> DeleteGame(int id)
        {
            var dbGame =  await _db.Games.FindAsync(id);
            if (dbGame != null)
            {
                _db.Games.Remove(dbGame);
                await _db.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<Game> EditGame(int id, Game game)
        {
            var dbGame = await _db.Games.FindAsync(id);
            if (dbGame != null)
            {
                dbGame.Name = game.Name;
                await _db.SaveChangesAsync(); 
                return dbGame;
            }
            throw new Exception("Game not found");
        }

        public async Task<List<Game>> GetAllGames()
        {
            await Task.Delay(500);
            var games = await _db.Games.ToListAsync();
            return games;
        }

        public async Task<Game> GetGameById(int id)
        {
            return await _db.Games.FindAsync(id);
        }
    }
}
