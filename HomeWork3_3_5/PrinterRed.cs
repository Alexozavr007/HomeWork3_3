namespace HomeWork3_3_5 {

    internal class PrinterRed : Printer{

        public override void Print(string value) {
            var backupConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(value);
            Console.ForegroundColor = backupConsoleColor;
        }

    }

}
