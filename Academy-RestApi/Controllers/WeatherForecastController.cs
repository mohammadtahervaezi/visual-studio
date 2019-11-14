using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Applicatio.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Academy_RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ICourseCategoryServices _Services;

        public WeatherForecastController(ICourseCategoryServices Services)
        {
            _Services = Services;
        }
        [HttpGet]
        public List<CourseCategoryDto> Get()
        {
          return  _Services.GetAll();
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(long id)
        {
            _Services.Delete(id);
        }
    }
}
