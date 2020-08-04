using System;
using System.IO;

namespace trabalho1
{
  class ErrorLog
  {
    private String path = @"./log/errors.txt";
    public ErrorLog(Exception errorLog)
    {
      FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
      StreamWriter sw = new StreamWriter(fs);

      sw.WriteLine(errorLog);
      sw.Flush();
      sw.Close();
      
      fs.Close();
    }
  }
}