using System;
using System.Collections.Generic;
using System.Text;

namespace TilesMVC
{
    public class TilesModel
    {
        public double N { get; set; }  
        public double W { get; set; }  
        public double L { get; set; }  
        public double M { get; set; }  
        public double O { get; set; }  

        public double NeededTiles { get; private set; }
        public double TotalTime { get; private set; }

        public void Calculate()
        {
            double areaSquare = N * N;
            double areaBench = M * O;
            double areaToCover = areaSquare - areaBench;

            double tileArea = W * L;

            NeededTiles = areaToCover / tileArea;
            TotalTime = NeededTiles * 0.2;
        }
    }
}
