namespace pattern_flyweight
{
    public class Point
    {
        private int x;
        private int y;
        private IconType type;
        private byte[] icon;

        public Point(int x, int y, IconType type, byte[] icon)
        {
            this.x = x;
            this.y = y;
            this.type = type;
            this.icon = icon;
        }
    }
}