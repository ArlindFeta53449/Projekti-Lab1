using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
    /*
    E perdorim BaseApiController ne menyre qe mos te
    perseritet kodi i njejt i:
    [ApiController]
    [Route("[controller]")]
    dhe derivimi nga ControllerBase
    meqenese perdoren ne secilin controller qe do te 
    krijojme.
    */
    public class StudentetController : BaseApiController
    {
        public readonly DataContext _context;
        public StudentetController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Studenti>>> GetStudentet(){
            return await _context.Studentet.ToListAsync();
        }
        //useri merr nje student te caktuar sipas id
        [HttpGet("{id}")] 
        public async Task<ActionResult<Studenti>> GetStudentetAsync(Guid id){
            return await _context.Studentet.FindAsync(id);
        }
    }
}