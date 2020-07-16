import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  @Output() cancelRegister = new EventEmitter();
  model: any = {};

  constructor(private authService: AuthService, private alertService: AlertifyService) { }

  ngOnInit() {}

  registerUser() {
    this.authService.registerUser(this.model).subscribe(() => {
      this.alertService.success('Registration successful');
    }, error => {
      this.alertService.error(error);
    });
  }

  cancel() {
    this.cancelRegister.emit(true);
  }
}
