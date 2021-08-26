using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;
namespace UnitTestExercise01
{
    [TestClass]
    public class Exercise01UnitTest
    {
        [TestMethod]
        public void TestValidOutput()
        {
            Exercise01.Exercise01 exercise01 = new Exercise01.Exercise01();

            String.IsNullOrEmpty(exercise01.Towards(8));
            Assert.AreNotEqual("Two ", exercise01.Towards(1));
            Assert.AreNotEqual("One Thousand", exercise01.Towards(100));
            Assert.AreNotEqual("Nine Hundred And Ninety Nine ", exercise01.Towards(969));
        }

        [TestMethod]
        public void TestOneToHunred()
        {
            Exercise01.Exercise01 exercise01 = new Exercise01.Exercise01();

            Assert.AreEqual("One ", exercise01.Towards(1));
            Assert.AreEqual("Fifty ", exercise01.Towards(50));
            Assert.AreEqual("Ninety Six ", exercise01.Towards(96));
            Assert.AreEqual("One Hundred", exercise01.Towards(100));
        }

        [TestMethod]
        public void TestHunredToThousand()
        {
            Exercise01.Exercise01 exercise01 = new Exercise01.Exercise01();

            Assert.AreEqual("One Hundred", exercise01.Towards(100));
            Assert.AreEqual("One Hundred And Five ", exercise01.Towards(105));
            Assert.AreEqual("Two Hundred", exercise01.Towards(200));
            Assert.AreEqual("Five Hundred And Ninety Four ", exercise01.Towards(594));
            Assert.AreEqual("Nine Hundred And Ninety Nine ", exercise01.Towards(999));
        }

        [TestMethod]
        public void TestThousandTenThousand()
        {
            Exercise01.Exercise01 exercise01 = new Exercise01.Exercise01();

            Assert.AreEqual("One Thousand", exercise01.Towards(1000));
            Assert.AreEqual("One Thousand And Ten ", exercise01.Towards(1010));
            Assert.AreEqual("Five Thousand", exercise01.Towards(5000));
            Assert.AreEqual("Nine Thousand And Ninety Seven ", exercise01.Towards(9097));
        }

        [TestMethod]
        public void TestTenThousandToNineHundredAndNinetyNine()
        {
            Exercise01.Exercise01 exercise01 = new Exercise01.Exercise01();

            Assert.AreEqual("Ten Thousand", exercise01.Towards(10000));
            Assert.AreEqual("Thirty Thousand", exercise01.Towards(30000));
            Assert.AreEqual("Sixty Four Thousand, Five Hundred And Ninety Seven ", exercise01.Towards(64597));
            Assert.AreEqual("Ninety Nine Thousand, Nine Hundred And Ninety Nine ", exercise01.Towards(99999));
        }
    }
}
