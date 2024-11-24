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
