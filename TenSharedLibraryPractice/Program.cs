using TenSharedLibraryPractice;
using Ten.Shared.Templates;

var options = new AspNetCoreOptions("TenSharedLibraryPractice", "TSLP", args)
{
    ConfigureBuilder = AppSetup.Configure
};

var app = AspNetCoreTemplate.Create(options);

app.MapControllers();

app.Run();

record TestResponse(string Value);