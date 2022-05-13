using System;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Type s = typeof(Student);
            var student = new Student();
            Type a = student.GetType();
        }
    }
}
