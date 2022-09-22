using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DiamondProblem;

namespace DiamondProblemTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        //[Ignore]
        public void Test_First_Single_Character()
        {
            Assert.AreEqual("A\n", ShowDiamond.CreateDiamond("A"));

        }

        [TestMethod]
        //[Ignore]
        public void Test_Wide_Range_For_Valid_Character()
        {
            string testString = "    A\n" +
                                "   B B\n" +
                                "  C   C\n" +
                                " D     D\n" +
                                "E       E\n" +
                                " D     D\n" +
                                "  C   C\n" +
                                "   B B\n" +
                                "    A\n";
            Assert.AreEqual(testString, ShowDiamond.CreateDiamond("E"));

        }

        [TestMethod]
        //[Ignore]
        public void Test_UpperCase_For_Valid_Character()
        {
            string testString = " A\n" +
                                "B B\n" +
                                " A\n";
            Assert.AreEqual(testString, ShowDiamond.CreateDiamond("B"));

        }

        [TestMethod]
        //[Ignore]
        public void Test_Valid_Character_Input()
        {
            string testString = "Please enter a character between A to Z, i.e. alphabates in capital letter.";
            Assert.AreEqual(testString, ShowDiamond.CreateDiamond("b"));

        }
    }
}
