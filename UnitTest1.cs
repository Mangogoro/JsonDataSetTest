using Newtonsoft.Json;
using NUnit.Framework;
using System.Data;

namespace JsonDataSetTest
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            JsonSerializerSettings setting = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Full,
                //TypeNameAssemblyFormatHandling = Newtonsoft.Json.TypeNameAssemblyFormatHandling.Simple,
                //TypeNameHandling = Newtonsoft.Json.TypeNameHandling.Objects
            };

            /*
            有個DataSet物件透過Newtonsoft.Json做了JSON序列化，裡頭有個$Type特別標註了byte[]型別的資料欄位，但反序列化會失敗。
             * Json 針對DataSet、DataTable這樣的物件做序列化時，在型別上會有前後不一致的問題，
               例如int型別的column會變long，byte[] 會變成string
               後來查到 用JsonSerializerSettings宣告來產出$Type標示型別，感覺快成功了，就差反序列話還是會失敗囉
            */
            var sJson = @"{'FileData':[{'PKey':33,'FileName':'test.txt','FileSize':56,'FileType':1,'FileContent':{'$type':'System.Byte[], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e','$value':'dGVzdLT6uNWlzqq6wMmu16S6rmU='}}]}";

            var oDataSet = JsonConvert.DeserializeObject<DataSet>(sJson, setting);

            Assert.Pass();
        }
    }
}