using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;

class Program
{
    private DiscordSocketClient _client;

    public static Task Main(string[] args) => new Program().MainAsync();

    public async Task MainAsync()
    {
        _client = new DiscordSocketClient();

        _client.Log += Log;

        // Replace 'YourBotToken' with your bot's token
        var token = "";

        await _client.LoginAsync(TokenType.Bot, token);
        await _client.StartAsync();

        // Block the program until it is closed.
        await Task.Delay(-1);
    }

    private Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }
}
