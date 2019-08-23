using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


using Discord;
using Discord.Commands;

namespace DnD_Bot.Core.Commands
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
