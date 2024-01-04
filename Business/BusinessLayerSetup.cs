using AutoMapper;
using Business.Interfaces;
using Business.Services;
using Business.Validations;
using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

namespace Business
{
    public static class BusinessLayerSetup
    {
        public static IServiceCollection BusinessLayerSetupAdd(this IServiceCollection services) {

            ConfigureAutomapper(services);
            ServicesImplementations(services);
            return services;
        }

        public static IServiceCollection ConfigureAutomapper(IServiceCollection Services)
        {

            var config = new MapperConfiguration(cfg =>
            {
                var mainAssembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(c => c.GetName().Name == "Business");
                cfg.AddMaps(mainAssembly);
                cfg.AllowNullCollections = true;
            });
            var mapper = config.CreateMapper();
            Services.AddSingleton(mapper);

            Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return Services;

        }

        public static IServiceCollection ServicesImplementations(IServiceCollection Services)
        {
            Services.AddTransient<ICategoryServices, CategoryServices>();
            Services.AddValidatorsFromAssemblyContaining<CategoryValidator>();

            return Services;
        }


        }
    }
