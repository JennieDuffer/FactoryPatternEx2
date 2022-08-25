using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx2
{
    public class ListDataAccess : IDataAccess
    {
        public void LoadData()
        {
            Console.WriteLine("I am reading data from ListDataAccess");
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a ListDataAccess");
        }
    }
}
