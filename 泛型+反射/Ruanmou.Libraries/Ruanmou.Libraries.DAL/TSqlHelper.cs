using Ruanmou.Framework.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ruanmou.Framework.AttributeExtend;

namespace Ruanmou.Libraries.DAL
{
    public class TSqlHelper<T> where T : BaseModel
    {
        static TSqlHelper()
        {
            Type type = typeof(T);
            string columnString = string.Join(",", type.GetProperties().Select(p => $"[{p.GetColumnName()}]"));
            var updateColumns = type.GetProperties().Where(x => !x.Name.Equals("Id")).ToList();
            string updateColumnString = string.Join(",", updateColumns.Select(p => $"[{p.GetColumnName()}]"));
            string columnSetString = string.Join(",", updateColumns.Select(p => $"[{p.GetColumnName()}=@{p.GetColumnName()}]"));
            FindSql = $"SELECT {columnString} FROM [{type.Name}] WHERE Id=";
            FindAllSql = $"SELECT {columnString} FROM [{type.Name}];";
            DeleteSql = $"DELETE FROM [{type.Name}] WHERE Id = ";
            UpdateSql = $"UPDATE [{type.Name}] SET {columnSetString} WHERE Id = ";
            InsertSql = $"INSERT INTO [{type.Name}] ({updateColumnString}) VALUES ";
        }

        public static string FindSql;
        public static string FindAllSql;
        public static string DeleteSql;
        public static string UpdateSql;
        public static string InsertSql;
        //delete  update  insert 
    }
}
