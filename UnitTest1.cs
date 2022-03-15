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
            ����DataSet����z�LNewtonsoft.Json���FJSON�ǦC�ơA���Y����$Type�S�O�е��Fbyte[]���O��������A���ϧǦC�Ʒ|���ѡC
             * Json �w��DataSet�BDataTable�o�˪����󰵧ǦC�ƮɡA�b���O�W�|���e�ᤣ�@�P�����D�A
               �Ҧpint���O��column�|��long�Abyte[] �|�ܦ�string
               ��Ӭd�� ��JsonSerializerSettings�ŧi�Ӳ��X$Type�Хܫ��O�A�Pı�֦��\�F�A�N�t�ϧǦC���٬O�|�����o
            */
            var sJson = @"{'FileData':[{'PKey':33,'FileName':'test.txt','FileSize':56,'FileType':1,'FileContent':{'$type':'System.Byte[], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e','$value':'dGVzdLT6uNWlzqq6wMmu16S6rmU='}}]}";

            var oDataSet = JsonConvert.DeserializeObject<DataSet>(sJson, setting);

            Assert.Pass();
        }
    }
}