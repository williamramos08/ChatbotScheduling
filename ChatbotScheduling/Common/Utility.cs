using Autofac;
using ChatbotScheduling.Cards;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Dialogs.Internals;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace ChatbotScheduling.Common
{
    public class Utility
    {
        public static async void Flush(IDialogContext context)
        {
            using (var scope = DialogModule.BeginLifetimeScope(Conversation.Container, (Activity)context.Activity))
            {
                var botData = scope.Resolve<IBotData>();
                await botData.LoadAsync(default(CancellationToken));
                var stack = scope.Resolve<IDialogStack>();
                stack.Reset();
                await botData.FlushAsync(default(CancellationToken));
            }

            //Flush conversation.
            var activity = context as Activity;

            var compose = context.MakeMessage();
            compose.Attachments.Add(WelcomeCard.Welcome());
            await context.PostAsync(compose, CancellationToken.None);
        }
    }
}