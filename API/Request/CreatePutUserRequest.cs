﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTestLearning.DTO.Request
{
    public class CreatePutUserRequest
    {
        public string Name { get; set; }
        public string Job { get; set; }
        public int Id { get; set; }
    }
}