using Pyramid.Block;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Ground
{
    public interface IGround
    {
        void Init();

        bool SuccessFlag();

        bool CanFill(Point point);

        bool CanFill(Point[] points);

        void Fill(Point[] points, int v);

        bool FillBlock(IBlock[] blocks, Point point);

        void Print();
    }
}
