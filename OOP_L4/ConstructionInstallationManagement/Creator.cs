namespace ConstructionInstallationManagement
{
    public class Creator : Building    
    {
        protected Creator()
        { 
        }

        public static Building NewBuilding(int height, int storey, int entrances, int rooms, string name = "")
        {
            
            return New(height, storey, entrances, rooms, name);
        }
    }
}