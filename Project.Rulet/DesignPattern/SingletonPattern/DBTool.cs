using Project.Rulet.Models.ContextClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Rulet.DesignPattern.SingletonPattern
{
    public class DBTool
    {
        public DBTool()
        {

        }
        static MyContext _dbInsteance;
        public static MyContext DBInstance 
        {
            get
            {
                if (_dbInsteance == null)
                {
                    _dbInsteance = new MyContext();
                }
                return _dbInsteance;
            }       
        }
    }
}
