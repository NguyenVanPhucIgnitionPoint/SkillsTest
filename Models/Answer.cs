using System;
using System.ComponentModel.DataAnnotations;

namespace SkillsTest.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public bool Status { get; set; }
    }
}
