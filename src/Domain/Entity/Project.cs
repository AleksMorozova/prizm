namespace Domain.Entity
{
    // FIX: remove??
    public class Project : Item
    {
        public Project(string title, PersonName client, PersonName designer)
        {
            this.Title = title;
            this.Client = client;
            this.Designer = designer;
        }

        protected Project()
        {
        }

        public virtual string Title { get; set; }
        public virtual PersonName Client { get; set; }
        public virtual PersonName Designer { get; set; }
    }
}