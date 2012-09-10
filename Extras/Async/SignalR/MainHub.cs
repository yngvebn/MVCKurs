using System.Threading.Tasks;
using SignalR.Hubs;

namespace Async.SignalR
{
    public class MainHub: Hub
    {
         public void Start()
         {
             Task.Factory.StartNew(StartProcessing);
         }

        private void StartProcessing()
        {
            this.Clients.Progress("We've started...");
            Sleep(2000);
            Clients.Progress("Going to do some heavy lifting.. Done in 5 seconds");
            Sleep(5000);
            Clients.Progress("Working");
            Sleep(1000);
            Clients.Progress("Finishing up!");
            Sleep(1000);
            Clients.Progress("Done!");
            
        }

        private void Sleep(int i)
        {
            System.Threading.Thread.Sleep(i);
        }
    }
}