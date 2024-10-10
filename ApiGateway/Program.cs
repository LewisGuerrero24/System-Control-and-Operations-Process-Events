using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Newtonsoft.Json.Linq;

namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config
                        .SetBasePath(hostingContext.HostingEnvironment.ContentRootPath)
                        .AddJsonFile("appsettings.json", true, true)
                        .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", true, true);

                    // Cargar y combinar archivos Ocelot desde la carpeta 'configuration'
                    var combinedConfig = new JObject();

                    // Rutas de los archivos Ocelot
                    var globalOcelotPath = Path.Combine(hostingContext.HostingEnvironment.ContentRootPath, "Configuration", "ocelot.global.json");
                    var productsOcelotPath = Path.Combine(hostingContext.HostingEnvironment.ContentRootPath, "Configuration", "ocelot.products.json");

                    // Leer y combinar archivos Ocelot
                    combinedConfig.Merge(JObject.Parse(File.ReadAllText(globalOcelotPath)));
                    combinedConfig.Merge(JObject.Parse(File.ReadAllText(productsOcelotPath)));

                    // Escribe el archivo combinado en la raíz del proyecto
                    var combinedOcelotPath = Path.Combine(hostingContext.HostingEnvironment.ContentRootPath, "ocelot.json");
                    File.WriteAllText(combinedOcelotPath, combinedConfig.ToString());

                    config.AddJsonFile(combinedOcelotPath, optional: false, reloadOnChange: true);
                })
                .ConfigureServices(s =>
                {
                    s.AddOcelot();
                })
                .UseIISIntegration()
                .Configure(app =>
                {
                    app.UseOcelot().Wait();
                })
                .Build()
                .Run();
        }
    }
}
