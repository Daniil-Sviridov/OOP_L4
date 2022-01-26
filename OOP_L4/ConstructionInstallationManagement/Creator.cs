namespace ConstructionInstallationManagement
{
    public static class Creator
    {
        public static Building CreateBilding(int height, int storey, int entrances, int rooms, string name = "")
        {

            return new Building( height, storey, entrances, rooms);
        }
    }
}