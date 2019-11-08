using Academy_Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace Applicatio.Contracts
{
    public class CourseCategoryDto
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public List<CourseCategoryDto> Children { get; set; }
    }
}
