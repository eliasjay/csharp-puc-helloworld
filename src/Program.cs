using System;
using System.Collections.Generic;

namespace trabalho1
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> preRequestsList = new List<int> { 1, 2, 3 };

      Subject subTest = new Subject(
        "Matematica", 
        preRequestsList,
        3, 
        2, 
        5, 
        40, 
        50
      );

      subTest.print(subTest);

      List<Subject> subjects = new List<Subject>{};
      subjects.Add(subTest);

      Period period = new Period(subjects);
    }
  }
}
