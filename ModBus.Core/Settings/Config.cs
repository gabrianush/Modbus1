using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModBus.Core.Settings
{
    public static class Config
    {
        public const string ROOT_DIRECTORY_NAME = "ModBus";
        public static readonly string ROOT_DIRECTORY = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), ROOT_DIRECTORY_NAME);

        public const string CONNECTIONS_FILE_NAME = "Connections.dat";
        public static readonly string CONNECTIONS_FILE_PATH = Path.Combine(ROOT_DIRECTORY, CONNECTIONS_FILE_NAME);


        public static void Init()
        {
            if (!Directory.Exists(ROOT_DIRECTORY))
            {
                Directory.CreateDirectory(ROOT_DIRECTORY);
            }
        }
    }
}
