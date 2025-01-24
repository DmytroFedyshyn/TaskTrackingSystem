using Microsoft.EntityFrameworkCore;
using TaskTrackingSystem.Data;
using TaskTrackingSystem.DTOs;
using TaskTrackingSystem.Models;
using TaskTrackingSystem.Services.Interfaces;

namespace TaskTrackingSystem.Services.Implementation
{
    public class TaskService : ITaskService
    {
        private readonly AppDbContext _context;

        public TaskService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TaskCard>> GetAllTasksAsync()
        {
            return await _context.TaskCards.ToListAsync();
        }

        public async Task<TaskCard> CreateTaskAsync(TaskDto taskDto, int userId)
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            var task = new TaskCard
            {
                Title = taskDto.Title,
                Description = taskDto.Description,
                Status = taskDto.Status,
                Deadline = taskDto.Deadline,
                UserId = userId,
                User = user
            };

            _context.TaskCards.Add(task);
            await _context.SaveChangesAsync();

            return task;
        }


        public async Task UpdateTaskAsync(int id, TaskDto taskDto)
        {
            var task = await _context.TaskCards.FindAsync(id);
            if (task == null) throw new Exception("Task not found");

            task.Title = taskDto.Title;
            task.Description = taskDto.Description;
            task.Status = taskDto.Status;
            task.Deadline = taskDto.Deadline;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteTaskAsync(int id)
        {
            var task = await _context.TaskCards.FindAsync(id);
            if (task == null) throw new Exception("Task not found");

            _context.TaskCards.Remove(task);
            await _context.SaveChangesAsync();
        }
    }
}
