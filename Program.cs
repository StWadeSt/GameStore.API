using GameStore.API;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connString = builder.Configuration.GetConnectionString("GameStore");
        builder.Services.AddSqlite<GameStoreContext>(connString);

        var app = builder.Build();

        app.MapGamesEndpoints();

        app.Run();
    }
}