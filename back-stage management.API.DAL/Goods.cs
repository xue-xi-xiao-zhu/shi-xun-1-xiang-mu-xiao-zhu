using System;
using System.Collections.Generic;
using back_stage_management_.API.Model;

namespace back_stage_management.API.DAL
{
    public class Goods
    {
        //实例化上下文
        GoodsContext db = new GoodsContext();
public List<Goods> GetStudents()
        {
            var sql = from s in db.Book
                      orderby s.GId
                      select s;
            return sql.ToList();
        }
    }
}
