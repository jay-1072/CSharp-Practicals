using System;
using practical_3;

public class Program
{
    public static void Main(string[] args)
    {
        Team team = new Team();
        team.TeamName = "Team1";
        Console.WriteLine(team.PrintInfo());
    }
}