using System;
using System.Net;
using System.Net.Http;
using System.IO;

namespace calamityMessage
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            string url = "http://apis.data.go.kr/1741000/DisasterMsg3/getDisasterMsg1List"; // URL
            url += "?ServiceKey=" + "pKN5u34Ofkbe7MlYr%2Bi%2Be3wAxZlZCxFg%2B3R5omwes1y6nBzykTdah0CeQ2IeGKu31TZE4Kx5QuS7ck0VmTVemg%3D%3D"; // Service Key
            url += "&pageNo=1";
            url += "&numOfRows=20";
            url += "&type=json"; //XML or json
            
            var request = (HttpWebRequest)WebRequest.Create(url);
             request.Method = "GET";
            
            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }
            
            Console.WriteLine(results);
        }
    }
}