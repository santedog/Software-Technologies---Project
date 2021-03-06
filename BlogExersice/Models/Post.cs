﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogExersice.Models
{
    public class Post
    {
        public Post()
            {
            this.Date = DateTime.Now;
            this.Comments = new HashSet<Comment>();
            }   
      
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Body { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public ApplicationUser Author { get; set; }
        public HashSet<Comment> Comments { get; private set; }
    }
}