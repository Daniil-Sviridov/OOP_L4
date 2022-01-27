
namespace ConstructionInstallationManagement
{
    public class Building
    {
        private static int nextuid;

        static Building()
        {
            nextuid = DateTime.Now.Millisecond;
        }

        private protected Building()
        {
            _uid = GetNewUID();
        }

        private protected Building(int height, int storey, int entrances, int rooms, string name = "")
        {
            _uid = GetNewUID();
            _version = 0;

            _name = name;
            _height = height;
            _storey = storey;
            _entrances = entrances;
            _rooms = rooms;

        }

        protected static Building New(int height, int storey, int entrances, int rooms, string name = "")
        {
            return new Building( height, storey,  entrances,  rooms, name);
        }


        private int GetNewUID()
        {
            nextuid++;
            return nextuid;
        }


        private int _uid;
        private int _version;
        private string _name;
        private int _height;
        private int _storey;
        private int _rooms;
        private int _entrances;

        /// <summary>
        /// Получить высоту этажа здания.
        /// </summary>
        /// <returns>double</returns>
        public double GetHeightStorey()
        {
            return _height / _storey;
        }

        /// <summary>
        /// Получить Количество квартир в подъезде
        /// </summary>
        /// <returns>double</returns>
        public int GetRoomInEntrances()
        {
            return _rooms / _entrances;
        }

        /// <summary>
        /// Получить Количество квартир в подъезде
        /// </summary>
        /// <returns>double</returns>
        public int GetRoomInyStorey()
        {
            return GetRoomInEntrances() / _storey;
        }

        public override string ToString()
        {
            return $"{_uid} Квартир {_rooms} высота {_height} подъездов {_entrances}";
        }
    }
}
