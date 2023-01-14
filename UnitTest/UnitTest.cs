using ASEAssignmentProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;


namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {   //creats instances of a classes to enable tests
        static Bitmap DrawingSurface = new Bitmap(400, 300);
        static Canvass Canvass = new Canvass(Graphics.FromImage(DrawingSurface));
        
        
        static Parser P = new Parser(DrawingSurface, Canvass);

        [TestMethod]
        public void TestParseCommandMovePen() //tests move pen command
        {
            P.MyParser("movepen 100,100");

            Assert.AreEqual(100, Canvass.xPosition);
            Assert.AreEqual(100, Canvass.yPosition);
        }
        [TestMethod]
        public void TestParseCommandDrawLine() //tests drawline command
        {
            P.MyParser("drawline 100,100");

            Assert.AreEqual(100, Canvass.xPosition);
            Assert.AreEqual(100, Canvass.yPosition);
        }
        [TestMethod]
        public void TestParseCommandRed() //tests changing colours commands
        {
            P.MyParser("red");

            Assert.AreEqual(Color.Red, Canvass.p.Color);
        }

        [TestMethod]
        public void TestParseCommandBlue()
        {
            P.MyParser("blue");

            Assert.AreEqual(Color.Blue, Canvass.p.Color);
        }

        [TestMethod]
        public void TestParseCommandYellow()
        {
            P.MyParser("yellow");

            Assert.AreEqual(Color.Yellow, Canvass.p.Color);
        }
        [TestMethod]
        public void TestParseCommandBlack()
        {
            P.MyParser("black");

            Assert.AreEqual(Color.Black, Canvass.p.Color);
        }

        [TestMethod]
        public void TestParseCommandReset() //tests reset command
        {
            P.MyParser("reset");

            Assert.AreEqual(0, Canvass.xPosition);
            Assert.AreEqual(0, Canvass.yPosition);
        }
    }
}


