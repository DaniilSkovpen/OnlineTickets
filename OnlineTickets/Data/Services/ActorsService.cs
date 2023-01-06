using Microsoft.EntityFrameworkCore;
using OnlineTickets.Data.Base;
using OnlineTickets.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDBContext context) : base(context) {}
    }
}
