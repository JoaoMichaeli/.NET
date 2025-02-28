using TDSPK.API.Domain.Enums;

namespace TDSPK.API.Persistence
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public StatusType Status { get; }

        public User()
        {
            Status = StatusType.Active;
        }
    }
}
