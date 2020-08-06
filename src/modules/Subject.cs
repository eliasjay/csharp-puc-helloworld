using System;
using System.Collections.Generic;

namespace trabalho1
{
  class Subject : IPrint
  {
    public int id { get; set; }
    public String name { get; set; }
    public List<int> preRequests { get; set; }
    public int nTheoricClasses { get; set; }
    public int nPraticClasses { get; set; }
    public int nCredits { get; set; }
    public int hoursClasses { get; set; }
    public int clockClasses { get; set; }

    override public void print() { }
  }
}