﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTodoList.Models
{
    public class TodoItem
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsDone { get; set; }
    }
}
