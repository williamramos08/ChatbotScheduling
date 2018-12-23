using ChatbotScheduling.Common;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace ChatbotScheduling.Dialogs
{
    [Serializable]
    public class ScheduleDialog : IDialog<object>
    {
        public async Task StartAsync(IDialogContext context)
        {
            context.Wait(MessageReceivedAsync);
        }

        private async Task MessageReceivedAsync(IDialogContext context, IAwaitable<IMessageActivity> result)
        {
            var res = context.Activity as IMessageActivity;
            var message = res.Text.ToString();

            if (message != null)
            {
                await context.PostAsync("Not yet implemented");
            }

            //Flush conversation and show welcome card
            Utility.Flush(context);
        }
    }
}