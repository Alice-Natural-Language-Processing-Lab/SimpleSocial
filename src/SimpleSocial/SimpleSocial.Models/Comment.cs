﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleSocial.Models
{
    public class Comment
    {
        public string Id { get; set; }

        public string AuthorId { get; set; }

        public User Author { get; set; }

        public DateTime PostedOn { get; set; } = DateTime.UtcNow;

        public string CommentText { get; set; }

        [ForeignKey("Post")]
        public string PostId { get; set; }

        public Post Post { get; set; }
    }
}