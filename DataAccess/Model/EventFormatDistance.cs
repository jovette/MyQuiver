namespace MyQuiver.DataAccess.Model
{
    public class EventFormatDistance
    {
        public int EventFormatDistanceId { get; set; }

        public int Distance { get; set; }

        public bool Metric { get; set; }

        public int ArrowsPerEnd { get; set; }

        public int TotalEnds { get; set; }
    }
}
