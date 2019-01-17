using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    class Board
    {
        int Height { get; set; }
        int Width { get; set; }
        int[][] Tiles { get; set; }

        public void AddUnit(int unit, int x, int y) { }
        public int GetTile(int x, int y) { return -1; }
        public int RemoveUnit(int x, int y) { return -1; }
    }
    
    class ThreeDBoard : Board
    {
        int Depth { get; set; }
        int[][][] ThreeDTiles { get; set; }

        public void AddUnit(int unit, int x, int y, int z) { }
        public int GetTile(int x, int y, int z) { return -1; }
        public int RemoveUnit(int x, int y, int z) { return -1; }
    }
}
