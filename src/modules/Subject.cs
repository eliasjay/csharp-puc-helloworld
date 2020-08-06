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

    public Subject(
      String name,
      List<int> preRequests,
      int nTheoricClasses,
      int nPraticClasses,
      int nCredits,
      int hoursClasses,
      int clockClasses
    )
    {
      this.name = name;
      this.preRequests = preRequests;
      this.nTheoricClasses = nTheoricClasses;
      this.nPraticClasses = nPraticClasses;
      this.nCredits = nCredits;
      this.hoursClasses = hoursClasses;
      this.clockClasses = clockClasses;
    }

    override public void print<Subject>(Subject subject)
    {
      Console.WriteLine($"Name: {name}");
      Console.WriteLine("Pre Requests: " + String.Join(", ", preRequests));
      Console.WriteLine($"Theorical Classes: {nTheoricClasses}");
      Console.WriteLine($"Pratical Classes: {nPraticClasses}");
      Console.WriteLine($"Credits: {nCredits}");
      Console.WriteLine($"Hours Classes: {hoursClasses}");
      Console.WriteLine($"Clock Classes: {clockClasses}");
    }
  }
}