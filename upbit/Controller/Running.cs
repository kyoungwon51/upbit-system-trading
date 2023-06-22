using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upbit.UpbitAPI;

namespace upbit.Controller
{
    public partial class Running
    {
        private System.Timers.Timer mainTimer;
        private APIClass API;
        public Running(APIClass API)
        { 
            this.API = API;
            this.mainTimer = new System.Timers.Timer();
            this.mainTimer.Interval = 1000; // 1초
            this.mainTimer.Elapsed += ElapsedEventReceiver;
        }

        public void Go()
        {
            this.mainTimer.Start();
        }

        public void stop()
        {
            this.mainTimer.Stop();
        }

        private void ElapsedEventReceiver(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (sender.Equals(this.mainTimer))
            {
                // 타이머 실행 시 실행할 함수
                main();
            }
        }
    }
}
