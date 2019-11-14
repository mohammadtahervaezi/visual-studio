using Academy_Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using Academy_Domain;
using Applicatio.Contracts;
using Mapster;

namespace Academy.Application
{
   
    public class CoursecategoryService:ICourseCategoryServices
    {
        private ICourseCategoryRepository _Repository;
        public CoursecategoryService(ICourseCategoryRepository repository)
        {
            _Repository = repository;
        }

        

        public List<CourseCategoryDto> GetAll()
        {
            var entities = _Repository.GetAll();
            var p = entities.Adapt<List<CourseCategoryDto>>();
            return p;
            
        }

        public void Delete( long id)
        {
          var entity=  _Repository.getbyid(id);
          if(entity!=null)
          _Repository.remove(entity);
        }
    }
}
