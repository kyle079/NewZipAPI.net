namespace NewZipAPI;

public interface INewZipService
{
    Task<NewZipResponse> SubmitRequest(NewZipLeadRequest request);
}