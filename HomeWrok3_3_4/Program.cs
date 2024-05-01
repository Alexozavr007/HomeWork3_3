using HomeWrok3_3_4;
using System.Text;

Console.OutputEncoding = UnicodeEncoding.Unicode;

DocumentWorker worker;

Console.Write("Введіть ключ: ");
var key = Console.ReadLine();

if (key == "123") {
    worker = new ProDocumentWorker();
} else if (key == "321"){
    worker = new ExpertDocumentWorker();
} else {
    worker = new DocumentWorker(); 
}

worker.OpenDocument();
worker.EditDocument();
worker.SaveDocument();