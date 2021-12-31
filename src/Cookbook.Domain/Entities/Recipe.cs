using SQLite;

namespace Cookbook.Domain.Entities
{
    [Table("Recipes")]
    public sealed class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
