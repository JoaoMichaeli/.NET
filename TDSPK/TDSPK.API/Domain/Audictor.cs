using TDSPK.API.Domain.Enums;

namespace TDSPK.API.Domain
{
    public class Audictor
    {        
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        protected StatusType Status { get; set; }
    }
}
