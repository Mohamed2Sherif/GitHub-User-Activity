namespace Github_UserActivity;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
public static class Utilites
{
    public static List<string> ParseJsonResponse(string jsonResponse)
    {
        var events = JsonConvert.DeserializeObject<JArray>(jsonResponse);
        var output = new List<string>();

        foreach (var eventItem in events)
        {
            string actorLogin = eventItem["actor"]["login"].ToString();
            string repoName = eventItem["repo"]["name"].ToString();
            string eventType = eventItem["type"].ToString();

            if (eventType == "PushEvent")
            {
                int commitCount = eventItem["payload"]["commits"].Count();
                output.Add($"Pushed {commitCount} commits to {repoName}");
            }
            else if (eventType == "CreateEvent")
            {
                output.Add($"Created repository {repoName}");
            }
            else if (eventType == "StarEvent")
            {
                output.Add($"Starred {repoName}");
            }
            else if (eventType == "IssueEvent")
            {
                output.Add($"Opened a new issue in {repoName}");
            }
        }

        return output;
    }
}