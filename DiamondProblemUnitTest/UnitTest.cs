using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DiamondProblem;

namespace DiamondProblemTest
{
    [TestClass]
    public class UnitTest
    {
        IDiamond d;

        [TestMethod]        
        public void Test_First_Single_Character()
        {
            d = new Diamond();
            Assert.AreEqual("A\n", d.CreateDiamond("A"));
        }

        [TestMethod]
        public void Test_Wide_Range_For_Valid_Character()
        {
            string testString = "  A\n B B\nC   C\n B B\n  A\n";
            d = new Diamond();
            Assert.AreEqual(testString, d.CreateDiamond("C"));
        }

        [TestMethod]        
        public void Test_UpperCase_For_Valid_Character()
        {
            string testString = " A\nB B\n A\n";
            d = new Diamond();
            Assert.AreEqual(testString, d.CreateDiamond("B"));
        }

        [TestMethod]        
        public void Test_Valid_Character_Input()
        {
            string testString = "Please enter a character between A to Z, i.e. alphabates in capital letter.";
            d = new Diamond();
            Assert.AreEqual(testString, d.CreateDiamond("*"));
        }

        [TestMethod]
        public void Test_If_Any_Error_Occured()
        {           
            d = new Diamond();
            Assert.IsTrue(d.CreateDiamond("").Contains("Something went wrong!!"));
        }
    }
}
