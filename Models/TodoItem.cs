using Humanizer;

namespace TODOAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        public int Age { get; set; }

        public Gender Gender { get; set; } 

        public string Email { get; set; } = string.Empty;

        public string password { get; set; } = string.Empty;
        public bool IsComplete { get; set; }
    }
}
