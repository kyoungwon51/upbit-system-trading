using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upbit.Model
{
    public class AccountClass : IDisposable
    {
        public string market;   // 마켓
        public double profit;   // 수익률 
        public double quantity; // 보유수량
        public double curPrice; // 현재가
        public double avgPrice; // 평단가

        public void Dispose() { }
    }
}
