using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NeilCummingsDatingApp.API.Data;
using NeilCummingsDatingApp.API.Models;

namespace NeilCummingsDatingApp.API.Controllers
{
    [ApiController]
    [Route("values")]
    public class ValuesController
    {
        private readonly ILogger<Values> _logger;
        private readonly DataContext _context;

        public ValuesController(ILogger<Values> logger, DataContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Values>> Get()
        {
            return await _context.Values.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Values> GetValue(int id)
        {
            return await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
