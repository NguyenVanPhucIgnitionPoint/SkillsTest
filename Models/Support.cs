using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SkillsTest.Data;

namespace SkillsTest.Models
{
    public class Support
    {
        SkillsTestContext db = null;
        public Support()
        {
            db = new SkillsTestContext();
        }
        public List<Answer> ListAll()
        {
            return db.Answers.ToList();
        }
    }
}
