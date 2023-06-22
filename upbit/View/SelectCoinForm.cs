using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using upbit.UpbitAPI;
using upbit.UpbitAPI.Model;

namespace upbit.View
{
  
    public partial class SelectCoinForm : Form
    {
        private List<MarketAll> marketList;
        public SelectCoinForm(APIClass API) 
        {
            InitializeComponent();

            marketList = API.GetMarketAll();

            foreach (MarketAll item in marketList) 
            {
                //Console.WriteLine(item.market);
                if (item.market.Contains("KRW-"))
                {
                    Console.WriteLine(item.market);
                }
            }
        }
    }
}
