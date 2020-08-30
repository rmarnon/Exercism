using System;
using System.Collections.Generic;

public class Robot
{
    private static readonly HashSet<string> ListRobotNames = new HashSet<string>();
    private readonly Random values = new Random();

    public string Name { get; set; }

    public Robot()
    {
        CreateRobot();
    }

    public void Reset()
    {
        ListRobotNames.Remove(Name);
        CreateRobot();
    }

    public void CreateRobot()
    {
        bool insert = false;

        while (!insert)
        {
            Name = "";

            for (int i = 0; i < 5; i++)
            {
                if (i < 2)
                    Name += Convert.ToChar(values.Next(65, 91));
                else
                    Name += Convert.ToChar(values.Next(48, 58));
            }

            insert = (!ListRobotNames.Contains(Name)) ? true : false;

            if (insert)
                ListRobotNames.Add(Name);            
        }      
    }
}