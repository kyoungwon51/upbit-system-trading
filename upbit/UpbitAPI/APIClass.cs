using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upbit.UpbitAPI.Model;

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
        /*--------------------- EXCHANGE API ---------------------*/

        
        public string GetAccount()
        {
            // 자산 - 전체 계좌 조회
            return noparam.Get("/v1/accounts", RestSharp.Method.GET);
        }

       
        public string GetOrderChance(string market)
        {
            // 주문 - 주문 가능 정보
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);

            return param.Get("/v1/orders/chance", parameters, RestSharp.Method.GET);

        }

        public Order GetOrder(string uuid)
        {
            // 주문 - 개별 주문 조회
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("uuid", uuid);
            var data = param.Get("/v1/order", parameters, RestSharp.Method.GET);
            if (data != null)
            {
                return JsonConvert.DeserializeObject<Order>(data);
            }
            else
            {
                return null;
            }
        }

        public CancelOrder CancelOrder(string uuid)
        {
            // 주문 - 주문 취소 접수
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("uuid", uuid);
            var data = param.Get("/v1/order", parameters, RestSharp.Method.DELETE);
            if (data != null)
            {
                return JsonConvert.DeserializeObject<CancelOrder>(data);
            }
            else
            {
                return null;
            }
        }
        public MakeOrder MakeOrderLimit(string market, OrderSide orderSide, double volume, double price)
        {
            // 주문 - 주문하기 - 지정가 매수&매도
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);
            parameters.Add("side", orderSide.ToString());
            parameters.Add("volume", volume.ToString());
            parameters.Add("price", price.ToString());
            parameters.Add("ord_type", "limit");

            var data = param.Get("/v1/orders", parameters, RestSharp.Method.POST);

            if (data != null)
            {
                return JsonConvert.DeserializeObject<MakeOrder>(data);
            }
            else
            {
                return null;
            }
        }
        public MakeOrderMarketBuy MakeOrderMarketBuy(string market, double price)
        {
            // 주문 - 주문하기 - 시장가매수

            /* 주문 가격. (지정가, 시장가 매수 시 필수)
            ex) KRW-BTC 마켓에서 1BTC당 1,000 KRW로 거래할 경우, 값은 1000 이 된다.
            ex) KRW-BTC 마켓에서 1BTC당 매도 1호가가 500 KRW 인 경우,
            시장가 매수 시 값을 1000으로 세팅하면 2BTC가 매수된다.
            (수수료가 존재하거나 매도 1호가의 수량에 따라 상이할 수 있음)  
            --> 결론 : price는 원화가치인듯 */

            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);
            parameters.Add("side", OrderSide.bid.ToString());
            parameters.Add("price", price.ToString());
            parameters.Add("ord_type", "price");
            var data = param.Get("/v1/orders", parameters, RestSharp.Method.POST);

            if (data != null)
            {
                return JsonConvert.DeserializeObject<MakeOrderMarketBuy>(data);
            }
            else
            {
                return null;
            }

        }
        public MakeOrderMarketSell MakeOrderMarketSell(string market, double volume)
        {
            // 주문 - 주문하기 - 시장가매도
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);
            parameters.Add("side", OrderSide.ask.ToString());
            parameters.Add("volume", volume.ToString());
            parameters.Add("ord_type", "market");
            var data = param.Get("/v1/orders", parameters, RestSharp.Method.POST);
            if (data != null)
            {
                return JsonConvert.DeserializeObject<MakeOrderMarketSell>(data);
            }
            else
            {
                return null;
            }
        }


        /*--------------------- QUOTATION API ---------------------*/

        public List<MarketAll> GetMarketAll()
        {
            // 시세 종목 조회 - 마켓 코드 조회
            var data = noparam.Get("/v1/market/all", RestSharp.Method.GET);
            return JsonConvert.DeserializeObject<List<MarketAll>>(data);

        }
        public List<CandleMinute> GetCandleMinutes(string market, MinuteUnit unit, DateTime to = default(DateTime), int count = 1)
        {
            // 시세 캔들 조회 - 분(Minute) 캔들
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);
            parameters.Add("to", to.ToString("yyyy-MM-dd HH:mm:ss"));
            parameters.Add("count", count.ToString());
            var data = param.Get(String.Join("", "/v1/candles/minutes/", (int)unit), parameters, RestSharp.Method.GET);

            if (data != null)
            {
                return JsonConvert.DeserializeObject<List<CandleMinute>>(data);
            }
            else
            {
                return null;
            }

        }

        public List<CandleDay> GetCandleDays(string market, DateTime to = default(DateTime), int count = 1)
        {
            // 시세 캔들 조회 - 일(Day) 캔들
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);
            parameters.Add("to", to.ToString("yyyy-MM-dd HH:mm:ss"));
            parameters.Add("count", count.ToString());
            var data = param.Get("/v1/candles/days", parameters, RestSharp.Method.GET);

            if (data != null)
            {
                return JsonConvert.DeserializeObject<List<CandleDay>>(data);
            }
            else
            {
                return null;
            }
        }
        public List<CandleWeek> GetCandleWeeks(string market, DateTime to = default(DateTime), int count = 1)
        {
            // 시세 캔들 조회 - 주(Week) 캔들
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);
            parameters.Add("to", to.ToString("yyyy-MM-dd HH:mm:ss"));
            parameters.Add("count", count.ToString());
            var data = param.Get("/v1/candles/weeks", parameters, RestSharp.Method.GET);

            if (data != null)
            {
                return JsonConvert.DeserializeObject<List<CandleWeek>>(data);
            }
            else
            {
                return null;
            }

        }
        public List<CandleMonth> GetCandleMonths(string market, DateTime to = default(DateTime), int count = 1)
        {
            // 시세 캔들 조회 - 월(Month) 캔들
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("market", market);
            parameters.Add("to", to.ToString("yyyy-MM-dd HH:mm:ss"));
            parameters.Add("count", count.ToString());
            var data = param.Get("/v1/candles/months", parameters, RestSharp.Method.GET);
            if (data != null)
            {
                return JsonConvert.DeserializeObject<List<CandleMonth>>(data);
            }
            else
            {
                return null;
            }
        }

        public List<Ticker> GetTicker(string markets)
        {
            // 시세 Ticker조회 - 현재가정보
            // market을 콤마로 구분하여 입력한다. 
            // ex) "KRW-BTC, KRW-ETH, ....."
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("markets", markets);
            var data = param.Get("/v1/ticker", parameters, RestSharp.Method.GET);

            if (data != null)
            {
                return JsonConvert.DeserializeObject<List<Ticker>>(data);
            }
            else
            {
                return null;
            }


        }
        public List<OrderBook> GetOrderBook(string markets)
        {
            // 시세 호가 정보 조회 - 호가 정보 조회
            // market을 콤마로 구분하여 입력한다. 
            // ex) "KRW-BTC, KRW-ETH, ....."
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("markets", markets);
            var data = param.Get("/v1/orderbook", parameters, RestSharp.Method.GET);

            if (data != null)
            {
                return JsonConvert.DeserializeObject<List<OrderBook>>(data);
            }
            else
            {
                return null;
            }

        }

        public enum OrderSide
        {
            bid,    // 매수
            ask     // 매도
        }
        public enum MinuteUnit
        {
            _1 = 1,
            _3 = 3,
            _5 = 5,
            _10 = 10,
            _15 = 15,
            _30 = 30,
            _60 = 60,
            _240 = 240

        }

    }
}