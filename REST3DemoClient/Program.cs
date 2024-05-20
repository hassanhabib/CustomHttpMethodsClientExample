using RESTFulSense.Clients;

namespace REST3DemoClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var restfulHttpClient = new RESTFulApiClient();
            restfulHttpClient.BaseAddress = new Uri("https://localhost:7119/");

            Student response =
                await restfulHttpClient.SendHttpRequestAsync<Student>(
                    method: "CUSTOM",
                    relativeUrl: "api/home",
                    cancellationToken: new CancellationToken());

            Console.WriteLine(response.Id);
        }
    }

    public class Student
    {
        public int Id { get; set; }
    }
}
