namespace Tools
{
    public sealed class Log //Sealed para no heredar
    {
        private static Log _instance = null;
        private string _path;
        private static object _protect = new object();

        public static Log Instance
        {
            get { return _instance; }
        }

        public static Log GetInstance(string path)
        {
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(path);
                }
            }

            return _instance;
        }
        private Log(string path)
        {
            _path = path;
        }

        public void Save(string mensaje)
        {
            File.AppendAllText(_path, mensaje + Environment.NewLine);
        }
    }
}
