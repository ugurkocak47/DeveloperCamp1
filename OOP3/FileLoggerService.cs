﻿namespace OOP3
{
    internal class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Logged to the file");
        }
    }
}
