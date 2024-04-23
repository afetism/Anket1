using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Anket1.Repository
{
    public class JsonHandler<T>
    {

        public string Path { get; set; }
        public ObservableCollection<T> Items { get; set; }
        public JsonHandler(string path)
        {
            Path=path;
            if(File.Exists(Path))
            {
                var data = File.ReadAllText(Path);
                Items = JsonSerializer.Deserialize<ObservableCollection<T>>(data);
            }
            else
                Items= new ObservableCollection<T>();
        }

        public void SavaData()
        {
            var data = JsonSerializer.Serialize(Items);
            File.WriteAllText(Path, data);
            
        }

    }
}
