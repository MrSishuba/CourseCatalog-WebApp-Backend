using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using u20649232_HW01_API.Interfaces;
using u20649232_HW01_API.Models;

namespace u20649232_HW01_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        //Initalize Course Repository 
        private readonly ICourseRepository _courseRepository;

        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;

        }

        [HttpGet]
        [Route("RetrieveAllCourses")]

        public async Task<IActionResult> GetAllCourses()
        {
            try
            {
                return Ok(await _courseRepository.GetAllCourses());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpGet]
        [Route("RetrieveCourse/{courseId}")]

        public async Task<IActionResult> GetCourse(int courseId)
        {
            try 
            {
                return Ok(await _courseRepository.GetCourse(courseId));            
            }
            catch (Exception ex) 
            { 
            return BadRequest(ex.Message);
            }
        
        }

        [HttpPost]
        [Route("addCourse")]

        public async Task<IActionResult> AddCourse([FromBody] CourseListing course)
        {
            try
            {
                var response = "";
                var added = await _courseRepository.AddCourse(course);
                if (added) 
                {
                    response = "Successfully added new course";
                }
                else 
                {
                    response = "Failed to add course";
                
                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("updateCourse")]

        public async Task<IActionResult> UpdateCourse([FromBody] CourseListing course)
        {
            try
            {
                var response = "";
                var added = await _courseRepository.UpdateCourse(course);
                if (added)
                {
                    response = "Successfully updated course";
                }
                else
                {
                    response = "Failed to update course";

                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPost]
        [Route("deleteCourse/{courseId}")]
        public async Task<IActionResult> DeleteCourse(int courseId)
        {
            try
            {
                var response = "";
                var added = await _courseRepository.DeleteCourse(courseId);
                if (added)
                {
                    response = "Successfully deleted course";
                }
                else
                {
                    response = "Failed to deleted course";

                }
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    } 
}
