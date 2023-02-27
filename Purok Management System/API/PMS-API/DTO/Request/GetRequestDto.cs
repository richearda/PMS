using PMS_API.DTO.Person;
using PMS_API.DTO.RequestType;
using PMS_API.Models;

namespace PMS_API.DTO.Request
{
    public class GetRequestDto
    {
        public int RequestId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime PickUpDate { get; set; }
        public string Status { get; set; }
        public  GetRequestTypeDto RequestType { get; set; }
        //public GetPersonDto Person { get; set; }
    }
}
