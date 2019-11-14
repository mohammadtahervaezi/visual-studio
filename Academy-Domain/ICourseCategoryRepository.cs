using System;
using System.Collections.Generic;
using System.Text;

namespace Academy_Domain
{
    public interface ICourseCategoryRepository
    {
        List<CourseCategory> GetAll();
        CourseCategory getbyid( long id);
        void remove(CourseCategory entity);
    }
}
