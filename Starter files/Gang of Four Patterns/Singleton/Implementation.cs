namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        protected Logger()
        {
        }

        private static readonly Lazy<Logger> _lazyLogger = new Lazy<Logger>(() => new Logger());
        //private static Logger? _instance;

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
                //if (_instance == null)
                //{
                //    _instance = new Logger();
                //}
                //return _instance;
            }
        }

        /// <summary>
        /// SingletonOperation
        /// </summary>
        /// <param name="message"></param>
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
