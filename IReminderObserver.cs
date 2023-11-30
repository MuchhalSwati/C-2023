namespace DesignPattern
{
    public interface IReminderObserver
    {
        void update(string reminders);
    }

    public class furnitureDept : IReminderObserver
    {
        public void update(string reminder)
        {
            Task.Delay(1000);
            //sending reminder
            Console.WriteLine($" sending reminder {reminder}");
        }
    }


    public class salesDept : IReminderObserver
    {
        public void update(string reminder)
        {
            Task.Delay(1000);
            //sending reminder
            Console.WriteLine($" sending reminder {reminder}");
        }
    }
}