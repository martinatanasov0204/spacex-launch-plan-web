namespace SpaceX.Launch.Plan.Web.Models
{
    /// <summary>
    /// Represents an error view model.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Request ID
        /// </summary>
        public string? RequestId { get; set; }

        /// <summary>
        /// Flag indicating whether to show the request ID or not
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
