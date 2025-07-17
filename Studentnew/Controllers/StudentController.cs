using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Studentnew.Data;
using Studentnew.Models;

namespace Studentnew.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : Controller
    {
        StudentDBContext _context;
        public StudentController(StudentDBContext context) {
            _context = context;
        }
        [HttpGet("{id}")]
        public IActionResult get(int id)
        {
            var s = _context.students.Find(id);
            if (s != null)
            {

                return Ok(s);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult delete(int id) {
            var s = _context.students.Find(id);
            if (s != null)
            {
                _context.students.Remove(s);
                _context.SaveChanges();
                return Ok();
            }
            else { 
                return NotFound();
            }
        }
        [HttpGet]
        public IActionResult getall() { 
            return Ok(_context.students.ToList());
        }

        [HttpPost]
        public IActionResult post(Student s) {
            if (s != null) { 
                _context.students.Add(s);
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut()]
        public IActionResult update(Student s)
        {
            if (s != null)
            {
                _context.students.Update(s);
                _context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
