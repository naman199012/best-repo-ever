import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  imports: [],
  templateUrl: './header.html',
  styleUrl: './header.css'
})

export class Header {
  protected readonly title = 'EasyTask';
  protected readonly description = 'Enterprise-level task management without friction.';
}