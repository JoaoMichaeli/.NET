using System.ComponentModel.DataAnnotations;

namespace TDSPK.API.Persistence
{
    public class Photo
    {
        [Key]
        public Guid Id { get; private set; }

        [Required]
        public User User { get; private set; }

        [Required]
        public string Url { get; private set; }

        public int Lenght { get; set; }

        public DateTime Date { get; private set; }

        public Photo(string url, User user)
        {
            if (url == string.Empty) throw new Exception();

            Id = Guid.NewGuid();
            Date = DateTime.Now;
            Url = url;

            User = user;
        }

    }
}
