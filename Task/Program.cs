namespace Task
{
    internal class Program
    {
        public static void RemoveLiveNotification(LinkedList<Notification> live, List<Notification> history)
        {
            Notification notf = live.First.Value;
            live.RemoveFirst();
            history.Add(notf);
        }

        static void Main(string[] args)
        {
            List<Notification> history = new List<Notification>();
            LinkedList<Notification> liveQueue = new LinkedList<Notification>();

            Notification no1 = new Notification { Message = "No.1", CreatedAt = DateTime.Now };
            Notification no2 = new Notification { Message = "No.2", CreatedAt = DateTime.Now.AddDays(1) };
            Notification no3 = new Notification { Message = "No.3", CreatedAt = DateTime.Now.AddDays(2) };
            Notification no4 = new Notification { Message = "No.4", CreatedAt = DateTime.Now.AddDays(3) };

            liveQueue.AddFirst(no1);
            liveQueue.AddFirst(no2);
            liveQueue.AddFirst(no3);
            liveQueue.AddFirst(no4);

            foreach (var n in liveQueue.Take(3))
            {
                Console.WriteLine(n);
                Console.WriteLine("---------------------------------");
            }

            RemoveLiveNotification(liveQueue, history);

            Console.WriteLine(history.Count);
        }
    }
}
