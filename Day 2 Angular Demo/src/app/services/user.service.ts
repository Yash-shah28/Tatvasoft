import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UserService {
 private userData: { name: string; email: string } | null = null;

  saveUser(data: { name: string; email: string }) {
    this.userData = data;
    console.log('User data saved:', data);
  }

  getUser() {
    return this.userData;
  }
}
