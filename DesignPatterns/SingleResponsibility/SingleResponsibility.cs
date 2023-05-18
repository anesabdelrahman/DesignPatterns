namespace DesignPatterns.SingleResponsibility
{
    public class SingleResponsibility
    {
        public Journal Journal;
        public JournalRepository JournalRepository;
        public SingleResponsibility()
        {
            Journal = new Journal();
            JournalRepository = new JournalRepository();
        }
    }

    public class Journal
    {
        private readonly List<string> _journals = new();
        public int Count = 0;

        public int AddJournal(string journal)
        {
            _journals.Add($"{++Count}: {journal}");
            return Count;
        }

        public void DeleteJournal(int index)
        {
            _journals.RemoveAt(index);
            Count--;
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, _journals);
        }
    }

    public class JournalRepository
    {
        public static void PersistJournal(Journal journal, string fileName, bool overwrite = false)
        {
            if (overwrite || !File.Exists(fileName))
                File.WriteAllText(fileName, journal.ToString());
        }
    }
}
