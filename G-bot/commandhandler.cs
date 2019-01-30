using Discord.WebSocket;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;


namespace G_bot
{
    class commandhandler
    {
        DiscordSocketClient _client;
        CommandService _service;

        public async Task InitilizeAsync(DiscordSocketClient client) {

            _client = client;
            _service = new CommandService();

            await _service.AddModulesAsync(Assembly.GetEntryAssembly(), null);
            _client.MessageReceived += HandleCommandAsync;      

        }

        private async Task HandleCommandAsync(SocketMessage s)
        {
            var msg = s as SocketUserMessage;
            if (msg == null) return;
            var context = new SocketCommandContext(_client, msg);
            int argPos = 0;
            if (msg.HasStringPrefix(Config.bot.cmdPrefix, ref argPos) || msg.HasMentionPrefix(_client.CurrentUser, ref argPos)) {

                var result = await _service.ExecuteAsync(context, argPos, null);
                if (!result.IsSuccess && result.Error != CommandError.UnknownCommand)
                    Console.WriteLine(result.ErrorReason);

            }

            
            string[] badWords = { "Chuck Norris"};

            if (badWords.Any(word => msg.Content.IndexOf(word, 0, msg.Content.Length, StringComparison.OrdinalIgnoreCase) >= 0))
            {
             context.Channel.SendMessageAsync("Ne szórakozz a Norrissal!");
            }
            


        }

        }
    }

