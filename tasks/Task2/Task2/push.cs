using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reactive.Linq;
using System.Reactive.Subjects;


namespace Task2
{
    class push
    {
        public static void Run(objekt[] list)
        {

            int i = 1;
            var producer = new Subject<furniture>();

            producer
                .Sample(TimeSpan.FromSeconds(1))
                .Subscribe(x =>
                {
                    Array.Resize(ref list, list.Length+1);
                    list[i-1] = x;
                    i++;
                }
                );
                
            

            var t = new Thread(() =>
            {
                int i1 = 0;
                while (i1 < 25)
                {
                    var new_furniture = new furniture("Thread_" + i1++,"Automatic");
                    Thread.Sleep(50);
                    producer.OnNext(new_furniture);
                }
            });
            t.Start();
        }
        

    }
}
