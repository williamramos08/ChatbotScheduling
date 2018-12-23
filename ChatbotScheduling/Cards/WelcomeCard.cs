using AdaptiveCards;
using Microsoft.Bot.Connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatbotScheduling.Cards
{
    public class WelcomeCard
    {
        public static Attachment Welcome()
        {
            AdaptiveCard adaptiveCards = new AdaptiveCard()
            {
                Body = new List<AdaptiveElement>()
                {
                    new AdaptiveTextBlock()
                    {
                        Text = "Hi there! \U0001F60A I'm Dental Bot. What would you like to do?",
                        Wrap = true
                    }
                },
                Actions = new List<AdaptiveAction>()
                {
                    new AdaptiveSubmitAction()
                    {
                        Title = "Schedule",
                        Data = "Schedule"
                    },
                    new AdaptiveSubmitAction()
                    {
                        Title = "Schedule2",
                        Data = "Schedule2"
                    },
                    new AdaptiveSubmitAction()
                    {
                        Title = "Schedule3",
                        Data = "Schedule3"
                    }
                }
            };

            Attachment attachment = new Attachment()
            {
                ContentType = AdaptiveCard.ContentType,
                Content = adaptiveCards
            };

            return attachment;
        }
    }
}