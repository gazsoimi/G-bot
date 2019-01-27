using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.WebSocket;
using Discord.Commands;
using Discord;

namespace G_bot.modules
{
   public class misc : ModuleBase<SocketCommandContext>
    {

        [Command("simonmondja")]
        public async Task Echo([Remainder]string message) {

            var embed = new EmbedBuilder();
            //  xxx
            embed.WithTitle("Simon Mondja");

            embed.WithDescription(message);
            embed.WithColor(new Color(0,255,0));
            

            Context.Channel.SendMessageAsync("",false,embed.Build());        
        }

     

        [Command("Chuck Norris")]
        public async Task cn([Remainder]string mg)
        {
         Context.Channel.SendMessageAsync("!vicc");
        }

    }
}
