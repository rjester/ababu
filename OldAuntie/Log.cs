using System;


namespace OldAuntie
{
    public class Log
    {
        private string filePath = string.Empty;
        private string message = string.Empty;
        private System.IO.StreamWriter file = null;
        public const string LOG_TYPE_MESSAGE = "message";
        public const string LOG_TYPE_WARNING = "warning";
        public const string LOG_TYPE_ERROR = "error";

        public Log()
        {
            Load();
        }

        public string Message { get => message; set => message = value; }
        public string FilePath { get => filePath; set => filePath = value; }


        public void Load()
        {
            if (filePath == string.Empty)
            {
                filePath = AppDomain.CurrentDomain.BaseDirectory + System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".log";
            }
        }

        public void Load(string path) => filePath = path;


        public void Write(string message)
        {
            Write(message, LOG_TYPE_MESSAGE);
        }

        public void Write(string message, string logType)
        {
            DateTime now = DateTime.Now;
            // Display the date in the default (general) format.

            Open();
            AddLine(now.ToString() + " (" + logType + "): " + message);
            Close();
        }


        public string Read()
        {
            return System.IO.File.ReadAllText(filePath);
        }



        public void AddLine(string line)
        {
            file.WriteLine(line);
        }


        public void Open()
        {
            try
            {
                file = new System.IO.StreamWriter(FilePath, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Close()
        {
            file.Close();
        }
    }
}
