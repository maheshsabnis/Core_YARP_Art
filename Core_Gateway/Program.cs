var builder = WebApplication.CreateBuilder(args);
builder.Services.AddReverseProxy()
     .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy")).ConfigureHttpClient((context, handler) =>
     {
         if (handler is SocketsHttpHandler socketsHttpHandler)
         {
             socketsHttpHandler.SslOptions.RemoteCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
         }
     });

// Add services to the container.  
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi  
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.  
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();


 
// Use top-level route registrations instead of UseEndpoints  
app.MapReverseProxy();

app.Run();
