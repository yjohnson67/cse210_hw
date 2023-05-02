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
            string[] data = File.ReadAllLines(loadFileName);
            foreach (string line in data)
            {
                string[] info = line.Split("|");
                bool isCompleted = bool.Parse(info[4]);
                string goalType = info[0];
                switch (goalType)
                {
                    case "ChecklistGoal":
                        //create new type goal
                        // pass in the corresponding info[] data
                        // add the goal to the lists
                        string checklistName = info[1];
                        string checklistDescription = info[2];
                        int checklistPoints = int.Parse(info[3]);
                        int checklistTarget = int.Parse(info[5]);
                        int checklistBonus = int.Parse(info[6]);
                        ChecklistGoal newChecklistGoal = new ChecklistGoal(info[1], checklistDescription, checklistPoints, isCompleted, checklistTarget, checklistBonus);
                        goals.Add(newChecklistGoal);
                        break;

                    case "EternalGoal":
                        string eternalName = info[1];
                        string eternalDescription = info[2];
                        int eternalPoints = int.Parse(info[3]);
                        EternalGoal newEternalGoal = new EternalGoal(eternalName, eternalDescription, eternalPoints, isCompleted);
                        goals.Add(newEternalGoal);
                        break;

                    default:
                        string simpleName = info[1];
                        string simpleDescription = info[2];
                        int simplePoints = int.Parse(info[3]);
                        SimpleGoal newSimpleGoal = new SimpleGoal(simpleName, simpleDescription, simplePoints, isCompleted);
                        goals.Add(newSimpleGoal);
                        break;
                }
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
                    writer.WriteLine(goal.SaveData());
                }
            }
        }
    }
}