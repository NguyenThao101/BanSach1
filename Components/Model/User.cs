namespace BanSach.Components.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int status { get; set; }
        public string? img { get; set; }
        public string? Phone { get; set; }
        public int RoleId { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; }
        public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    }
}
