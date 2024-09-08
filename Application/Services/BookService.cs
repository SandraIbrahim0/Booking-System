using Application.Interfaces;
using Domain.Entities;
using Domain.Repoistory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookingRepoistory bookingRepoistory;
        public BookService(IBookingRepoistory bookingRepoistory)
        {
            this.bookingRepoistory = bookingRepoistory;
        }
        public Task<List<Resources>> GetResources()
        {
            return bookingRepoistory.GetResources();
        }
    }
}
