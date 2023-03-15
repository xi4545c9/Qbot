// using System;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleCho.GoCqHttpSdk;
using EleCho.GoCqHttpSdk.Action;
using EleCho.GoCqHttpSdk.Message;
using EleCho.GoCqHttpSdk.Post;
using OpenAI.GPT3;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3.ObjectModels.RequestModels;

// const long testGroupId = 592231801;
// const long testQQId = 413946601;
// CqHttpSession session=new CqHttpSession(new CqHttpSessionOptions()
//     {
//         BaseUri = new Uri("http://localhost:5700")
//     }
// );
// int i = 0;
// while (true)
// {
//     await Task.Delay(5000);
//     await session.SendGroupMessageAsync(1170054865, new CqMessage($"Hello -{i++}"));
//     Console.WriteLine($"发送了消息 -{i}");
// }

// CqWsSession session=new CqWsSession(new CqWsSessionOptions()
//     {
//         BaseUri = new Uri("ws://localhost:5701")
//     }
// );
//
// session.PostPipeline.Use(async (context, func) =>
//     {
//         if (context is CqGroupMessagePostContext groupMessagePostContext)
//         {
//             // await session.SendGroupMessageAsync(groupMessagePostContext.GroupId, new CqMessage("检测到这个群发送了一条消息"));
//         }
//         await func.Invoke();
//     }
// );
//
// session.UseGroupMessage(async (context,next) =>
// {
//     // await session.SendGroupMessageAsync(context.GroupId,new CqMessage("检测到这个群发送了一条消息"));
//     // await next.Invoke();
//     if (context.Message.Text.StartsWith("召唤bot", StringComparison.OrdinalIgnoreCase))
//     {
//         await session.SendGroupMessageAsync(context.GroupId, new CqMessage("喵，主人叫我吗"));
//         // CqSendPrivateMessageActionResult result = await session.SendPrivateMessageAsync(testQQId, new CqMessage("Test"));
//     }
// });
//
// await session.RunAsync();
//
//
// //用正则表达式匹配echo 开头的消息

