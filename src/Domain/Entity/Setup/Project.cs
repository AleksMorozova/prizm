namespace Domain.Entity
{
    // FIX: remove??
    public class Project : Item
    {
        //public virtual string Title { get; set; }
        public virtual /*PersonName*/string Client { get; set; }
        public virtual /*PersonName*/string Designer { get; set; }
        public virtual int DocumentSizeLimit { get; set; }
    }
}