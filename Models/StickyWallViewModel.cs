namespace ToDo_list.Models
{
    public class StickyWallViewModel
    {
        public List<StickySection> Sections { get; set; }
    }

    public class StickySection
    {
        public string Title { get; set; }
        public List<string> Items { get; set; }
        public string Content { get; set; }
    }
}