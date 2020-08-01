namespace pattern_flyweight
{
    public class PointIcon
    {
        public IconType type { get; } // 4 bytes
        public byte[] icon { get; } // 20 KB ==> 20MB

        public PointIcon(IconType type, byte[] icon)
        {
            this.type = type;
            this.icon = icon;
        }

    }
}