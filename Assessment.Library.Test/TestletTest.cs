using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment.Library.Test
{

    [TestFixture]
    public class TestletTest
    {



        [Test, TestCaseSource(typeof(TestletTestData), "GetTestcase")]
        public void Check_creation_testlet(Testlet testlet)
        {
            //Arrange
            //Act


            //Assert
            Assert.Pass("OK", testlet);
        }


        [Test, TestCaseSource(typeof(TestletTestData), "GetTestcase")]
        public void Check_Testlet_setof_10(Testlet testlet) //Arrange
        {

            int totalitems = 10;
            //Act
            List<Item> items = testlet.Randomize();

            //Assert
            Assert.AreEqual(totalitems, items.Count);
        }


        [Test, TestCaseSource(typeof(TestletTestData), "GetTestcase")]
        public void Check_Testlet_6_Operationof_10(Testlet testlet)
        {

            int operationalcnt = 6;
            //Act
            List<Item> items = testlet.Randomize()
                .Where(x => x.ItemType == ItemTypeEnum.Operational)
                .ToList();

            //Assert
            Assert.AreEqual(operationalcnt, items.Count);
        }

        [Test, TestCaseSource(typeof(TestletTestData), "GetTestcase")]
        public void Check_Testlet_4_Pretestof_10(Testlet testlet)
        {
            int pretestcnt = 4;
            //Act
            List<Item> items = testlet.Randomize().Where(x => x.ItemType == ItemTypeEnum.Pretest).ToList();

            //Assert
            Assert.AreEqual(pretestcnt, items.Count);
        }

        [Test, TestCaseSource(typeof(TestletTestData), "GetTestcase")]
        public void Check_Testlet_first2_Pretestof_10(Testlet testlet)
        {
            //Act
            List<Item> items = testlet.Randomize();

            //Arrange
            bool firsttwopretest = items[0].ItemType == ItemTypeEnum.Pretest;
            firsttwopretest = firsttwopretest && items[1].ItemType == ItemTypeEnum.Pretest;

            //Assert
            Assert.IsTrue(firsttwopretest);

        }

    }
}
