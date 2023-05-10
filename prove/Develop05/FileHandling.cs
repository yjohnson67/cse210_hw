using System;
using System.Collections.Generic;
using System.IO;

namespace Developer5
{
    public class FileHandling
    {
        public List<Goal> LoadGoalsFromFile()
        {
            List<Goal> goals = new List<Goal>();
            Console.WriteLine("Enter file name:");
            string loadFileName = Console.ReadLine();

            if (File.Exists(loadFileName))
            {
                 Console.WriteLine($"Loading goals from file: {loadFileName}");
                //string[] data = File.ReadAllLines(loadFileName);
                string[] filedata = File.ReadAllLines(loadFileName);
                foreach (string line in filedata)
                {
                    string[] info = line.Split("|");

                        //bool isCompleted = book.Parese(info[4]);
                        bool isCompleted = bool.Parse(info[4]);

                        string goalType = info[0];
                        switch (goalType)
                        {
                            case "ChecklistGoal":
                                // Get the name, description, points, target, and bonus from the file
                                string checklistName = info[1];
                                string checklistDescription = info[2];
                                int checklistPoints = int.Parse(info[3]);
                                int checklistTarget = int.Parse(info[5]);
                                int checklistBonus = int.Parse(info[6]);

                               // Create a new ChecklistGoal object and add it to the goals list
                                ChecklistGoal newChecklistGoal = new ChecklistGoal(checklistName, checklistDescription, checklistPoints, isCompleted, checklistTarget, checklistBonus);
                                goals.Add(newChecklistGoal);
                                break;

                            case "EternalGoal":
                                // Get the name, description, and points from the file
                                string eternalName = info[1];
                                string eternalDescription = info[2];
                                int eternalPoints = int.Parse(info[3]);

                                // Create a new EternalGoal object and add it to the goals list
                                EternalGoal newEternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints, isCompleted);
                                goals.Add(newEternalGoal);
                                break;

                            case "ProgressGoal":
                                // Get the name, description, points, target, and progress from the file
                                string progressName = info[1];
                                string progressDescription = info[2];
                                int progressPoints = int.Parse(info[3]);
                                int progressTarget = int.Parse(info[5]);
                                int progressProgress = int.Parse(info[6]);

                                // Create a new ProgressGoal object and add it to the goals list
                                ProgressGoal newProgressGoal = new ProgressGoal(progressName, progressDescription, progressPoints, isCompleted, progressTarget, progressProgress);
                                goals.Add(newProgressGoal);
                                break;

                            case "NegativeGoal":
                                 // Get the name, description, points, and penalty from the file
                                string negativeName = info[1];
                                string negativeDescription = info[2];
                                int negativePoints = int.Parse(info[3]);
                                int negativePenalty = int.Parse(info[5]);

                                // Create a new NegativeGoal object and add it to the goals list
                                NegativeGoal newNegativeGoal = new NegativeGoal(negativeName, negativeDescription, negativePoints, isCompleted, negativePenalty);
                                goals.Add(newNegativeGoal);
                                break;

                            case "SimpleGoal":
                                // Get the name, description, and points from the file
                                string simpleName = info[1];
                                string simpleDescription = info[2];
                                int simplePoints = int.Parse(info[3]);

                                // Create a new SimpleGoal object and add it to the goals list
                                SimpleGoal newSimpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints, isCompleted);
                                goals.Add(newSimpleGoal);
                                break;
                            default:
                                Console.WriteLine("Can not find goal.");
                                break;
                        }
                }
            }
            else
            {
                Console.WriteLine($"File does not exist: {loadFileName}");
            }

            return goals;
        }

        public void SaveGoals(List<Goal> goals)
        {
            Console.WriteLine("Enter file name:");
            string saveFileName = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(saveFileName))
            {
                foreach (Goal goal in goals)
                {
                    // Save the goal's data to the file
                    writer.WriteLine(goal.SaveData());
                }
            }
        }
    }
}