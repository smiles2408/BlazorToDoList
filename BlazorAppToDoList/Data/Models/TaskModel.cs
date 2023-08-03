using System;
namespace BlazorAppToDoList.Data.Models
{
	public class TaskModel
	{
		public TaskModel()
		{
		}
		public string TaskName { get; set; }
		public bool IsComplete { get; set; }

	}
}

