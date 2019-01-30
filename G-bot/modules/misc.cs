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

        [Command("Hello")]
        public async Task Hello()
        {
            
            Context.Channel.SendMessageAsync(Utilities.GetFormattedAlert("WELCOME_&NAME", Context.User.Username));
        }

       

        [Command("simonmondja")]
        public async Task Echo([Remainder]string message)
        {

            var embed = new EmbedBuilder();
            //  xxx
            embed.WithTitle(Context.User.Username + " mondja");

            embed.WithDescription(message);
            embed.WithColor(new Color(0, 255, 0));


            Context.Channel.SendMessageAsync("", false, embed.Build());
        }

        [Command("pick")]
        public async Task PickOne([Remainder]string message)
        {
            string[] options = message.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

            Random r = new Random();

            r.Next(0,10);

            string selecction = options[r.Next(0,options.Length)];



            var embed = new EmbedBuilder();
            
            embed.WithTitle("Choice for " + Context.User.Username);

            embed.WithDescription(selecction);
            embed.WithColor(new Color(0, 255, 0));
            embed.WithThumbnailUrl("https://t00.deviantart.net/ob6GqNr1s5QzuV9NiK8p76S3kaU=/fit-in/300x900/filters:no_upscale():origin()/pre00/f304/th/pre/f/2017/317/2/a/steins_gate_seven_minutes_in_heaven___kurisu_by_vampiregodesnyx-dbtp1kc.jpg");



            Context.Channel.SendMessageAsync("", false, embed.Build());
        }









       //- [Command("Chuck Norris")]
        //public async Task cn([Remainder]string mg)
        //{            Context.Channel.SendMessageAsync("!vicc");}


        [Command("Ping")]
        public async Task cn()
        {
            Context.Channel.SendMessageAsync("Azt hitted mi");
        }

        [Command("Jóéjt")]
        public async Task bucsuzas()
        {
            Context.Channel.SendMessageAsync("Jóéjt neked is " + Context.User.Username);

        }
        [Command("Üdv népek")]
        public async Task udvozles()
        {
            Context.Channel.SendMessageAsync("Csőő! " + Context.User.Username);

        }
        [Command("omae wa moe shindeiru")]
        public async Task omae()
        {
            Context.Channel.SendMessageAsync("Naniiiii?");

        }
    }
}
