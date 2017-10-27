using NLog;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
//using System.Web.Http.Controllers;
//using System.Web.Http.Routing;

namespace Messenger.Logger
{
    public static class NLogger
    {
        private static bool _isLoggerCreated = false;
        private static NLog.Logger _logger;

        public static NLog.Logger Logger
        {
            get
            {
                if (_isLoggerCreated)
                   return _logger;
                _logger = LogManager.GetCurrentClassLogger();
                return LogManager.GetCurrentClassLogger();
            }
        }
    }
}