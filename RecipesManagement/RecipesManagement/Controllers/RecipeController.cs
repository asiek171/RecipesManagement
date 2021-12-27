using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesManagement.Controllers
{
    [Route("api/recipe")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        /// <summary>
        /// Get all recipes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> Get()
        {
            return NotFound();
        }


        /// <summary>
        /// Get recipe by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> Get(int id)
        {
            return NotFound();
        }

        /// <summary>
        /// Get recipes by userId(author)
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{userId}/list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> GetByUserId(int userId)
        {
            return NotFound();
        }

        /// <summary>
        /// Get recipes by tag
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("tag")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> GetByTag(string tag)
        {
            return NotFound();
        }

        /// <summary>
        /// Get recipes by filter
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        [HttpGet("filter")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> GetByFilter(string filter)
        {
            return NotFound();
        }

        /// <summary>
        /// Get recipes by rating
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("rated")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> GetByRating(string filter)
        {
            return NotFound();

        }
        /// <summary>
        /// Create new recipe 
        /// </summary>
        /// <returns></returns>
        [HttpPost("{userId}/create")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> Post()//[FromBody] RecipeDto model)
        {
            return NotFound();
        }

        /// <summary>
        /// Update only some part of typed recipe
        /// </summary>
        /// <returns></returns>
        [HttpPatch("{userId}/update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> Patch()//[FromBody] RecipeDto model)
        {
            return NotFound();
        }

        /// <summary>
        /// Remove recipe from service (inactivate)
        /// </summary>
        /// <returns></returns>
        [HttpPost("{userId}/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> Delete([FromBody] int id)
        {
            return NotFound();
        }


        /// <summary>
        /// Add resource to recipe (eg. photo)
        /// </summary>
        /// <returns></returns>
        [HttpPost("{id}/resource")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> AddResource()//[FromBody] ResoutceDto resource
        {
            return NotFound();
        }

        /// <summary>
        /// Add rate to recipe
        /// </summary>
        /// <returns></returns>
        [HttpPost("{Id}/rate")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> PostRate()//[FromBody] RateDto model
        {
            return NotFound();
        }


        /// <summary>
        /// Add comment to recipe 
        /// </summary>
        /// <returns></returns>
        [HttpPost("{Id}/comment")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        public async Task<ActionResult> PostComment()//[FromBody] int id
        {
            return NotFound();
        }
    }
}
