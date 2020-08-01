using System.Collections;
using System.Collections.Generic;

namespace pattern_flyweight
{
    public class PointService
    {
        private PointIconFactory factory;

        public PointService(PointIconFactory factory)
        {
            this.factory = factory;
        }

        public IList<Point> GetPoints() {
            IList<Point> points = new List<Point>();
            var point = new Point(1,2, factory.GetPointIcon(IconType.CAFE));
            points.Add(point);
            return points;
        }
    }
}