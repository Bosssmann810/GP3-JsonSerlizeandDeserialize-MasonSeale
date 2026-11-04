using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;

namespace GP3_JsonSerlizeandDeserialize_MasonSeale
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            settings stats = new settings();
            stats.level = 1;
           stats.lives = 2;

           string jsonString = JsonSerializer.Serialize(stats);
            File.WriteAllText("settings.Json", jsonString);
            Console.WriteLine(jsonString);

            var test = JsonSerializer.Deserialize<settings>(File.ReadAllText("settings.Json"));
            Console.WriteLine(test.level);
            Console.WriteLine(test.lives);
            Console.ReadKey(true);
        }
    }
}
