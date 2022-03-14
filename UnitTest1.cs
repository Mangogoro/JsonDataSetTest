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

            var sJson = @"{'FileData':[{'FD_PKey':32,'FD_FileName':'FX-1110216-c1.TXT','FD_FileSize':947,'FD_FileType':1,'FD_FileContent':{'$type':'System.Byte[], System.Private.CoreLib, Version=6.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e','$value':'MTk5OTkgICAgMDA1MDMzNyAxMDAwMDAxMTAwOTA4MSAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICANCjI5OTk5ICAgIDAwNSAgICAgMTAwMDAwMTExMDMxMTAwMDAwMDAwMDMzMTAxMDAwNzY3MDAwMDAwMDAwMjAxMDA5OTk5OTg4Mzk5OTkgICAgICAgICAgICAgICAgICAgICAgWjE5OTk5MDAwMCAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIDk5OTk5ODgzMDAgICAgICAgICAgICAgICAgICAgICAgMTA1MzM3QGxhbmRiYW5rdC5jb20udHcgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgDQoyOTk5OSAgICAwMDUgICAgIDEwMDAwMDExMTAzMTYwMDAwMDAwMDAzMzEwMTAwMDc2NzAwMDAwMDAwMDIwMTAwOTk5OTk4ODM5OTk5ICAgICAgICAgICAgICAgICAgICAgIFoxOTk5OTAwMDAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA5OTk5OTg4MzAxICAgICAgICAgICAgICAgICAgICAgIDEwNTMzN0BsYW5kYmFua3QuY29tLnR3ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIA0KMDA1MDMzNyAxMDAwMDAxMTAwOTA4MDAwMDAwMDAwMDAyMzEwMDAwMDAwMDAwMjEwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMCAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA='},'FD_MasterJsonData':'H4sIAAAAAAAEAI2RwUrEMBRFfyVkLZ2kYexMV9apgguLaEVQXDzbgINpOsQULeJeBHHnD/gDs9T/sX6HL50UZjGKd9eT+15uei8eaAoW8nYhaUxDukV3Qd8cpPgxRRGUYwZ0cZ3VSBkbI8iN9iOcoZAkx7in38HCcCRGnJOvj+fu5YnwMGYsXpmKom609Yu8hODMbYm2I7ScLlQNZVI5X7+NB/3oEbQ53PeTLth0MhFITyzY5nZWl9JzZO49iZGAhGzUOXdOd/Xm8/9olUjKIRMha6lmjTFSF63LlTWVeyzS/blS0vyaCh17hzBX/T8dCxHtKNDlFbZhg6KuAnv3d5zhUt9LfpauwQwqB7/flt3rsvt89z0PjWIHEX28/AGb48qwDQIAAA==','FD_DetailJsonData':null}]}";
            
            var oDataSet = JsonConvert.DeserializeObject<DataSet>(sJson);

            Assert.Pass();
        }
    }
}