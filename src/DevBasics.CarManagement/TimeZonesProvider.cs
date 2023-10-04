using System.Collections.Generic;

namespace DevBasics.CarManagement
{
    public static class TimeZonesProvider
    {
        public static IDictionary<string, int> GetTimeZones()
        {
            var timeZones = new Dictionary<string, int>
            {
                { "Europe/London", 0 },
                { "Europe/Lisbon", 0 },
                { "America/Noronha", 120 },
                { "Atlantic/South_Georgia", 120 },
                { "America/Argentina/Buenos_Aires", 180 },
                { "America/Sao_Paulo", 180 },
                { "America/Godthab", 180 },
                { "America/St_Johns", 210 },
                { "America/Halifax", 240 },
                { "America/Aruba", 240 },
                { "America/New_York", 300 },
                { "EST", 300 },
                { "America/Chicago", 360 },
                { "America/Mexico_City", 360 },
                { "America/Phoenix", 420 },
                { "America/Santa_Isabel", 480 },
                { "America/Vancouver", 480 },
                { "America/Los_Angeles", 480 },
                { "America/Anchorage", 540 },
                { "America/Yakutat", 540 },
                { "Pacific/Honolulu", 600 },
                { "Europe/Berlin", -60 },
                { "Europe/Bratislava", -60 },
                { "Europe/Bucharest", -120 },
                { "Europe/Istanbul", -120 },
                { "Asia/Kuwait", -180 },
                { "Asia/Muscat", -240 },
                { "Asia/Oral", -300 },
                { "Asia/Yekaterinburg", -300 },
                { "Asia/Kolkata", -330 },
                { "Asia/Omsk", -360 },
                { "Indian/Cocos", -390 },
                { "Asia/Pontianak", -420 },
                { "Asia/Bangkok", -420 },
                { "Asia/Singapore", -480 },
                { "Asia/Kuala_Lumpur", -480 },
                { "Australia/Perth", -480 },
                { "Asia/Shanghai", -480 },
                { "Asia/Tokyo", -540 },
                { "Asia/Seoul", -540 },
                { "Australia/Adelaide", -570 },
                { "Australia/Melbourne", -600 },
                { "Australia/Lord_Howe", -630 },
                { "Etc/GMT-11", -660 },
                { "Pacific/Auckland", -720 },
                { "Etc/GMT-13", -780 },
            };
            return timeZones;
        }
    }
}