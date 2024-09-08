using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repoistory
{
    public interface IBookingRepoistory
    {
        Task<List<Resources>> GetResources();
        Task BookResource(Booking booking);
    }
}
