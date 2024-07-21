namespace AlarmsIOTSimulator
{
    public class AlarmEvent
    {
        public required string subject { get; set; }
        public required string id { get; set; }
        public required string eventType { get; set; }
        public required string eventTime { get; set; }
        public required AlarmItem data { get; set; }
    }
}
