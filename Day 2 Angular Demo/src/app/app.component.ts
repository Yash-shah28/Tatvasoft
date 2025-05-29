import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { UserService } from './services/user.service';


// import { Menu1Service } from './services/menu1.service';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, FormsModule, CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  user = {
    name: '',
    email: '',
    password: '',
    phone: ''
  }

  submitted = false;
    constructor(private userService: UserService) {}


  onSubmit() {
    this.submitted = true;
  }
}
