﻿using NUnit.Framework;
using System;
using System.Text;

namespace UnitTestFramework
{
    public class UnitTest1
    {
        [TestCase]
        public void Byte_Ansi編碼()
        {
            var sBase64 = "MTE2MzIgICAgMDA1MDMzNyAxMDAwMDAxMTAwOTA4MSAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICANCjIxNjMyICAgIDAwNSAgICAgMTAwMDAwMTExMDEyMDAwMDAwMDAwMDg4MTAxNTQ1NDUyMDAwMDAwMDAwMTAyMDAwMDAwMDAwMDk5OTkgICAgICAgICAgICAgICAgICAgIEGkVLDTpEi52FRFU1QxICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA5OTk5OTkzMSAgMDEgICAgICAgICAgICAgICAgICAgICAgMTA1MzM3QGxhbmRiYW5rdC5jb20udHcgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgDQoyMTYzMiAgICAwMDUgICAgIDEwMDAwMDExMTAxMjAwMDAwMDAwMDA4ODEwMTU0NTQ1MjAwMDAwMDAwMDAyMjAwMDAwMDAwMDA5OTk5ICAgICAgICAgICAgICAgICAgICBBpFSw06RIudhURVNUMiAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgOTk5OTk5MzIgIDAxICAgICAgICAgICAgICAgICAgICAgIDEwNTMzN0BsYW5kYmFua3QuY29tLnR3ICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgIA0KMDA1MDMzNyAxMDAwMDAxMTAwOTA4MDAwMDAwMDAwMDAyMzEwMDAwMDAwMDAwMjEwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMDAwMCAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICANCg==";

            var byteData = Convert.FromBase64String(sBase64);

            //var sss= Convert.ToBase64String(byteData);
            string sStr = Encoding.Default.GetString(byteData);

            Assert.IsTrue(true);
        }

    }
}
