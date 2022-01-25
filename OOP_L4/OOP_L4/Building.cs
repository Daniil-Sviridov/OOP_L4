using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_L4
{
    public class Building
    {
        private static int nextuid;

        static Building()
        {
            nextuid = DateTime.Today.Millisecond;
        }

        public Building( int height,  int storey, int entrances, int rooms,  string name = "")
        { 
            _uid = GetNewUID();
            _version = 0;

            _name = name;
            _height = height;
            _entrances = entrances;
            _rooms = rooms;

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
    }
}
