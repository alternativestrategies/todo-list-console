using System;
using console_mysql.Models;
using System.Linq;

namespace console_mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbcontext = new TodoContext();
            // Ex. 1
            var todo = dbcontext.TodoItem.ToList();
            foreach (var val in todo)
            {
                System.Console.WriteLine($"ID: {val.Id} Task: {val.Task} Done:{val.Status}");
            }
        }
    }
}
