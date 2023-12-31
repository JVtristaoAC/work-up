﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WorkUp.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }

        public Activity() { }

        public Activity(int id, string title, string description, Priority priority)
        {
            Id = id;
            Title = title;
            Description = description;
            Priority = priority;
        }
    }
}
