using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upbit.UpbitAPI
{
    public class APIClass
    {

        private Param param;
        private NoParam noparam;

        public APIClass(string upbitAccessKey, string upbitSecretKey)
        {
            param = new Param(upbitAccessKey, upbitSecretKey);
            noparam = new NoParam(upbitAccessKey, upbitSecretKey);
        }
        public string GetAccount()
        {
            return noparam.Get("/v1/accounts", RestSharp.Method.GET);
        }
        public string GetOrderChance(string market)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);

            return param.Get("/v1/orders/chance", parameters, RestSharp.Method.GET);

        }


    }
}