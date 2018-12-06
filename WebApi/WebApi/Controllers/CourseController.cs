using System.Collections.Generic;
using BusinessLayer.BusinessContract;
using BusinessLayer.BusinessDto;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [EnableCors("CorsPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseAppService courseAppService;

        public CourseController(ICourseAppService courseAppService)
        {
            this.courseAppService = courseAppService;
        }

        // GET: api/Course
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Course/5
        [HttpGet("{name}", Name = "Get")]
        public string Get(string name)
        {
            this.courseAppService.Add(new CourseDto(name));

            return "K";
           
        }

        // POST: api/Course
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Course/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
