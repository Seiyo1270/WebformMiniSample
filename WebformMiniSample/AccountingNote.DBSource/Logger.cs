using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingNote.DBSource
{
public    class Logger
    {
        public static void WriteLog(Exception ex)
        {
            throw ex;
        }
    }
}
