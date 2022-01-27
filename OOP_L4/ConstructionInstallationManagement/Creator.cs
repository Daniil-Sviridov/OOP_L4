using System.Collections;

namespace ConstructionInstallationManagement
{
    public class Creator : Building
    {

        static private Hashtable ht = new Hashtable();

        /// <summary>
        /// Возвращает коллецию созданых объектов
        /// </summary>
        /// <returns></returns>
        public static ICollection GetBuildings()
        {

            ICollection val = ht.Values;

            return val;
        }

        /// <summary>
        /// Возвращает коллекцию ключей
        /// </summary>
        /// <returns></returns>
        public static ICollection GetKeysBuildings()
        {

            ICollection keys = ht.Keys;

            return keys;
        }

        /*public static void DelHT(int key)
        {
            ht.Remove((object)key);
        }*/

        /// <summary>
        /// УДаляет из таблицы объект по ключу.
        /// </summary>
        /// <param name="key"></param>
        /// <returns>Удаляемый объект или null</returns>
        public static Building? DelHT(int key)
        {

            if (!ht.ContainsKey(key)) return null;

            var b = ht[(object)key];

            ht.Remove((object)key);

            return (Building?)b;
        }

        protected Creator()
        {
        }

        /// <summary>
        /// Создает новое здание
        /// </summary>
        /// <param name="height"></param>
        /// <param name="storey"></param>
        /// <param name="entrances"></param>
        /// <param name="rooms"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Building NewBuilding(int height, int storey, int entrances, int rooms, string name = "")
        {
            var build = New(height, storey, entrances, rooms, name);
            ht.Add(build.GetHashCode(), build);

            return build;
        }
    }
}