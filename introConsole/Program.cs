using System;

namespace bangazon
{
  class Program
  {
    static void Main(string[] args)
    {
      // DateTime is the type of the purchaseData variable.
      string purchaseDate = DateTime.Now.ToString().Split(' ')[0];

      /*
          string is the type of the lastName variable. It
          tells the compiler that the lastName variable can
          ONLY hold a string value.
      */
      string lastName = "Smith";

      /*
          C# now supports implicitly typing of a variable. The
          type of the variable will be determined, by the
          compiler, at compile time.
      */
      var firstName = "Bill";

      /*
        The String.Format() function syntax allows you to
        build the final string, with placeholders, and
        then provide comma-delimited list of variables to
        use in the placeholders.
      */
      Console.WriteLine($"{firstName} {lastName} purchased on {purchaseDate}");
    }
  }
}