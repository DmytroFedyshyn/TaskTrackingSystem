import { Component, OnInit } from '@angular/core';
import { CdkDragDrop, transferArrayItem } from '@angular/cdk/drag-drop';
import { MatDialog } from '@angular/material/dialog';
import { TaskDialogComponent } from '../task-dialog/task-dialog.component';
import { TaskService } from '../../services/task.service';

@Component({
  selector: 'app-kanban-board',
  templateUrl: './kanban-board.component.html',
  styleUrls: ['./kanban-board.component.scss']
})
export class KanbanBoardComponent implements OnInit {
  columns = [
    { name: 'To Do', tasks: [] },
    { name: 'In Progress', tasks: [] },
    { name: 'Done', tasks: [] },
  ];

  constructor(private taskService: TaskService, private dialog: MatDialog) {}

  ngOnInit() {
    this.loadTasks();
  }

  loadTasks() {
    this.taskService.getTasks().subscribe((tasks: any) => {
      this.columns[0].tasks = tasks.filter((t: any) => t.status === 'ToDo');
      this.columns[1].tasks = tasks.filter((t: any) => t.status === 'InProgress');
      this.columns[2].tasks = tasks.filter((t: any) => t.status === 'Done');
    });
  }

  onTaskDrop(event: CdkDragDrop<any[]>) {
    if (event.previousContainer === event.container) return;

    transferArrayItem(
      event.previousContainer.data,
      event.container.data,
      event.previousIndex,
      event.currentIndex
    );

    const task = event.container.data[event.currentIndex];
    task.status = this.columns.find(col => col.tasks === event.container.data)?.name;
    this.taskService.updateTask(task).subscribe();
  }

  addTask() {
    const dialogRef = this.dialog.open(TaskDialogComponent);

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.taskService.createTask(result).subscribe(() => this.loadTasks());
      }
    });
  }

  editTask(task: any) {
    const dialogRef = this.dialog.open(TaskDialogComponent, { data: { task } });

    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.taskService.updateTask({ ...task, ...result }).subscribe(() => this.loadTasks());
      }
    });
  }

  deleteTask(task: any) {
    this.taskService.deleteTask(task.id).subscribe(() => this.loadTasks());
  }
}