using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Services;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : ControllerBase
    {

        private readonly ILogger<BookController> _logger;

        // Declaration of the service used
        private IBookService _bookService;

        // Injection of an instance of IBookService
        // when creating an instance of BookController
        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        // Maps GET requests to https://localhost:{port}/api/book
        // Get no parameters for FindAll -> Search All
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_bookService.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/book/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var book = _bookService.FindByID(id);
            if (book == null) return NotFound();
            return Ok(book);
        }

        // Maps POST requests to https://localhost:{port}/api/book/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        public IActionResult Post([FromBody] BookVO book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookService.Create(book));
        }

        // Maps PUT requests to https://localhost:{port}/api/book/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        public IActionResult Put([FromBody] BookVO book)
        {
            if (book == null) return BadRequest();
            return Ok(_bookService.Update(book));
        }

        // Maps DELETE requests to https://localhost:{port}/api/book/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _bookService.Delete(id);
            return NoContent();
        }
    }
}
