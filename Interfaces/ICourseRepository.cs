using u20649232_HW01_API.Models;

namespace u20649232_HW01_API.Interfaces
{
    public interface ICourseRepository
    {
        //Declaring CRUD EndPoints

        // Create
        Task<bool> AddCourse(CourseListing course);
        // Read
        Task<List<CourseListing>> GetAllCourses();
        // Read (Single Record)
        Task<CourseListing> GetCourse(int courseId);
        // Update  
        Task<bool> UpdateCourse(CourseListing course); 
        //Delete
        Task<bool> DeleteCourse(int gamingConsoleId); 



    }
}
