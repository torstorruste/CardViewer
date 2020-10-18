using Newtonsoft.Json.Converters;

namespace CardViewer.Service {
    public class DateTimeConverter : IsoDateTimeConverter
    {
        public DateTimeConverter()
        {
            base.DateTimeFormat = "yyyy-MM-dd";
        }
    }

}