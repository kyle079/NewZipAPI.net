# NewZipAPI .NET package

Basic .NET package for the vendor NewZip, allows you to interact with the NewZip API.

## Methods included:
- SubmitLeadAsync:
  - Will submit a lead to the NewZip API and return a response.

## Usage:
- NewZipService can be used with either Dependency Injection or without.
  - If using Dependency Injection, you can add the service to your services collection in your Startup.cs file.
  - This assumes you are storing your NewZip API key in your appsettings.json file under NewZip:ApiKey. Else it will default to the "demo" key.

## Testing:
- The NewZipService has been tested with xUnit. You can find the tests in the NewZipServiceTests.cs project.
- The test will submit a lead to the NewZip API and check the response using the demo token.

## Frameworks:
- .NET Standard 2.0
- .NET Standard 2.1