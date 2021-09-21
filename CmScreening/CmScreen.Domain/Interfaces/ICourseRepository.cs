using CmScreen.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CmScreen.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
