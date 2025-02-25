// Task 10: To-Do List Application
// Task: Create a TaskItem class with:
// Description, IsCompleted.
// Methods MarkComplete() and MarkIncomplete().
// Store multiple tasks in a list and allow users to add, remove, or mark tasks as complete.


using System;
using System.Collections.Generic;

class TaskItem {

    string _taskDescription;
    bool _taskIsCompleted;

    public string Description {
        get {return _taskDescription;}
        set {_taskDescription = value;}
    }
    public bool IsCompleted  {
        get{return _taskIsCompleted;}
        set {_taskIsCompleted = value;}
    }

    public TaskItem (string taskDescription) {
        _taskDescription = taskDescription;
        _taskIsCompleted = false;
    }

    public void MarkComplete () {
        if (_taskIsCompleted) {
            Console.WriteLine ("\nThe task is already Completed\n");
            return;
        }
        _taskIsCompleted = true;
        Console.WriteLine ("\nThe task is successfully marked as completed\n");
    }
    public void MarkInComplete () {
        if (!_taskIsCompleted) {
            Console.WriteLine ("\nThe task is already marked as incompleted\n");
            return ;
        }
        _taskIsCompleted = false;
        Console.WriteLine ("\nThe task is successfully marked as incompleted\n");
    }
    public void Display () {
        Console.WriteLine ($"\nTask Description: {_taskDescription}");
        if (_taskIsCompleted) {
            Console.WriteLine ("\n Task status: is completed\n");
            return;
        }
        Console.WriteLine ("\n Task status: incompleted\n");
        
    }   
}

class TaskManager {

    List <TaskItem> _managerTasks;
    int _managerTasksCount;

    public TaskManager () {
        _managerTasks = new List<TaskItem> ();
        _managerTasksCount = 0;
    }

    public void AddTask () {
        Console.WriteLine ("\nPlease Enter a description\n");
        string description = Console.ReadLine ();
        _managerTasks.Add (new TaskItem (description));
        ++_managerTasksCount;
        Console.WriteLine ("\nThe task is successfully added\n");
    }

    public void RemoveTask () {
        Console.WriteLine ("\nPlease Enter The description to Delete\n");
        string description = Console.ReadLine ();
        for (int i = 0; i < _managerTasksCount; ++i) {
            if (_managerTasks[i].Description == description) {
                _managerTasks.Remove (_managerTasks[i]);
                --_managerTasksCount;
                break;
            }
            if (i ==_managerTasksCount - 1) {
                Console.WriteLine ("\nThere is No such task\n");
            }
        } 
    }

    public void MarkCompleteInList () {
        Console.WriteLine ("\nPlease Enter the description\n");
        string description = Console.ReadLine ();
        for (int i = 0; i < _managerTasksCount; ++i) {
            if (_managerTasks[i].Description == description) {
                _managerTasks[i].MarkComplete();
                break; 
            }
            if (i == _managerTasksCount - 1) {
                Console.WriteLine ("\nThere is NO such task\n");
            }
        }
    }
    public void MarkInCompleteInList () {
            Console.WriteLine ("\nPlease Enter the description\n");
            string description = Console.ReadLine ();
            for (int i = 0; i < _managerTasksCount; ++i) {
                if (_managerTasks[i].Description == description) {
                    _managerTasks[i].MarkInComplete();
                    break; 
                }
                if (i == _managerTasksCount - 1) {
                    Console.WriteLine ("\nThere is NO such task\n");
                }
            }
    }

    public void DisplayInList () {
        for (int i = 0; i < _managerTasksCount; ++i) {
            _managerTasks[i].Display();
        }
    }

}
 

class Program {
    public static void Main(string[] args) {

    TaskManager manager = new TaskManager();
        string? answ;
        while (true) {
            Console.WriteLine();
            Console.WriteLine("Enter '+' to add a task");
            Console.WriteLine("Enter '-' to add a task");
            Console.WriteLine("Enter 'C' to mark a task as completed");
            Console.WriteLine("Enter 'I' to mark a task as incomleted");
            Console.WriteLine("Enter 'L' to show all Tasks");
            Console.WriteLine("Enter 'X' to exit");
            answ = Console.ReadLine();
            if (answ == "x" || answ == "X") {
                break;
            } else if (answ == "+") {
                manager.AddTask();
            } else if (answ == "-") {
                manager.RemoveTask();
            } else if (answ == "c" || answ == "C") {
                manager.MarkCompleteInList();
            } else if (answ == "i" || answ == "I") {
                manager.MarkInCompleteInList();
            } else if (answ == "l" || answ == "L") {
                manager.DisplayInList();
            } else {
                Console.WriteLine("invalid command, try again");
            }
        }
        Console.WriteLine("GoodBye!");

    }
}