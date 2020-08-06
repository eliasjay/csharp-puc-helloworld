using System;
using System.Collections.Generic;

namespace trabalho1
{
  class Course : IPrint
  {
    public String name {get; set;}
    public List<Period> periods {get; set;}

    override public void print<T>(T t){}
  }
}