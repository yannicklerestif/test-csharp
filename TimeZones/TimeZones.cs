using System;
using System.Linq;

namespace TimeZones
{
    public class TimeZoneDescriptor
    {
        public string Id;
        public string Name;
    }

    class TimeZones
    {
        // see http://stackoverflow.com/questions/17348807/how-to-translate-between-windows-and-iana-time-zones
        public static string WindowsToIana(string windowsZoneId)
        {
            if (windowsZoneId.Equals("UTC", StringComparison.Ordinal))
                return "Etc/UTC";

            var tzdbSource = NodaTime.TimeZones.TzdbDateTimeZoneSource.Default;
            var tzi = TimeZoneInfo.FindSystemTimeZoneById(windowsZoneId);
            if (tzi == null) return null;
            var tzid = tzdbSource.MapTimeZoneId(tzi);
            if (tzid == null) return null;
            return tzdbSource.CanonicalIdMap[tzid];
        }

        static void Main(string[] args)
        {
            var timeZones = TimeZoneInfo.GetSystemTimeZones().Select(tz => new TimeZoneDescriptor { Id = tz.Id, Name = tz.DisplayName }).ToArray();

            var firstLine = true;
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\cbs\bb\banners\banners\Criteo.Design\DesignTool\js\timeZone\timeZones.js"))
            {
                file.WriteLine("//This file was generated. Do not edit it. Instead re-generate it using attached .cs script.");
                file.WriteLine("export default [");
                foreach (TimeZoneDescriptor tzd in timeZones)
                {
                    if (firstLine)
                    {
                        firstLine = false;
                    }
                    else
                    {
                        file.WriteLine(",");
                    }
                    file.Write("    {{id: '{0}', name: '{1}', ianaId: '{2}'}}", tzd.Id, tzd.Name, WindowsToIana(tzd.Id));
                }
                file.WriteLine();
                file.WriteLine("];");
            }
        }
    }
}
