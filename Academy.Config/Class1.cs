using System;
using Academy.Application;
using Academy_Domain;
using Academy_persistant_EF;
using Academy_persistant_EF.Repository;
using Applicatio.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Academy.Config
{
    public static class Bootstraper
    {
        public static void AddAcademy(this IServiceCollection services)
        {
            services.AddScoped<AcademyContext>();
            services.AddScoped<ICourseCategoryRepository, CourseCategoryRepository>();
            services.AddScoped<ICourseCategoryServices, CoursecategoryService>();
        }
    }
}
