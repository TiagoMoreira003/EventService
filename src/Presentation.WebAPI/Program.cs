using EventService.Presentation.WebAPI;
using Serilog;
using Steeltoe.Extensions.Configuration.ConfigServer;

WebApplicationBuilder builder = CreateBuilder(args);

Startup startup = new(builder.Configuration);

startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app);

app.Run();

static WebApplicationBuilder CreateBuilder(string[] args)
{
	var webApplicationOptions = new WebApplicationOptions
	{
		Args = args,
		ContentRootPath = $"{Directory.GetCurrentDirectory()}/Configuration"
	};

	var builder = WebApplication.CreateBuilder(webApplicationOptions);

	builder.Host.ConfigureAppConfiguration((builderContext, config) =>
	{
		var hostingEnvironment = builderContext.HostingEnvironment;
		config.SetBasePath(hostingEnvironment.ContentRootPath)
			.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
			.AddJsonFile($"appsettings.{hostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true)
			.AddConfigServer(hostingEnvironment.EnvironmentName)
			.AddEnvironmentVariables();
	})
	.UseSerilog((hostingContext, loggerConfiguration) =>
	{
		loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
	});

	return builder;
}