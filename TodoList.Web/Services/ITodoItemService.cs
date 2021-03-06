﻿using System;
using System.Threading.Tasks;
using TodoList.Web.Models;

namespace TodoList.Web.Services
{
    public interface ITodoItemService
    {
        Task<TodoItem[]> GetIncompleteItemsAsync(ApplicationUser currentUser);
        Task<TodoItem[]> GetCompleteItemsAsync(ApplicationUser currentUser);
        Task<bool> AddItemAsync(TodoItem todo, ApplicationUser currentUser);
        Task<bool> UpdateDoneAsync(Guid id, ApplicationUser currentUser);
        bool Exists(Guid id);
        Task<bool> UpdateTodoAsync(TodoItem todo, ApplicationUser currentUser);
        Task<TodoItem> GetItemAsync(Guid id);
        Task<bool> DeleteTodoAsync(Guid id, ApplicationUser currentUser);
        Task<TodoItem[]> GetRecentlyAddedItemsAsync(ApplicationUser currentUser);
        Task<TodoItem[]> GetDueTo2DaysItems(ApplicationUser user);
        Task<bool> SaveFileAsync(Guid todoId, ApplicationUser currentUser, string path, long size);
    }
}
