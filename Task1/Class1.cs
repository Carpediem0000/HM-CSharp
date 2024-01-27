namespace Task1
{
    public class Task
    {
        public string Description { get; set; }
        public string Status { get; set; }
        public Task(string description)
        {
            Description = description;
            Status = "Не выполнено!";
        }
    }

    public class Goal:Task
    {
        public DateOnly DeadLine { get; set; }
        public Goal(string description, DateOnly deadLine) : base(description)
        {
            DeadLine = deadLine;
        }
    }

    public class Human
    {
        public string Name { get; set; }
        public Task[] Tasks { get; set; }
        public Goal[] Goals { get; set; }

        public Human(string name, Task[] tasks, Goal[] goals)
        {
            Name = name;
            Tasks = tasks;
            Goals = goals;
        }

        public void AddTask(Task task)
        {
            if (task != null)
            {
                Tasks.Append(task);
                return;
            }
            Console.WriteLine("Error! Task not found!");
        }

        public void AddGoal(Goal goal)
        {
            if (goal != null)
            {
                Goals.Append(goal);
                return;
            }
            Console.WriteLine("Error! Goal not found!");
        }

        public void RealiseTask(int ind)
        {
            if (ind >= 0 && ind < Tasks.Length)
            {
                Tasks[ind].Status = "Выполнено!";
            }
        }
        public void RealiseGoal(int ind)
        {
            if (ind >= 0 && ind < Goals.Length)
            {
                Goals[ind].Status = "Выполнено!";
            }
        }
        public void RemoveTask(int ind)
        {
            if (ind >= 0 && ind < Tasks.Length)
            {
                Task[] tmp = new Task[Tasks.Length-1];
                for (int i = 0, j = 0; i < Tasks.Length; i++)
                {
                    if (i == ind){continue;}
                    tmp[j] = Tasks[i];
                    j++;
                }
                Tasks = tmp;
            }
        }
        public void RemoveGoal(int ind)
        {
            if (ind >= 0 && ind < Goals.Length)
            {
                Goal[] tmp = new Goal[Goals.Length - 1];
                for (int i = 0, j = 0; i < Goals.Length; i++)
                {
                    if (i == ind) { continue; }
                    tmp[j] = Goals[i];
                    j++;
                }
                Goals = tmp;
            }
        }

        public override string ToString()
        {
            //string res = $"Name: {Name}\n";
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("------------- Tasks -------------");
            for (int i = 0; i < Tasks.Length; i++)
            {
                Console.Write($"{i + 1}. {Tasks[i].Description} - ");
                if (Tasks[i].Status == "Выполнено!")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{Tasks[i].Status}\n");
                    Console.ResetColor(); //
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{Tasks[i].Status}\n");
                    Console.ResetColor(); //
                }
            }
            Console.WriteLine("------------- Goals -------------");
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            for (int i = 0; i < Goals.Length; i++)
            {
                Console.Write($"{i + 1}. {Goals[i].Description} - ");
                if (Goals[i].Status == "Выполнено!")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{Goals[i].Status}\n");
                    Console.ResetColor(); //
                }
                else
                {
                    if (Goals[i].DeadLine < today)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Просрочено!\n");
                        Console.ResetColor(); //
                        continue;
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{Goals[i].Status}\n");
                    Console.ResetColor(); //
                }
            }

            return "--------------------------------------------------------";
        }

    }
}
