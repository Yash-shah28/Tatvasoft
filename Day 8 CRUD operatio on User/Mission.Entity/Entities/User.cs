using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Mission.Entity.Entities
{
    [Table("User")]
    public class User: BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("phone_number")]
        public string PhoneNumber { get; set; }

        [Column("email_address")]
        public string EmailAddress { get; set; }

        [Column("user_type")]
        public string UserType  { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("user_image")]
        public string UserImage {  get; set; } = string.Empty;

        [Column("is_deleted")]
        public bool IsDeleted { get; set; } = false;


    }
}
