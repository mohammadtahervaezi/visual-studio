using System;
using System.Collections.Generic;

namespace Applicatio.Contracts
{
    public interface ICourseCategoryServices
    {
        List<CourseCategoryDto> GetAll();
        void Delete( long id);
    }
}
