
using System.Threading.Tasks;

namespace Qbot
{
    internal class Program
    {
        private static void Init()
        {
            
        }
        public static void Main(string[] args)
        {
            Init();
            App.Run().Wait();
        }
    }
}