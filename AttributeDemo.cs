using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeDemo
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class TestAttribute:System.Attribute
    {
        string name;
        public TestAttribute() { }
        public TestAttribute(string name)
        {
            this.name = name;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public void Fun() { }
    }

    [TestAttribute("Tom",Name ="Jack")] //Will not invoke Constructor
    class A
    {
        [TestAttribute("Hary",Name ="James")]
        public void Fun() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //refers TypeDef of A from metadata
           System.Type _typeDef= typeof(A);
            //Deserializes TestAttribute Objects From target Metadata
        TestAttribute[] testAttributes  = 
                _typeDef.GetCustomAttributes(typeof(TestAttribute), true) as TestAttribute[];

          TestAttribute instance=  testAttributes[0];
            Console.WriteLine(instance.Name);

           System.Reflection.MethodInfo method= _typeDef.GetMethod("Fun");
            testAttributes = method.GetCustomAttributes(typeof(TestAttribute), true) as TestAttribute[];
                instance = testAttributes[0];
            Console.WriteLine(instance.Name);



        }
    }
}
