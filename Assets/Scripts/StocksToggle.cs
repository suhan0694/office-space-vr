using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StocksToggle : MonoBehaviour
{
    public TextMeshPro textMesh;
    public static string stockName = "Microsoft";
    // Start is called before the first frame update
    void Start()
    {
        //textMesh = tv.GetComponent<TextMeshPro>();
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void toggleStocks(TextMeshPro stockPriceMesh) {

        if (stockName == "Microsoft")
        {
            var webRequest = System.Net.WebRequest.Create(new System.Uri("https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=MSFT&apikey=XC1Y2B11B0S2M1XN"));
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";

            System.Net.WebResponse wr = webRequest.GetResponseAsync().Result;
            System.IO.Stream receiveStream = wr.GetResponseStream();
            System.IO.StreamReader reader = new System.IO.StreamReader(receiveStream);

            string resp = reader.ReadToEnd();

            Newtonsoft.Json.Linq.JObject jobj = Newtonsoft.Json.Linq.JObject.Parse(resp);
            Debug.Log("Test" + jobj["Global Quote"]["05. price"].ToString());
            string stockPrice = jobj["Global Quote"]["05. price"].ToString();
            string stockChange = jobj["Global Quote"]["10. change percent"].ToString();
            stockPriceMesh.SetText("Microsoft: " + stockPrice + "\n Change in Percentage " + stockChange);
            stockName = "Google";
        }
        else if (stockName == "Google")
        {
            var webRequest = System.Net.WebRequest.Create(new System.Uri("https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=GOOGL&apikey=XC1Y2B11B0S2M1XN"));
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";

            System.Net.WebResponse wr = webRequest.GetResponseAsync().Result;
            System.IO.Stream receiveStream = wr.GetResponseStream();
            System.IO.StreamReader reader = new System.IO.StreamReader(receiveStream);

            string resp = reader.ReadToEnd();

            Newtonsoft.Json.Linq.JObject jobj = Newtonsoft.Json.Linq.JObject.Parse(resp);
            Debug.Log("Test" + jobj["Global Quote"]["05. price"].ToString());
            string stockPrice = jobj["Global Quote"]["05. price"].ToString();
            string stockChange = jobj["Global Quote"]["10. change percent"].ToString();
            stockPriceMesh.SetText("Google: " + stockPrice + "\n Change in Percentage " + stockChange);
            stockName = "Amazon";
        }
        else {
            var webRequest = System.Net.WebRequest.Create(new System.Uri("https://www.alphavantage.co/query?function=GLOBAL_QUOTE&symbol=AMZN&apikey=XC1Y2B11B0S2M1XN"));
            webRequest.Method = "GET";
            webRequest.ContentType = "application/json";

            System.Net.WebResponse wr = webRequest.GetResponseAsync().Result;
            System.IO.Stream receiveStream = wr.GetResponseStream();
            System.IO.StreamReader reader = new System.IO.StreamReader(receiveStream);

            string resp = reader.ReadToEnd();

            Newtonsoft.Json.Linq.JObject jobj = Newtonsoft.Json.Linq.JObject.Parse(resp);
            Debug.Log("Test" + jobj["Global Quote"]["05. price"].ToString());
            string stockPrice = jobj["Global Quote"]["05. price"].ToString();
            string stockChange = jobj["Global Quote"]["10. change percent"].ToString();
            stockPriceMesh.SetText("Amazon: " + stockPrice + "\n Change in Percentage " + stockChange);
            stockName = "Microsoft";
        }

    }
}
