import { Component, OnInit } from '@angular/core';
import { CdkDragDrop, DragDropModule, transferArrayItem } from '@angular/cdk/drag-drop';
import { CommonModule } from '@angular/common';

interface Task {
  title: string;
  description: string;
}

interface Column {
  name: string;
  tasks: Task[];
}

@Component({
  selector: 'app-kanban-board',
  standalone: true,
  imports: [CommonModule, DragDropModule],
  templateUrl: './kanban-board.component.html',
  styleUrls: ['./kanban-board.component.scss']
})
export class KanbanBoardComponent implements OnInit {
  columns: Column[] = [];

  ngOnInit() {
    this.columns = [
      {
        name: 'To Do',
        tasks: [
          { title: 'Create API', description: 'Develop the backend API' },
          { title: 'Setup Database', description: 'Configure PostgreSQL database' }
        ]
      },
      {
        name: 'In Progress',
        tasks: [
          { title: 'Frontend UI', description: 'Design Kanban board in Angular' }
        ]
      },
      {
        name: 'Done',
        tasks: []
      }
    ];
  }

  onTaskDrop(event: CdkDragDrop<Task[]>) {
    if (event.previousContainer === event.container) return;

    transferArrayItem(
      event.previousContainer.data,
      event.container.data,
      event.previousIndex,
      event.currentIndex
    );
  }
}
