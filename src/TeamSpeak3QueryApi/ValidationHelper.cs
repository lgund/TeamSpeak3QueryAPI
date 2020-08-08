using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace TeamSpeak3QueryApi
{
    internal class ValidationHelper
    {
        /// <summary>
        /// on false, API should throw new ArgumentOutOfRangeException("port");
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        public static bool ValidateTcpPort(int port) => port >= IPEndPoint.MinPort && port <= IPEndPoint.MaxPort;
    }
}
