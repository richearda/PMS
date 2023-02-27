namespace PMS_API.Models;

public class Request
{
    public int RequestId { get; set; }
    public DateTime DateRequested { get; set; }
    public DateTime PickUpDate { get; set; }
    public string Status { get; set; }
    public int RequestTypeId { get; set; }
    public virtual RequestType? RequestType { get; set; }
    public int PersonId { get; set; }
    public Person? Person { get; set; }
}
