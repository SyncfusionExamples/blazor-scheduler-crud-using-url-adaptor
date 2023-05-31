using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;
using System.Collections;
using System.Text.Json;
using Url_Adaptor.Data;
using Url_Adaptor.Models;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Url_Adaptor.Controller
{
    [ApiController]
    public class DefaultController : ControllerBase
    {
        private readonly EventsContext dbContext;

        public DefaultController(EventsContext dbContext)
        {
            this.dbContext = dbContext;

            if (this.dbContext.Events.Count() == 0)
            {
                foreach (var b in DataSource.GetEvents())
                {
                    dbContext.Events.Add(b);
                }

                dbContext.SaveChanges();
            }
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult Get()
        {
            var events = dbContext.Events.ToList();
            return Ok(events);
        }


        [HttpPost]
        [Route("api/Default/Add")]
        public void Add([FromBody] CRUDModel<Event> args)
        {
            dbContext.Events.Add(args.Value);
            dbContext.SaveChangesAsync();
        }

        [HttpPost]
        [Route("api/Default/Update")]
        public async Task Update(CRUDModel<Event> args)
        {
            var entity = await dbContext.Events.FindAsync(args.Value.Id);
            if (entity != null)
            {
                dbContext.Entry(entity).CurrentValues.SetValues(args.Value);
                await dbContext.SaveChangesAsync();
            }
        }

        [HttpPost]
        [Route("api/Default/Delete")]
        public async Task Delete(CRUDModel<Event> args)
        {
            var key = Convert.ToInt32(Convert.ToString(args.Key));
            var app = dbContext.Events.Find(key);
            if (app != null)
            {
                dbContext.Events.Remove(app);
                await dbContext.SaveChangesAsync();
            }
        }

        [HttpPost]
        [Route("api/Default/Batch")]
        public async Task Batch([FromBody] CRUDModel<Event> args)
        {
            if (args.Changed.Count > 0)
            {
                foreach (Event appointment in args.Changed)
                {
                    var entity = await dbContext.Events.FindAsync(appointment.Id);
                    if (entity != null)
                    {
                        dbContext.Entry(entity).CurrentValues.SetValues(appointment);
                    }
                }
            }
            if (args.Added.Count > 0)
            {
                foreach (Event appointment in args.Added)
                {
                    dbContext.Events.Add(appointment);

                }
            }

            if (args.Deleted.Count > 0)
            {
                foreach (Event appointment in args.Deleted)
                {
                    var app = dbContext.Events.Find(appointment.Id);
                    if (app != null)
                    {
                        dbContext.Events.Remove(app);
                    }
                }
            }
            await dbContext.SaveChangesAsync();
        }
    }
}
