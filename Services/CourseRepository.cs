using Microsoft.EntityFrameworkCore;
using u20649232_HW01_API.Data;
using u20649232_HW01_API.Interfaces;
using u20649232_HW01_API.Models;

namespace u20649232_HW01_API.Services
{
    public class CourseRepository : ICourseRepository
    {
        //Initalize Course Repository
        private readonly AppDBContext _appDB;

        public CourseRepository(AppDBContext _appDBContext)
        {
            _appDB = _appDBContext;

        }     
        public async Task<bool> AddCourse(CourseListing course) 
        {
            try 
            {
                 await _appDB.courseListings.AddAsync(course);
                await _appDB.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return false;
            
            }
            return true;

        }
        public async  Task<List<CourseListing>> GetAllCourses() 
        {
            return await _appDB.courseListings.ToListAsync();
        }
        public async Task<CourseListing> GetCourse(int courseId) 
        {
                    
               return await _appDB.courseListings.Where(c => c.courseId == courseId).FirstOrDefaultAsync();
                              
        }
        public async Task<bool> UpdateCourse(CourseListing course)
        {
            try
            {
                _appDB.courseListings.Update(course);
                await _appDB.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return false;

            }
            return true;
        }
        public async Task<bool> DeleteCourse(int courseId)
        {
            try
            {
                var course = await GetCourse(courseId);
                _appDB.courseListings.Remove(course);
                await _appDB.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return false;

            }
            return true;
        }
    }
}
