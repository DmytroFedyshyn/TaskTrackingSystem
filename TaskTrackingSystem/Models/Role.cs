﻿namespace TaskTrackingSystem.Models
{
    namespace TaskTrackingSystem.Models
    {
        public class Role
        {
            public int Id { get; set; }

            public required string Name { get; set; }

            public required ICollection<User> Users { get; set; }
        }
    }
}
