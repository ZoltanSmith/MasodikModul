namespace Idojaras.Model.Weather
{
    internal static class WMOCodes
    {

        public enum WeatherCode
        {
            UNKNOWN = -1, // Ismeretlen időjárás
            CLEAR = 0, //	Clear sky
            CLOUDY = 1, //	Mainly clear, partly cloudy, and overcast 1,2,3
            FOG = 45, //	Fog and depositing rime fog 45,48
            DRIZZLE = 51, //	Drizzle: Light, moderate, and dense intensity 51,53,55,56,57
            RAIN = 61, //   Rain: Slight, moderate and heavy intensity 61,63,65,80,81,82,66,67
            SNOW = 71, //	Snow fall: Slight, moderate, and heavy intensity 71,73,75,77,85,86
            STORM = 95, //	Thunderstorm: Slight or moderate 95,96,99
        }

        /// <summary>
        /// WMO kódok konvertálása WeatherCode enum értékekre
        /// </summary>
        /// <param name="wmo"></param>
        /// <returns></returns>
        public static WeatherCode WMOToWeatherCode(int wmo)
        {
            switch (wmo)
            {
                case 0:
                    return WeatherCode.CLEAR;
                case 1:
                case 2:
                case 3:
                    return WeatherCode.CLOUDY;
                case 45:
                case 48:
                    return WeatherCode.FOG;
                case 51:
                case 53:
                case 55:
                case 56:
                case 57:
                    return WeatherCode.DRIZZLE;
                case 61:
                case 63:
                case 65:
                case 66:
                case 67:
                case 80:
                case 81:
                case 82:
                    return WeatherCode.RAIN;
                case 71:
                case 73:
                case 75:
                case 77:
                case 85:
                case 86:
                    return WeatherCode.SNOW;
                case 95:
                case 96:
                case 99:
                    return WeatherCode.STORM;
                default:
                    return WeatherCode.UNKNOWN;
            }
        }
    }
}
