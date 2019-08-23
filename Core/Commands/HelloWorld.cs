using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


using Discord;
using Discord.Commands;

namespace DnDBot.Core.Commands
{
    public class HelloWorld : ModuleBase<SocketCommandContext>
    {
        [Command("hello"), Alias("helloworld, world"), Summary("Hello world command")]
        public async Task Sjustin()
        {
            await Context.Channel.SendMessageAsync("Hello world");
        }
    }
}
