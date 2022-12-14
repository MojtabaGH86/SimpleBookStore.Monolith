using BookStore.Application.Contract.Books.Queries;
using Common.Api;
using Common.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Admin.Api.Controllers
{
    public class BookCategoriesQueryController : MainController
    {
        private readonly IQueryBus _bus;

        public BookCategoriesQueryController(IQueryBus bus)
        {
            _bus = bus;
        }

        [HttpGet("{id}/[action]")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(BookCategoryQueryModel))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        public async Task<ActionResult<BookCategoryQueryModel>> Get(
            [FromRoute] int id)
        {
            var query = new GetBookCategoryByIdQuery
            {
                Id = id
            };

            var category =
                await _bus.Dispatch<GetBookCategoryByIdQuery, BookCategoryQueryModel?>(query);

            return Ok(category);
        }
    }
}
