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

        protected Point[] MoveShape3D(int s, Point point)
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

        private Region[] FlatRegion {
            get {
                CheckCreateFlatRegion();
                return _flatRegions;
            }
        }

        public int ShapeFlatCount()
        {
            if (FlatRegion != null)
            {
                return FlatRegion.Length;
            }
            return 0;
        }

        public Point[] MoveShapeFlat(int s, Point point)
        {
            if (FlatRegion != null && 0 <= s && s < FlatRegion.Length)
            {
                Point[] points = new Point[unitNum];
                Region rSrc = FlatRegion[s];

                for (int i = 0; i < rSrc.points.Length; ++i)
                {
                    points[i] = rSrc.points[i] + point;
                }

                return points;
            }

            return null;
        }

        private void CheckCreateFlatRegion()
        {
            if (_flatRegions == null)
            {
                if (FlatShapes != null && unitNum > 0)
                {
                    int cnt = FlatShapes.Length / unitNum;

                    _flatRegions = new Region[cnt];

                    for (int i = 0; i < cnt; ++i)
                    {
                        Point[] pts = new Point[unitNum];
                        for (int j = 0; j < unitNum; ++j)
                        {
                            pts[j] = new Point(FlatShapes[i, j]);
                        }
                        _flatRegions[i] = new Region(pts);
                    }
                }
            }
        }

        private Region[] _flatRegions;
    }
}
