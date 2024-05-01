namespace HomeWork3_3_5 {

    internal class PrinterBlue : Printer {

        public override void Print(string value) {
            var backupConsoleColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
            Console.ForegroundColor = backupConsoleColor;
        }

    }

}
