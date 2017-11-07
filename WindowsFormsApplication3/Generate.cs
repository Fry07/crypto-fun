
namespace WindowsFormsApplication3
{
    public class Generate
    {

        public string generate(string currency, int random, string other)
        {
            string res = "";
                        
            if (currency == "BTC")
            {
                res = (random > 40) ? "Время закупаться, братан, " + currency + " будет расти" : "Время сливать, братан, " + currency + " будет падать";           
            }
            else if (currency == "Other")
            {
                res = (random > 60) ? "Время закупаться, братан, " + other + " будет расти" : "Время сливать, братан, " + other + " будет падать";
            }
            else
            {
                res = (random > 60) ? "Время закупаться, братан, " + currency + " будет расти" : "Время сливать, братан, " + currency + " будет падать";
            }
            return res;
        }
    }
}
