using DesignPatterns;

namespace DesignPatternsTests
{
    public class Tests
    {
        [Test]
        public void Test_AddingJournal_CountShouldIncrement()
        {
            var newJournal = "I am happy";
            var sut = new SingleResponsibility();
            var result = sut.Journal.AddJournal(newJournal);
           Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Test_AddingMultipleJournals_CountShouldIncrementAccordingly()
        {
            var sut = new SingleResponsibility();
            var newJournals = new [] {"I am happy", "I am awesome", "I worked out today!"};
            
            foreach (var newJournal in newJournals)  sut.Journal.AddJournal(newJournal);


            Assert.That(sut.Journal.Count, Is.EqualTo(newJournals.Length));
        }

        [Test]
        public void Test_RemovingSingleJournal_CountShouldDecrementAccordingly()
        {
            var sut = new SingleResponsibility();
            var newJournals = new[] { "I am happy", "I am awesome", "I worked out today!" };
            
            foreach (var newJournal in newJournals) sut.Journal.AddJournal(newJournal);

            sut.Journal.DeleteJournal(1);
           
            Assert.That(sut.Journal.Count, Is.EqualTo(newJournals.Length-1));
        }
    }
}
