namespace DesignPattern
{
    public class ReminderSubject
    {
        private List<IReminderObserver> observers = new List<IReminderObserver> ();

        public void AddObserver(IReminderObserver observer)
        {
            observers.Add(observer);
        }

        public void AddReminder(string reminder)
        {
            foreach (IReminderObserver observer in observers)
            {
                observer.update(reminder);
            }
            
        }


    }
}
