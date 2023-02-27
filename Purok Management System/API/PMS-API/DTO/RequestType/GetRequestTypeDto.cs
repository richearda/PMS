namespace PMS_API.DTO.RequestType
{
    public class GetRequestTypeDto
    {
        public int RequestTypeId { get; set; }
        public string RequestTypeName { get; set; }
        public bool IsActive { get; set; }
    }
}
