namespace Github_UserActivity;
using System.CommandLine;
using System.Net.Http;
public class program
{
    public async static Task Main(string[] args)
    {
        
        var rootcommoand = new RootCommand();
        var user = new Argument<string>("UserName", "Provide the UserName on GitHub");
        rootcommoand.AddArgument(user);

        rootcommoand.SetHandler(async (userArgument) =>
        {
            using HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.UserAgent.Add(new System.Net.Http.Headers.ProductInfoHeaderValue("Github-UserActivity", "1.0"));
            HttpResponseMessage response =await client.GetAsync($"https://api.github.com/users/{userArgument}/events" );
            response.EnsureSuccessStatusCode();
            string responsebody = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responsebody);
        },user);


    await rootcommoand.InvokeAsync(args);
    }
}