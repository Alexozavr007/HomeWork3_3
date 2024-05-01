using HomeWork3_3_5;
using System.Text;

Console.InputEncoding = UnicodeEncoding.Unicode;
Console.OutputEncoding = UnicodeEncoding.Unicode;

Console.Write("Введіть значення для друку: ");
var valueToPrint = Console.ReadLine();

var simplePrinter = new Printer();
simplePrinter.Print(valueToPrint);

var redPrinter = new PrinterRed();
redPrinter.Print(valueToPrint);

var bluePrinter = new PrinterBlue();
bluePrinter.Print(valueToPrint);