using System;
using System.Threading.Tasks;
using EleCho.GoCqHttpSdk;
using EleCho.GoCqHttpSdk.Message;
namespace QbotTest
{
    internal class Program
    {
        CqHttpSession session=new CqHttpSession(new CqHttpSessionOptions()
            {
                BaseUri = new Uri("http://localhost:5700")
            }
        );

        private async void StartSession()
        {

        }
        
        public static void Main(string[] args)
        {

        }
    }
}