using ConstructionInstallationManagement;

namespace OOP_L4
{
    public class Program
    {
        static void Main(string[] args)
        {

            Creator.NewBuilding(15, 5, 3, 45);
            //Console.WriteLine(building);
            Creator.NewBuilding(15, 5, 3, 45);
            //Console.WriteLine(building);
            Creator.NewBuilding(45, 5, 3, 145);
            //Console.WriteLine(building);
            Creator.NewBuilding(35, 7, 6, 45);
            //Console.WriteLine(building);
            Creator.NewBuilding(15, 5, 3, 45);
            //Console.WriteLine(building);
             Creator.NewBuilding(15, 5, 3, 45);
            //Console.WriteLine(building);

            Console.WriteLine();
            Console.WriteLine("Read colection Buildin");
            foreach (var i in Creator.GetBuildings())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            int keyfordel = 0;
            Console.WriteLine("Read colection key in HashTable");
            foreach (var i in Creator.GetKeysBuildings())
            {
                //Допустим что всегда удаляем только первый                
                if (keyfordel == 0) keyfordel = (int)i;
                Console.WriteLine(i);
            }

            if (keyfordel != 0) 
            {
                //Если есть что удалить ....
                Console.WriteLine();
                var delunit = Creator.DelHT(keyfordel);

                Console.WriteLine($"Del Buidin {delunit}");

                Console.WriteLine("Read colection Buildin");
                foreach (var i in Creator.GetBuildings())
                {
                    Console.WriteLine(i);
                }

            }




        }
    }
}
