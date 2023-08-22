namespace MVCViewProject.ViewModels;

public class Error
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrWhiteSpace(value: this.RequestId);
}