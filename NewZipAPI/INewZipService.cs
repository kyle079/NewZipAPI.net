namespace NewZipAPI;

/// <summary>
/// Interface for the NewZip service.
/// </summary>
public interface INewZipService
{
    /// <summary>
    /// Submits a lead to the NewZip service asynchronously.
    /// </summary>
    /// <param name="request">The lead request to submit.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the NewZip response.</returns>
    Task<NewZipResponse> SubmitLeadAsync(NewZipLeadRequest request);
}