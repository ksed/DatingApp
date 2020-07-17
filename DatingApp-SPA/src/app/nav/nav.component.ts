import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  model: any = {};

  constructor(
    public authService: AuthService,
    private alertService: AlertifyService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  login() {
    this.authService.login(this.model).subscribe(next => {
      this.alertService.success('Login successful');
    }, error => {
      this.alertService.error(error);
      this.router.navigate(['/home']);
    }, () => {
      this.router.navigate(['/members']);
    });
  }

  loggedIn() { return this.authService.loggedIn(); }

  logout() {
    localStorage.removeItem('token');
    this.alertService.message("Logout successful");
    this.router.navigate(['/home']);
  }

}
