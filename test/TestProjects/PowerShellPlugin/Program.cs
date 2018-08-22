﻿using System;
using System.Management.Automation;

namespace PowerShellPlugin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetGreeting());
        }

        public static string GetGreeting()
        {
            using (var ps = PowerShell.Create())
            {
                var results = ps.AddScript("Write-Output hello").Invoke();
                return results[0].ToString();
            }
        }
    }
}
