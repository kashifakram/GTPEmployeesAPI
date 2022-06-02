using Employee.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Employees.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IRepoWrapper _repoWrapper;

        public EmployeesController(IRepoWrapper repoWrapper)
        {
            _repoWrapper = repoWrapper;
        }

        [HttpGet]
        [Route("list")]
        public async Task<ActionResult<IEnumerable<Domain.Employee>>> Get()
        {
            var result = await _repoWrapper.Employee?.GetAllAsync()!;

            if (!result.Any()) return NotFound();

            return Ok(result);
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<Domain.Employee>> Post([FromBody] Domain.Employee entity)
        {
            var created = await _repoWrapper.Employee.Create(entity);
            await _repoWrapper.Save();

            return CreatedAtAction(nameof(GetEmployee), new {id = created.Id}, entity);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Employee>> GetEmployee(int id)
        {
            var entity = await _repoWrapper.Employee.FindEntity(id);

            if (entity == null)
            {
                return NotFound();
            }

            return entity;
        }

        [HttpPut("{id}")]
        [Route("modify")]
        public async Task<IActionResult> Put(int id, [FromBody] Domain.Employee entity)
        {
            if (id != entity.Id) return BadRequest();

            try
            {
                _repoWrapper.Employee.Update(entity);
                await _repoWrapper.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_repoWrapper.Employee.EntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        [Route("remove")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _repoWrapper.Employee.FindEntity(id);
            if (entity == null) return NotFound();

            _repoWrapper.Employee.Delete(entity);

            await _repoWrapper.Save();

            return NoContent();
        }
    }
}
