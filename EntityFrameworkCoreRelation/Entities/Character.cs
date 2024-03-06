namespace EntityFrameworkCoreRelation.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //Relationship to Child
        public int BackpackId { get; set; }
        public Backpack Backpack { get; set; }
    }
}
