
using BusinessLogicLayer.ModelViews;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface ICourseService
{
    Task<List<Course>> GetAllCoursesAsync();
    SelectList GetCourseStatesSelectList(CourseState? selectedState = null);
    Task<Course> GetCourseByIdAsync(int id);
    Task AddCourseAsync(Course course);
    Task UpdateCourseAsync(Course course);
    Task MarkCourseAsDeletedAsync(int id);
}
