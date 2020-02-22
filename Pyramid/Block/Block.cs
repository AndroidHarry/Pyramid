using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public interface IBlock
    {
        //  代表的数值
        int Value { get; }

        //  由几个单元（点）组成
        int UnitNum { get; }

        //  可以摆放成哪些平面形状
        Point[,] FlatShapes { get; }

        //  可以摆放成哪些立体形状
        Point[,] Shape3Ds { get; }
    }
}
