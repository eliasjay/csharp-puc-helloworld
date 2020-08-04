using System;
using System.Collections.Generic;

namespace trabalho1
{
  class Period : IPrint
  {
    public int id { get; set; }
    public List<Subject> subjects { get; set; }
    private int totalNTheoricClasses { get; set; }
    private int totalNPraticClasses { get; set; }
    private int totalNCredits { get; set; }
    private double totalHoursClasses { get; set; }
    private double totalClockClasses { get; set; }
    private List<double> subjectHours { get; set; }

    public Period(int id, List<Subject> subjects)
    {
      this.id = id;
      this.subjects = subjects;
    }
    override public void print() { }

    public List<double> sumTotalSubjectsHours(List<Subject> subjects)
    {
      foreach (Subject subject in subjects)
      {
        try
        {
          this.totalClockClasses += subject.clockClasses;
        }
        catch (System.Exception exception)
        {
          new ErrorLog(exception);
          throw new ErrorHandler($"This subject ({subject}) doesn't have Clock Classes");
        }

        this.totalNTheoricClasses += subject.nTheoricClasses;
        this.totalNPraticClasses += subject.nPraticClasses;
        this.totalNCredits += subject.nCredits;
        this.totalHoursClasses += subject.hoursClasses;
      }

      subjectHours.Add(this.totalNTheoricClasses);
      subjectHours.Add(this.totalNPraticClasses);
      subjectHours.Add(this.totalNCredits);
      subjectHours.Add(this.totalHoursClasses);

      try
      {
        subjectHours.Add(this.totalClockClasses);
      }
      catch (System.Exception exception)
      {
        new ErrorLog(exception);
        throw new ErrorHandler("This period doesn't have a total of Clock Classes");
      }

      return subjectHours;
    }
  }
}