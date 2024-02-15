using ReactiveUI;
using Sample.TaskTracker.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.TaskTracker.Avalonia.ViewModels
{
	internal class TaskViewModel : ViewModelBase
	{
		private TaskModel _model;

		private string _name;
		private string _namePrompt;
		private string _description;
		private string _descriptionPrompt;

		public string Name
		{
			get => _name;
			set => this.RaiseAndSetIfChanged(ref _name, value);
		}

		public string NamePrompt
		{
			get => _namePrompt;
			set => this.RaiseAndSetIfChanged(ref _namePrompt, value);
		}

		public string Description
		{
			get => _description;
			set => this.RaiseAndSetIfChanged(ref _description, value);
		}

		public string DescriptionPrompt
		{
			get => _descriptionPrompt;
			set => this.RaiseAndSetIfChanged(ref _descriptionPrompt, value);
		}

		public TaskViewModel(TaskModel model)
		{
			ArgumentNullException.ThrowIfNull(model);

			_model = model;

			// TODO: Добавить индикатор измененного состояния, при присваивании значения через свойство
			// TODO: Добавить сохранение изменений
			// TODO: Добавить локализацию значение подсказок
			_name = _model.Name;
			_namePrompt = "<Введите имя задачи>";
			_description = _model.Description;
			_descriptionPrompt = "<Введите описание задачи>";
		}
	}
}
