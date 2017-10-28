using NLog;

namespace Messenger.Logger
{
    public static class NLogger
    {
        public static NLog.Logger Logger = LogManager.GetCurrentClassLogger();
    }
}