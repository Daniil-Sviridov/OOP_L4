using ConstructionInstallationManagement;

namespace OOP_L4
{
    public class Program
    {
        static void Main(string[] args)
        {

            Building building = Creator.CreateBilding(15, 5, 3, 45);

            Console.WriteLine(building);

        }
    }
}
