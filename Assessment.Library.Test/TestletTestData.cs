using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Library.Test
{
    public class TestletTestData
    {


        static IEnumerable GetTestcase()
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
                new Item { ItemId = "4", ItemType = ItemTypeEnum.Pretest }
            };
            yield return new Testlet("1", itemlist);
            yield return new Testlet("2", itemlist);
            yield return new Testlet("3", itemlist);
            yield return new Testlet("4", itemlist);
        }
    }
}
