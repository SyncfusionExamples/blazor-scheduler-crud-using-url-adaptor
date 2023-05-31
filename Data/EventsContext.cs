using Url_Adaptor.Models;
using Microsoft.EntityFrameworkCore;

namespace Url_Adaptor.Data
{
    public class EventsContext: DbContext
    {
        public EventsContext()
        {
        }

        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
