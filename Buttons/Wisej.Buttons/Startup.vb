
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting
Imports Wisej.Core

''' <summary>
''' The Startup class configures services and the app's request pipeline.
''' For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940.
''' </summary>
Public Class Startup

    Public Sub New(configuration As IConfiguration)
        Me.Configuration = configuration
    End Sub
    Public ReadOnly Property Configuration As IConfiguration

    Public Shared Sub Main(args As String())

        Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(
            Sub(builder)
                builder.UseWebRoot("./")
                builder.UseStartup(Of Startup)()
            End Sub).Build().Run()
    End Sub

    '' This method gets called by the runtime. Use this method to add services to the container.
    Public Sub ConfigureServices(services As IServiceCollection)

    End Sub

    '' This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    Public Sub Configure(app As IApplicationBuilder, env As IWebHostEnvironment)
        app.UseWisej()
        app.UseFileServer()
    End Sub

End Class
