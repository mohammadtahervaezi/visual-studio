using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Academy_Domain;

namespace Academy_persistant_EF.Repository
{
    public class CourseCategoryRepository:ICourseCategoryRepository
    {
        private  AcademyContext _context;

        public CourseCategoryRepository(AcademyContext context)
        {
            _context = context;
        }
        public List<CourseCategory> GetAll()
        {
            
                return _context.CourseCategories.ToList().Where(x => !x.parentId.HasValue).ToList();
            
        }

        public CourseCategory getbyid(long id)
        {
            
                return _context.CourseCategories.Find(id);
            
        }

        public void remove(CourseCategory entity)
        {
           
                _context.CourseCategories.Remove(entity);
                _context.SaveChanges();
            
        }

        
    }
}
