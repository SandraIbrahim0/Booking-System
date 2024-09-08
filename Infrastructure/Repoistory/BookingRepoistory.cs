using Domain.Entities;
using Domain.Repoistory;
using Infrastructure.Presistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repoistory
{
    public class BookingRepoistory : IBookingRepoistory
    {
        private readonly DataContext bookingDbContext;
        public BookingRepoistory(DataContext bookingDbContext)
        {
            this.bookingDbContext = bookingDbContext;
        }

        public async Task<List<Resources>> GetResources()
        {var temp = await bookingDbContext.Resources.ToListAsync();
            return temp;
        }

        public async Task BookResource(Booking booking)
        {
            await bookingDbContext.Booking.AddAsync(booking);
            await bookingDbContext.SaveChangesAsync();
        }
    }
}
