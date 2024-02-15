using ReactiveUI;
using Sample.TaskTracker.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.TaskTracker.Avalonia.ViewModels
{
	internal class TaskListViewModel : ViewModelBase
	{
		public ObservableCollection<TaskViewModel> TaskItems { get; }
			= new ObservableCollection<TaskViewModel>(TaskService.Instance.GetTasks().Select(t => new TaskViewModel(t)));

		private TaskViewModel _selectedTask;
		public TaskViewModel SelectedTask
		{
			get => _selectedTask;
			private set => this.RaiseAndSetIfChanged(ref _selectedTask, value);
		}
	}
}
