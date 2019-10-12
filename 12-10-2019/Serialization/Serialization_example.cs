using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialization
{
 [Serializable]
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Student(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
    class Serialization_example
    {
        static void Main(string[] args)
        {
            Student s = new Student(1963, "Rakesh");

            FileStream f = new FileStream("D:\\serialization1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(f, s);
            f.Close();

        }
    }
}
