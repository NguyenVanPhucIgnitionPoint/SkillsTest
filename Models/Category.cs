using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SkillsTest.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
    }
}
