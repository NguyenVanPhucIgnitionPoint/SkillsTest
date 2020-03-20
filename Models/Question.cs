using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsTest.Models
{
    public class Question
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string Content { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
