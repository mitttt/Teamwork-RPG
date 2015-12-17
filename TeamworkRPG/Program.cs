using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamworkRPG.Player;
/* This is the initial state of the project of team Dezda */



class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        Player p = new Player(name);
    }
}

