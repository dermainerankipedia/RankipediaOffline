namespace RankipediaOffline.Models
{
    public class ListTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ListTypeViewModel(int id,string name)
        {
            Id = id;
            Name = name;
        }
    }
}