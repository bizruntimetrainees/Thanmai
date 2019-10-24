using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Callback
{
    public class SerializationEventTestObject
    {
       
        public int Member1 { get; set; }    
        public string Member2 { get; set; }

        [JsonIgnore]
        public string Member3 { get; set; }
        public string Member4 { get; set; }

        public SerializationEventTestObject()
        {
            Member1 = 11;
            Member2 = "Welcome to Callback!";
            Member3 = "This is a nonserialized value";
            Member4 = null;
        }

        [OnSerializing]
       public void OnSerializingMethod(StreamingContext context)
        {
            Member2 = "This value went into the data file during serialization.";
        }

        [OnSerialized]
        public void OnSerializedMethod(StreamingContext context)
        {
            Member2 = "This value was reset after serialization.";
        }

        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            Member3 = "This value was set during deserialization";
        }

        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            Member4 = "This value was set after deserialization.";
        }
    }
    class call_back
    {
        static void Main(string[] args)
        {
            SerializationEventTestObject obj = new SerializationEventTestObject();

            Console.WriteLine(obj.Member1);
            Console.WriteLine(obj.Member2);
            Console.WriteLine(obj.Member3);
            Console.WriteLine(obj.Member4);

            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);
       
            Console.WriteLine(obj.Member1);
            Console.WriteLine(obj.Member2);
            Console.WriteLine(obj.Member3);
            Console.WriteLine(obj.Member4);

            obj = JsonConvert.DeserializeObject<SerializationEventTestObject>(json);

            Console.WriteLine(obj.Member1);
            Console.WriteLine(obj.Member2);
            Console.WriteLine(obj.Member3);
            Console.WriteLine(obj.Member4);
            Console.ReadKey();

        }
    }
}
