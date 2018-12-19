using System;
using System.IO;

namespace OldAuntie
{
    public class Log
    {
        private string FilePath = string.Empty;
        private string Message = string.Empty;
        private System.IO.StreamWriter file = null;
        public const string LOG_TYPE_MESSAGE = "message";
        public const string LOG_TYPE_WARNING = "warning";
        public const string LOG_TYPE_ERROR = "error";


        private static Log instance;


        public Log(string file_path = "")
        {
            if(file_path == "")
            {
                string log_dir = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Path.DirectorySeparatorChar + System.Diagnostics.Process.GetCurrentProcess().ProcessName + Path.DirectorySeparatorChar;
                DirectoryInfo DI = Directory.CreateDirectory(log_dir);

                FilePath = log_dir + System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".log";
            }
            else
            {
                FilePath = file_path;
            }
        }



        public static Log Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Log();
                }
                return instance;
            }
        }



        public void Write(string message)
        {
            Write(message, LOG_TYPE_MESSAGE);
        }



        public void Write(string message, string logType)
        {
            Open();
            AddLine(DateTime.Now.ToString() + " (" + logType + "): " + message);
            Close();
        }



        public string Read()
        {
            return System.IO.File.ReadAllText(FilePath);
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
