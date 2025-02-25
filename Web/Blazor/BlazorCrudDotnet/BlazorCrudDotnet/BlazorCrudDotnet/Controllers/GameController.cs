using BlazorCrudDotnet.Shared.Entities;
using BlazorCrudDotnet.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorCrudDotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService gameService;

        public GameController(IGameService gameService)
        {
            this.gameService = gameService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Game>> GetGaneById(int id)
        {
            var game = await gameService.GetGameById(id);
            return Ok(game);
        }

        [HttpPost]
        public async Task<ActionResult<Game>> AddGames(Game game)
        {
            var addedGame = await gameService.AddGame(game);
            return Ok(addedGame);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult<Game>> EditGames(int id ,Game game)
        {
            var updatedGame = await gameService.EditGame(id, game);
            return Ok(updatedGame);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Game>> DeleteGames(int id)
        {
            var result = await gameService.DeleteGame(id);
            return Ok(result);
        }

    }
}
