
namespace Managertask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Shahnaz", 1000, true);
            Assistant assistant = new Assistant();
            assistant.GetFeedback(employee);
        }
    }
}