﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restfinity.Models.Content
{
    public class ForumPostRestModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }      
    }
}
