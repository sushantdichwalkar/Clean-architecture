using CmScreen.Domain.Interfaces;
using CmScreen.Domain.Models;
using CmScreen.Infra.Data.ContextDB;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using Microsoft.Extensions.Configuration;

namespace CmScreen.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private CmScreenDbContext _dbContext;
        public IConfiguration _Configuration { get; }
        
        public CourseRepository(CmScreenDbContext dbContext, IConfiguration configuration) : base()
        {
            _dbContext = dbContext;
           
            _Configuration = configuration;
        }

        public IEnumerable<Course> GetCourses()
        {
            DataSet ds = SqlHelper.ExecuteDataset(_Configuration["ConnectionStrings:PDDatabase"],
                CommandType.StoredProcedure, "usp_Get_Courses");

            List<Course> CourseList = new List<Course>();

                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                    {
                        var course = new Course();
                    course.Id = Convert.ToInt32(ds.Tables[0].Rows[i]["id"]);
                    course.Name = ds.Tables[0].Rows[i]["Name"].ToString();
                    course.ImageUrl = ds.Tables[0].Rows[i]["ImageUrl"].ToString();
                    CourseList.Add(course);
                    }
                }

                return CourseList;
        }
    }
}
