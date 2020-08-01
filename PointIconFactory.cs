using System.Collections.Generic;
namespace pattern_flyweight
{
    public class PointIconFactory
    {
       private Dictionary<IconType, PointIcon> icons = new Dictionary<IconType, PointIcon>();

       public PointIcon GetPointIcon(IconType type) {
           if (!icons.ContainsKey(type)) {
               var icon = new PointIcon(type, null);
               icons.Add(type, icon);
           }
           return icons[type];
       }
    }
}