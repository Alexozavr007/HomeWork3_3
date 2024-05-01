namespace HomeWrok3_3_4 {

    internal class DocumentWorker {
        
        public void OpenDocument() {
            Console.WriteLine("Документ відкритий");
        }

        public virtual void EditDocument() {
            Console.WriteLine("Редагування документа ДОСТУПНЕ у версії Про");
        }

        public virtual void SaveDocument() {
            Console.WriteLine("Збереження документа ДОСТУПНЕ у версії Про");
        }

    }

}