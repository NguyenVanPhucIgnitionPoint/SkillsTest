using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using SkillsTest.Data;

namespace SkillsTest.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Content { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
