using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OpenAI_API;
using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;

namespace Qbot
{
    public static class GPT_test
    {
        public static async Task<string> Run(string question)
        {
            var openAiService = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = "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"
            });
            
            openAiService.SetDefaultModelId(Models.ChatGpt3_5Turbo);

            var completionResult = await openAiService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = new List<ChatMessage>
                {
                    // ChatMessage.FromSystem("You are a helpful assistant."),
                    // ChatMessage.FromUser("Who won the world series in 2020?"),
                    // ChatMessage.FromAssistant("The Los Angeles Dodgers won the World Series in 2020."),
                    ChatMessage.FromUser(question)
                },
                Model = Models.ChatGpt3_5Turbo,
            });
            if (completionResult.Successful)
            {
                Console.WriteLine(completionResult.Choices.First().Message.Content);
                return completionResult.Choices.First().Message.Content;
            }
            else
            {
                Console.WriteLine("失败了捏");
                return "我很想回复你的消息但是刚刚我老爹openai没鸟我，作为个呆逼ai我就就不知道怎么回答你了";
            }
        }
    }
}