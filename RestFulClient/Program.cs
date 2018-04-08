using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestFulClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Restful客户端Demo测试";

            RestClient client = new RestClient();
            client.EndPoint = @"http://127.0.0.1:7788/";

            client.Method = EnumHttpVerb.GET;
            string resultGet = client.HttpRequest("PersonInfoQuery/王二麻子");
            Console.WriteLine("GET方式获取结果：" + resultGet);

            client.Method = EnumHttpVerb.POST;
            Info info = new Info();
            info.ID = 1;
            info.Name = "张三";
            client.PostData = JsonConvert.SerializeObject(info);//JSon序列化我们用到第三方Newtonsoft.Json.dll
            var resultPost = client.HttpRequest("PersonInfoQuery/Info");
            Console.WriteLine("POST方式获取结果：" + resultPost);
            Console.Read();
        }
    }

    [Serializable]
    public class Info
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
