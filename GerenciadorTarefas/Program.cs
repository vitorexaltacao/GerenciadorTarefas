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

using System;
using GerenciadorTarefas.Services;

class Program
{
    static void Main(string[] args)
    {
        var taskService = new TaskService();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nGerenciador de Tarefas");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Listar Tarefas");
            Console.WriteLine("3. Concluir Tarefa");
            Console.WriteLine("4. Remover Tarefa");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Nome da tarefa: ");
                    var name = Console.ReadLine();
                    Console.Write("Descrição da tarefa: ");
                    var description = Console.ReadLine();
                    taskService.AddTask(name, description);
                    break;

                case "2":
                    var tasks = taskService.GetTasks();
                    Console.WriteLine("\nTarefas:");
                    foreach (var task in tasks)
                    {
                        Console.WriteLine($"{task.Id}: {task.Name} - {(task.IsCompleted ? "Concluída" : "Pendente")}");
                    }
                    break;

                case "3":
                    Console.Write("Digite o ID da tarefa para concluir: ");
                    if (int.TryParse(Console.ReadLine(), out int completeId))
                    {
                        taskService.CompleteTask(completeId);
                    }
                    else
                    {
                        Console.WriteLine("ID inválido.");
                    }
                    break;

                case "4":
                    Console.Write("Digite o ID da tarefa para remover: ");
                    if (int.TryParse(Console.ReadLine(), out int removeId))
                    {
                        taskService.RemoveTask(removeId);
                    }
                    else
                    {
                        Console.WriteLine("ID inválido.");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    break;
            }
        }
    }
}

