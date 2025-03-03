using System.Net.Http.Json;
using System.Net.Mime;
using System.Text.Json;

HttpClient httpClient = new HttpClient();
Client client = new Client()
{
    City = "ffdg",
    Firstname="fgfd",
    Surname="fdg",
    Lastname="fgdg",
    Company="fdgd",
    Phone="67-67-56"
};
//string json = JsonSerializer.Serialize(client);
JsonContent content = JsonContent.Create(client);
//StringContent content = new StringContent(json);
content.Headers.Add("table", "client");
//using var request = new HttpRequestMessage(HttpMethod.Post, "http://127.0.0.1:8888/connection/");
//request.Content = content;

using var response = await httpClient.PostAsync("http://127.0.0.1:8888/connection/",content);
string responseText = await response.Content.ReadAsStringAsync();
Console.WriteLine(responseText);

class Client
{
    public int Clientid { get; set; }
    public string Firstname { get; set; } = null!;
    public string? Surname { get; set; }
    public string Lastname { get; set; } = null!;
    public string Company { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string City { get; set; } = null!;
}
