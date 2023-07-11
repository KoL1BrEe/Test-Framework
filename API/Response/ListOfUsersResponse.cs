using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestLearning
{
    public partial class ListOfUsersResponse
    {
        public long Page { get; set; }
        public long PerPage { get; set; }
        public long Total { get; set; }
        public long TotalPages { get; set; }
        [JsonProperty("data")]
        public List<User> Users { get; set; }
    }

    public partial class User
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string first_Name { get; set; }
        public string last_Name { get; set; }
        public Uri Avatar { get; set; }
    }
}
