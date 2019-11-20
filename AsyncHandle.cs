using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Threading;

namespace TaskSequence
{
    /// <summary>
    /// 异步调用
    /// </summary>
    public class AsyncHandle
    {
        private readonly SerialQueue queue = new SerialQueue();
        private int watierTempperature = 0;

        public async Task<int> OpenBoil(string s)
        {

            await queue.Enqueue(() => {
              
                BoilWorking(s);
            });     

            return watierTempperature;
        }

        private int BoilWorking(string ss)
        {
            Console.WriteLine(ss);
            Thread.Sleep(500);
            watierTempperature = watierTempperature + 10;
            string s = "Thread ID:" + Thread.CurrentThread.ManagedThreadId + " Boil temperature is :" + watierTempperature;
            s = DateTime.Now.ToString("yyyy-MM-hh HH:mm:ss:fff ") + s;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(s);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            
            return 1;

        }
    }
}
