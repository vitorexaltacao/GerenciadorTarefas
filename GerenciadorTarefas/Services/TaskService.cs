using System.Collections.Generic;
using GerenciadorTarefas.Models;

namespace GerenciadorTarefas.Services
{
    public class TaskService
    {
        private List<Task> tasks = new List<Task>();

        public void AddTask(string name, string description)
        {
            var task = new Task
            {
                Id = tasks.Count + 1,
                Name = name,
                Description = description,
                IsCompleted = false
            };
            tasks.Add(task);
        }

        public List<Task> GetTasks()
        {
            return tasks;
        }
    }
}
public void CompleteTask(int taskId)
{
    var task = tasks.Find(t => t.Id == taskId);
    if (task != null)
    {
        task.IsCompleted = true;
        Console.WriteLine($"Tarefa '{task.Name}' concluída!");
    }
    else
    {
        Console.WriteLine("Tarefa não encontrada.");
    }
}

public void RemoveTask(int taskId)
{
    var task = tasks.Find(t => t.Id == taskId);
    if (task != null)
    {
        tasks.Remove(task);
        Console.WriteLine($"Tarefa '{task.Name}' removida com sucesso!");
    }
    else
    {
        Console.WriteLine("Tarefa não encontrada.");
    }
}
