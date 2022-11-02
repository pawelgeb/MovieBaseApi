using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieBaseApi.Data;
using MovieBaseApi.Models;

namespace MovieBaseApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        readonly MovieContext _context;
        public ActorController(MovieContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ActorDTO>>> GetActorsDTO()
        {
            return await _context.Actors
                .Select(p => ActorDTO(p))
                .ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ActorDTO>> GetActorDTOitem(int id)
        {
            var actorItem = await _context.Actors.FindAsync(id);
            if (actorItem == null)
            {
                return NotFound();
            }
            return ActorDTO(actorItem);
        }
        [HttpPost]
        public async Task<ActionResult<ActorDTO>> CreateActorItem(ActorDTO actorDTO)
        {
            var actorItem = new Actor
            {
            ActorId = actorDTO.ActorId,
            FirstName = actorDTO.FirstName,
            LastName = actorDTO.LastName,
            BirthDate = actorDTO.BirthDate,
           Nationality = actorDTO.Nationality
        };
            _context.Actors.Add(actorItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetActorsDTO),
                new { id = actorDTO.ActorId },
                ActorDTO(actorItem));
        }

        private bool ActorItemExist(int id)
        {
            return _context.Actors.Any(e => e.ActorId == id);
        }
        private static ActorDTO ActorDTO(Actor actor) => new ActorDTO
        {
            ActorId = actor.ActorId,
            FirstName = actor.FirstName,
            LastName = actor.LastName,
            BirthDate = actor.BirthDate,
            Nationality = actor.Nationality
        };
    }
}
