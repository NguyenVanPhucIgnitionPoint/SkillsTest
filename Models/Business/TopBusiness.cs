using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SkillsTest.Data;
using SkillsTest.Models;

namespace SkillsTest.Models.Business
{
    public class TopBusiness
    {
        //private readonly SkillsTestContext context;
        public TopBusiness()
        {
        }

        [System.Obsolete]
        public async Task<Answer> GetListAnswer(int id)
        {
            using (var context = new SkillsTestContext())
            {
                var sqlParams = new SqlParameter[]
                {
                    new SqlParameter {ParameterName = "@id", Value = id,  DbType = DbType.Int32 , Direction = ParameterDirection.Input }
                };
                var answers = await context.Query<Answer>()
                                        .FromSql("EXECUTE dbo.GetAnswersByQuestionId @id", sqlParams)
                                        .FirstOrDefaultAsync();
                return answers;
            }
        }
    }
}
