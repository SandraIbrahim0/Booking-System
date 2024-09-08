using Application.Interfaces;
using Domain.Entities;
using Domain.Repoistory;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Booking_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingApiController : ControllerBase
    {
        private readonly IBookService bookService;
        public BookingApiController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        [HttpGet]
        [Produces(typeof(List<Resources>))]
        public async Task<IActionResult> GetResources()
        {
           var result = await bookService.GetResources();
            return Ok(result);
        }

    }
}
