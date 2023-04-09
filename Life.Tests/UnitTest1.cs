using Microsoft.VisualStudio.TestTools.UnitTesting;
using cli_life;
using System.IO;
using Newtonsoft.Json;

namespace Life.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Board board;
            Program p = new Program();
            string json = File.ReadAllText("settings.json");
            board = JsonConvert.DeserializeObject<Board>(json);
            Assert.AreEqual(board.CellSize, 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Board board;
            Program p = new Program();
            string json = File.ReadAllText("settings.json");
            board = JsonConvert.DeserializeObject<Board>(json);
            Assert.AreEqual(board.Width, 100);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Board board;
            Program p = new Program();
            string json = File.ReadAllText("settings.json");
            board = JsonConvert.DeserializeObject<Board>(json);
            Assert.AreEqual(board.Height, 20);
        }
        [TestMethod]
        public void TestMethod4()
        {
            LifeGame LG = new LifeGame();
            LG.ReadBoard("test_output.txt");
            Assert.AreEqual(LG.CountAliveCells(), 64);
        }
        [TestMethod]
        public void TestMethod5()
        {
            LifeGame LG = new LifeGame();
            LG.ReadBoard("test_output.txt");
            Assert.AreEqual(LG.BlocksCount(), 3);
        }
    }
}
