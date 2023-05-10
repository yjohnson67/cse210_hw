using System;
using System.Collections.Generic;
using System.IO;

namespace Developer5
{
    public class GoalTrackerApp
    {
        private List<Goal> goals = new List<Goal>();
        private int totalPoints;
        FileHandling fileHandling = new FileHandling();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create new goal");
                Console.WriteLine("2. List goals");
                Console.WriteLine("3. Save goals");
                Console.WriteLine("4. Load goals");
                Console.WriteLine("5. Record event");
                Console.WriteLine("6. Quit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("What kind of goal would you like to create?");
                        Console.WriteLine("1. Simple goal");
                        Console.WriteLine("2. Eternal goal");
                        Console.WriteLine("3. Checklist goal");
                        Console.WriteLine("4. Progress goal");
                        Console.WriteLine("5. Negative goal");
                        string goalChoice = Console.ReadLine();

                        Goal newGoal;
                        switch (goalChoice)
                        {
                            case "1":
                                // Create a new instance of SimpleGoal
                                newGoal = new SimpleGoal(" ", " ", 0);
                                newGoal.GetGoalInfo();
                                goals.Add(newGoal);
                                break;

                            case "2":
                                // Create a new instance of EternalGoal
                                newGoal = new EternalGoal(" ", " ", 0);
                                newGoal.GetGoalInfo();
                                goals.Add(newGoal);
                                break;

                            case "3":
                                // Create a new instance of ChecklistGoal
                                newGoal = new ChecklistGoal(" ", " ", 0, 0, 0);
                                newGoal.GetGoalInfo();
                                Console.WriteLine("What is the target amount?");
                                int target = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the bonus amount?");
                                int bonus = int.Parse(Console.ReadLine());

                                goals.Add(newGoal);
                                break;

                            case "4":
                                // Create a new instance of ProgressGoal
                                newGoal = new ProgressGoal(" ", " ", 0, false, 0, 0);
                                newGoal.GetGoalInfo();
                                Console.WriteLine("What is the target amount?");
                                target = int.Parse(Console.ReadLine());
                                Console.WriteLine("What is the current progress?");
                                int progress = int.Parse(Console.ReadLine());

                                goals.Add(newGoal);
                                break;

                            case "5":
                                // Create a new instance of NegativeGoal
                                newGoal = new NegativeGoal(" ", " ", 0, false, 0);
                                newGoal.GetGoalInfo();
                                Console.WriteLine("What is the penalty amount?");
                                int penalty = int.Parse(Console.ReadLine());

                                goals.Add(newGoal);
                                break;

                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("Goals:");
                        int counter = 1;
                        foreach (Goal goal in goals)
                        {
                            Console.WriteLine($"{counter}. {goal.DisplayGoal()}");
                            counter++;
                        }
                        break;

                    case "3":
                        fileHandling.SaveGoals(goals);
                        break;

                    case "4":
                        goals = fileHandling.LoadGoalsFromFile();
                        break;

                    case "5":
                        Console.WriteLine("Which goal would you like to record an event for?");
                        counter = 1;
                        foreach (Goal goal in goals)
                        {
                            Console.WriteLine($"{counter}. {goal.DisplayGoal()}");
                            counter++;
                        }
                        int goalIndex = int.Parse(Console.ReadLine()) - 1;
                        totalPoints = goals[goalIndex].RecordEvent();
                        Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
                        break;

                    case "6":
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}