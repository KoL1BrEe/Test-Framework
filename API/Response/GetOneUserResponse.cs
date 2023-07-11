using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestLearning.DTO.Response
{
    public class GetOneUserResponse
    {
        public object StatusCode { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
    }
}
