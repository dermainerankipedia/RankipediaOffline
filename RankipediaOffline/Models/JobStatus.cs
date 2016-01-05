namespace RankipediaOffline.Models
{
    public class JobStatus
    {
        public int Value { get; set; }
        public string Text { get; set; }

        public JobStatus()
        {
            
        }

        public JobStatus(int value, string text)
        {
            Value = value;
            Text = text;
        }
    }
}