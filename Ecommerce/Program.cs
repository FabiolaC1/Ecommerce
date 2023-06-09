// See https://aka.ms/new-console-template for more information

using Entidades;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Services;
using Entidades;

IHost app = Host.CreateDefaultBuilder() // El Host es el contexto donde corre nuestra aplicación, y tiene opciones tipo Compilador y de Configurar Servicios
.ConfigureServices((context, services) => // El Configure Services puede acceder a los otros proyectos externos
{
    services.AddDataAccess(); // Hacemos que el Program sepa de la existencia del proyecto DataAccess y sus servicios configurados, en este caso el MyDbContext
    services.AddServices(); // Hacemos que el Program sepa de la existencia del proyecto Services y sus servicios configurados, en este caso SvUser por medio de IUser

}).Build();//El Build inicia el Host y compila los proyectos externos para que sus servicios configurados sean entendidos por la aplicación principal

#endregion

var svUser = app.Services.GetRequiredService<IUser>();
//GetRequiredService injecta el Servicio que le pasemos a nuestra aplicación
//a nivel de objeto para poder utilizarlo tipo svUSer.Add  .Update  .ListUsers etc, básicamente para poder llamar a sus metodos

//svUser.Add(new User()
//{
//    Email = "Email Test"
//});

//svUser.Add(new User()
//{
//    Email = "Email Test 2"
//});


//Listar
List<User> usersList = svUser.ListUsers();

//Console.WriteLine();

//usersList.ForEach(x => Console.WriteLine(x.Id + "-" + x.Email));

//Console.ReadLine();


Boolean test = true;

Console.WriteLine(test.ToStringBoolean());
