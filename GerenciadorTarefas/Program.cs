using System;
using GerenciadorTarefas.Services;

class Program
{
    static void Main(string[] args)
    {
        var taskService = new TaskService();

        taskService.AddTask("Estudar C#", "Estudar a estrutura de um projeto em C#");
        taskService.AddTask("Praticar Git", "Fazer commits organizados");

        var tasks = taskService.GetTasks();

        Console.WriteLine("Tarefas:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task.Id}: {task.Name} - {(task.IsCompleted ? "Concluída" : "Pendente")}");
        }
    }
}

