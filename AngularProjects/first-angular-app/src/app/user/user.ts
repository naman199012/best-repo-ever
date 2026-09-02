import { Component, computed, EventEmitter, Input, Output } from '@angular/core';

type UserProfile = {
  id: string;
  name: string;
  avatar: string;
  role: string;
};

@Component({
  selector: 'app-user',
  imports: [],
  templateUrl: './user.html',
  styleUrl: './user.css',
})
export class User {
  @Input() user!: UserProfile;
  @Input() selected = false;

  @Output() userSelected = new EventEmitter<void>();

  imagePath = computed(() => '/assets/users/' + this.user.avatar);

  selectUser() {
    this.userSelected.emit();
  }
}
