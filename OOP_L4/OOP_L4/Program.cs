using ConstructionInstallationManagement;

namespace OOP_L4
{
    public class Program
    {
        static void Main(string[] args)
        {

            Building building = Creator.NewBuilding(15, 5, 3, 45);

            //Building building = new Building(15, 5, 3, 45);

            Console.WriteLine(building);

        }
    }
}
