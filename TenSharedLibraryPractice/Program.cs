using TenSharedLibraryPractice;
using Ten.Shared.Templates;

var options = new AspNetCoreOptions("TenSharedLibraryPractice", "TSLP", args)
{
    ConfigureBuilder = AppSetup.Configure
};

var app = AspNetCoreTemplate.Create(options);

app.MapControllers();

//TODO - Stop it from outputting everything on the console to logz.io
app.MapGrpcService<HelloWorldService>();

app.Run();

//record TestResponse(string Value);
