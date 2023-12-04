namespace Sample.Domain
{
    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get;private set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

    }
}
