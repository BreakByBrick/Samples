using ReactiveUI;
using Sample.TaskTracker.Data;
using System.Collections.ObjectModel;
using System.Linq;

namespace Sample.TaskTracker.Avalonia.ViewModels;

internal class MainViewModel : ViewModelBase
{
	public TaskListViewModel TaskList { get; } = new TaskListViewModel();
}
