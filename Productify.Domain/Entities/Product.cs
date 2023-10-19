namespace Productify.Domain.Entities
{
    public class Product
    {
        public Product(Guid ıd, string name, DateTime createdOn)
        {
            Id = Guid.NewGuid();
            Name = name;
            CreatedOn = DateTime.Now;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedOn { get; set; }

    }
  
}