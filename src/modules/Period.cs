using System;
using System.Collections.Generic;

namespace trabalho1
{
  class Period : IPrint
  {
    public int id { get; set; }
    public List<Subject> subjects { get; set; }
    private int totalNTheoricClasses
    {
      get
      {
        int total = 0;

        foreach (Subject subject in subjects)
        {
          total += subject.nTheoricClasses;
        }

        return total;
      }
    }
    private int totalNPraticClasses
    {
      get
      {
        int total = 0;

        foreach (Subject subject in subjects)
        {
          total += subject.nPraticClasses;
        }

        return total;
      }
    }
    private int totalNCredits
    {
      get
      {
        int total = 0;

        foreach (Subject subject in subjects)
        {
          total += subject.nCredits;
        }

        return total;
      }
    }
    private double totalHoursClasses
    {
      get
      {
        int total = 0;

        foreach (Subject subject in subjects)
        {
          total += subject.hoursClasses;
        }

        return total;
      }
    }
    private double totalClockClasses
    {
      get
      {
        int total = 0;

        foreach (Subject subject in subjects)
        {
          total += subject.clockClasses;
        }

        return total;
      }
    }

    public Period(int id, List<Subject> subjects)
    {
      this.id = id;
      this.subjects = subjects;
    }
    override public void print<T>(T t) {}
  }
}