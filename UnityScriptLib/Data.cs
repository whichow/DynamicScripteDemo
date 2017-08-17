
namespace UnityScriptLib
{
    public class Data
    {
        public string name;
        public int age;

        public Data(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return this.name + ":" + this.age;
        }
    }
}
