﻿using Discord.WebSocket;
using Discord.Commands;
using Discord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;




namespace G_bot
{
    class Program
    {

        DiscordSocketClient _client;
        commandhandler _handler;

        static void Main(string[] args)
    => new Program().StartAsync().GetAwaiter().GetResult();

        public async Task StartAsync() {

            if (Config.bot.token == "" || Config.bot.token == null) return;
            _client = new DiscordSocketClient(new DiscordSocketConfig {
                LogLevel =LogSeverity.Verbose           
            });
            _client.Log += Log;           
          await  _client.LoginAsync(TokenType.Bot , Config.bot.token);
          await _client.StartAsync();
         _handler = new commandhandler();
            await _handler.InitilizeAsync(_client);
            await Task.Delay(-1);
        }

        private async Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.Message);
          //  return Task.CompletedTask;
        }
    }
}