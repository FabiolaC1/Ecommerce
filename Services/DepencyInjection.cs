
using Microsoft.Extensions.DependencyInjection;

namespace Services
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUser, SvUser>();
            services.AddScoped<ICategory, SvCategory>();
            services.AddScoped<IShoppingOrder, SvShoppingOrder>();
            services.AddScoped<IProduct, SvProduct>();
            services.AddScoped<IOrderItem, SvOrderItem>();
            services.AddScoped<IShoppingCart, SvShoppingCart>();


            //El proyecto Services está exponiendo el servicio SvUser por medio de la interfaz IUser, al retornar los servicios que se registren
            //en este método, cuándo en el Program llame a AddServices, el Program conocerá todas las interfaces y servicios aquí configurados en el contenedor
            //de dependencias

            return services;//retornamos todos los servicios configurados para el resto de la aplicación
        }
    }
}

