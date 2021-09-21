using CmScreen.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Application.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses();
    }
}
