import { Component, computed, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { DUMMY_USERS } from './dummy-users';
import { Header } from './header/header';
import { User } from './user/user';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Header, User],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {
  protected readonly users = DUMMY_USERS;
  protected readonly selectedUserId = signal(DUMMY_USERS[0].id);

  protected readonly selectedUser = computed(
    () => DUMMY_USERS.find((user) => user.id === this.selectedUserId()) ?? DUMMY_USERS[0],
  );

  protected selectUser(id: string) {
    this.selectedUserId.set(id);
  }
}
