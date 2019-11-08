using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Academy_Domain;

namespace Academy_persistant_EF.Repository
{
    public class CourseCategoryRepository:ICourseCategoryRepository
    {
        public List<CourseCategory> GetAll()
        {
            using (var context=new AcademyContext())
            {
                return context.CourseCategories.ToList().Where(x => !x.parentId.HasValue).ToList();
            }
        }
    }
}
