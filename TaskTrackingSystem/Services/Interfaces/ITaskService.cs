using TaskTrackingSystem.DTOs;
using TaskTrackingSystem.Models;

namespace TaskTrackingSystem.Services.Interfaces
{
    public interface ITaskService
    {
        Task<List<TaskCard>> GetAllTasksAsync();
        Task<TaskCard> CreateTaskAsync(TaskDto taskDto, int userId);
        Task UpdateTaskAsync(int id, TaskDto taskDto);
        Task DeleteTaskAsync(int id);
    }
}
