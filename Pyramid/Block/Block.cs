using System;
using System.Collections.Generic;
using System.Text;

namespace Pyramid.Block
{
    public abstract class Block
    {
        public Block(int v, int u)
        {
            value = v;
            unitNum = u;
        }

        //  代表的数值
        public readonly int value;

        //  由几个单元（点）组成
        public readonly int unitNum;

        
        //  可以摆放成哪些平面形状
        protected Point[,] FlatShapes;
        
        //  可以摆放成哪些立体形状
        protected Point[][] Shape3D;

        public Point[] MoveShape3D(int s, Point point)
        {
            if (Shape3D == null)
                return null;

            if (s >= Shape3D.Length || s < 0)
            {
                return null;
            }

            Point[] points = new Point[unitNum];

            for (int i = 0; i < unitNum; ++i)
            {
                points[i] = Shape3D[s][i] + point;
            }

            return points;
        }

        public Point[] MoveShape(int s, Point point)
        {
            if (s < 0)
                return null;

            if (s < ShapeFlatCount())
                return MoveShapeFlat(s, point);

            return MoveShape3D(s - ShapeFlatCount(), point);
        }

        public int AllShapeCount()
        {
            int flatCount = ShapeFlatCount();

            if (Shape3D != null)
            {
                return flatCount + Shape3D.Length;
            }

            return flatCount;
        }

        public void Init(bool bZAsc)
        {
            if (Shape3D == null)
            {
                return;
            }

            int cnt = Shape3D.Length;

            for (int i = 0; i < cnt; ++i)
            {
                Region r = new Region(Shape3D[i]);
                r.Normalize(bZAsc);
            }
        }

        public int ShapeFlatCount()
        {
            if (FlatShapes != null && unitNum > 0)
            {
                return FlatShapes.Length / unitNum;
            }
            return 0;
        }

        public Point[] MoveShapeFlat(int s, Point point)
        {
            if (FlatShapes != null && 0 <= s && s < ShapeFlatCount())
            {
                Point[] points = new Point[unitNum];

                for (int i = 0; i < unitNum; ++i)
                {
                    points[i] = FlatShapes[s, i] + point;
                }

                return points;
            }

            return null;
        }
    }
}
