﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VQServer.Models
{
    public class Queues
    {
        public int queueId { get; set; }
        public string locationName { get; set; }
        public string locationPlace { get; set; }
        public int managerId { get; set; }
    }
}