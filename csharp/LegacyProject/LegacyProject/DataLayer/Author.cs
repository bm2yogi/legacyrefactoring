namespace LegacyProject.DataLayer
{
    public class Author
    {
        public int Id;
        public string Name;
        public string Email;
        public bool IsActive;

        public Author(int id, string name, string email, bool isActive)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.IsActive = isActive;
        }
    }
}