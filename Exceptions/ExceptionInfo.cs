using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_Interfejsy
{
    static class ExceptionInfo
    {
        public static void ShowException(Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\n*** ERROR! ***");
            if (ex is SystemException)
            {
                Console.WriteLine("System exception.");
            }
            else
            {
                Console.WriteLine("Application exception");
            }
            Console.WriteLine("Message: {0}", ex.Message);
            Console.WriteLine("Member name: {0}", ex.TargetSite);
            Console.WriteLine("Class defining member: {0}", ex.TargetSite.DeclaringType);
            Console.WriteLine("Member type: {0}", ex.TargetSite.MemberType);
            Console.WriteLine("Source: {0}", ex.Source);
            Console.WriteLine("StackTrace: {0}", ex.StackTrace);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
