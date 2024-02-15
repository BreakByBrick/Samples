using Sample.TaskTracker.Data.Models;

namespace Sample.TaskTracker.Data
{
	public class TaskService
	{
		private static readonly Lazy<TaskService> _lazy = new Lazy<TaskService>(() => new TaskService());

		public static TaskService Instance { get { return _lazy.Value; } }

		private TaskService()
		{
		}

		public TaskModel[] GetTasks() => new[] 
		{
			new TaskModel{ Name="Задача №1", Description="" },
			new TaskModel{ Name="Задача №2", Description="" },
			new TaskModel{ Name="Задача №3", Description="" },
		};
	}
}
