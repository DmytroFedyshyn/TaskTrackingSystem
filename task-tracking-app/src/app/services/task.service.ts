import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TaskService {
  private apiUrl = 'http://localhost:5000/api/tasks';

  constructor(private http: HttpClient) {}

  getTasks() {
    return this.http.get(`${this.apiUrl}`);
  }

  createTask(task: any) {
    return this.http.post(`${this.apiUrl}`, task);
  }

  updateTask(task: any) {
    return this.http.put(`${this.apiUrl}/${task.id}`, task);
  }

  deleteTask(id: number) {
    return this.http.delete(`${this.apiUrl}/${id}`);
  }
}