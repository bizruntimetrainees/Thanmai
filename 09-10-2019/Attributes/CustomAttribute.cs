using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CustomAttribute
{
    //Creating Custom Attribute
    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute:Attribute
    {
        private string name;
        private string action;

        public MyAttribute(string name, string action)
        {
            this.name = name;
            this.action = action;
        }
        public string Name
        {
            get
            {
                return name;
            }
        }

        public string Action
        {
            get
            {
                return action;
            }
        }
    }


    class Student
    {
        private int rollNo;
        private string stuName;
        private double marks;

        
        [MyAttribute("Modifier", "Assigns the Student Details")]
        public void setDetails(int r, string sn, double m)
        {
            rollNo = r;
            stuName = sn;
            marks = m;
        }

        [MyAttribute("Accessor", "Returns Value of rollNo")]
        public int getRollNo()
        {
            return rollNo;
        }

        [MyAttribute("Accessor", "Returns Value of stuName")]
        public string getStuName()
        {
            return stuName;
        }

        [MyAttribute("Accessor", "Returns Value of marks")]
        public double getMarks()
        {
            return marks;
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student();
            s.setDetails(12571417, "Thanmai", 82);

            Console.WriteLine("Student Details");
            Console.WriteLine("Roll Number : " + s.getRollNo());
            Console.WriteLine("Name : " + s.getStuName());
            Console.WriteLine("Marks : " + s.getMarks());
            Console.ReadKey();

        }
    }
}
