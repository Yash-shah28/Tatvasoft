namespace Mission.Entity.Model
{
    public class UserRequestModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string UserImage {  get; set; }
        public DateTime? ModifiedDate {  get; set; } = DateTime.UtcNow;
    }
}
