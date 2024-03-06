namespace EntityFrameworkCoreRelation.Entities
{
    public class Backpack
    {
        public int Id { get; set; }
        public string Description { get; set; }


        //Relationship to Parent
        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
