using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ITMS.Infrastructure
{
    public class ConfigData
    {
        public static void SerializeFile<T>(T t, string fileName)
        {
            string str = JsonConvert.SerializeObject(t);

            byte[] buffer = Encoding.UTF8.GetBytes(str);
            string file = $"{Environment.CurrentDirectory }\\ConfigData\\{fileName}";
            if (File.Exists(file))
            {
                File.Delete(file);
            }
            FileStream fs = new FileStream(file, FileMode.Create);
            fs.Write(buffer, 0, buffer.Length);
            fs.Dispose();
        }
        public static T DeserializeFile<T>(string fileName) where T : new()
        {
            string file = $"{Environment.CurrentDirectory }\\ConfigData\\{fileName}";
            if (!File.Exists(file))
            {
                return new T();
            }
            FileStream fs = new FileStream(file, FileMode.Open);
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            fs.Dispose();

            T t = JsonConvert.DeserializeObject<T>(Encoding.UTF8.GetString(buffer));
            return t;
        }
    }
}
