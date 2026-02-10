using KozosResz.objects;

namespace KozosResz.extensions
{
    public static class ObjectExtension
    {
        public static string ToJson(this object obj) {
            //végig kellene iterálni a property-ken és string (json) alakítani
            //((Termek)obj).Nev; // nem tudom biztosan, h termek jön parameterként (bármijen object lehet)
            return obj.ToString();
        }

        public static bool IsNull(this object o) // kivételt fog dobni
        {
            return o.Equals(null);
        }

        public static bool IsNull2(this object o) // ez még belefér
        {
            return o == null;
        }

    }
}
