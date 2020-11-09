using System.Text.Json.Serialization;

namespace AndriuhaAssignment.Models
{
    public class User
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        [JsonPropertyName("password")]
        public string Password { get; set; }
        [JsonPropertyName("id")]
        
        public int UserId { get; set; }
        [JsonPropertyName("securityLevel")]
        public int SecurityLevel { get; set; }
    }
}