using System.ComponentModel.DataAnnotations;

namespace BlazorAppDemo.Entities
{
    public class PersonInfoEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public int Age { get; set; }
    }
}
