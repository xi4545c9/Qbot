using System;
using System.Linq;
using System.Threading.Tasks;
using EleCho.GoCqHttpSdk;
using EleCho.GoCqHttpSdk.Message;

namespace Qbot
{
    public static class App
    {
        public static async Task Run()
        {
            CqWsSession session = new CqWsSession(new CqWsSessionOptions()
            {
                BaseUri = new Uri("ws://localhost:5701")
            });

            session.UseGroupMessage(async (context) =>
            {
                try
                {
                    if (context.Message.Any(msg => msg is CqAtMsg atMsg && atMsg.Target==context.SelfId ))
                    {
                        string msg = context.Message.Text.Trim();
                        Console.WriteLine(context.RawMessage);
                        string answer = await GPT_test.Run(msg);
                        await session.SendGroupMessageAsync(context.GroupId, new CqMessage
                        {
                            new CqAtMsg(context.UserId),
                            // new CqReplyMsg(context.MessageId),
                            // new CqTextMsg($"[CQ:reply,id={context.MessageId}]"+answer.Trim())
                            new CqTextMsg(answer.Trim())
                        });
                        return;
                    }
                }
                catch (Exception e)
                {
                    await Console.Out.WriteLineAsync($"{e}");
                }
            });

            while (true)
            {
                try
                {
                    await session.StartAsync();
                    await Console.Out.WriteLineAsync("连上了捏");
                    await session.WaitForShutdownAsync();
                }
                catch (Exception e)
                {
                    await Console.Out.WriteLineAsync($"{e}");
                }
            }
        }
    }
}