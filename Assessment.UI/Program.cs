using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessment.Library;

namespace Assessment.UI
{
    class Program
    {
        static void Main()
        {
            List<Item> itemlist = new List<Item>(10) {
                new Item { ItemId = "5", ItemType = ItemTypeEnum.Operational },
                new Item { ItemId = "6", ItemType = ItemTypeEnum.Operational },
                new Item { ItemId = "7", ItemType = ItemTypeEnum.Operational },
                new Item { ItemId = "8", ItemType = ItemTypeEnum.Operational },
                new Item { ItemId = "9", ItemType = ItemTypeEnum.Operational },
                new Item { ItemId = "10", ItemType = ItemTypeEnum.Operational},
                new Item { ItemId = "1", ItemType = ItemTypeEnum.Pretest },
                new Item { ItemId = "2", ItemType = ItemTypeEnum.Pretest },
                new Item { ItemId = "3", ItemType = ItemTypeEnum.Pretest },
                new Item { ItemId = "4", ItemType = ItemTypeEnum.Pretest } };
            Testlet t = new Testlet("1",itemlist);

            for (int i = 0; i < 5; i++)
            {
                itemlist = t.Randomize();

                itemlist.ForEach(x => Console.WriteLine(x.ItemId + "  " + x.ItemType));

                Console.WriteLine("--------------------");
                Console.WriteLine("Press Any Key for Next Testlet Set");
                Console.ReadLine();
            }

            
        }
    }
}
