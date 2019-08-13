using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Library
{
    public class Testlet
    {
        public string TestletId;
        private List<Item> Items;

        public Testlet(string testletId, List<Item> items)
        {
            TestletId = testletId;
            Items = items;

        }


        public List<Item> Randomize()
        {
            try
            {
                int cnt = Items.Count;
                List<int> pindx = new List<int>();

                if (cnt < 10)
                {
                    throw new ExceptionSetlessthan10("set less than 10");
                }

                int pretestitemscnt = 0;
                int operationalItemscnt = 0;

                for (int i = 0; i < cnt; i++)
                {
                    if (Items[i].ItemType == ItemTypeEnum.Operational)
                    {
                        operationalItemscnt++;
                    }
                    else
                    {
                        pretestitemscnt++;
                        pindx.Add(i);
                    }
                }


                if (pretestitemscnt != 4)
                {
                    throw new ExceptionPretestNotEqual4("Pretest set not equal 4");
                }


                if (operationalItemscnt != 6)
                {
                    throw new ExceptionOperationalNotEqual6("Pretest set not equal  6");
                }


                Random rnd = new Random();
                int j = 0;
                int x = 0;

                while (j < 2)
                {
                    do
                    {
                        x = rnd.Next(0, pindx.Count);
                    } while (pindx[x] == j);

                    swap(pindx[x], j);
                    pindx.RemoveAt(x);
                    j++;
                }

                while (j < cnt)
                {
                    do
                    {
                        x = rnd.Next(2, cnt);
                    } while (x == j);

                    swap(x, j);
                    j++;
                }



                return Items;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


        void swap(int from, int to)
        {
            Item itm = Items[from];
            Items[from] = Items[to];
            Items[to] = itm;
        }

    }

    public class Item
    {
        public string ItemId;
        public ItemTypeEnum ItemType;
    }

    public enum ItemTypeEnum
    {
        Pretest = 0,
        Operational = 1
    }
}