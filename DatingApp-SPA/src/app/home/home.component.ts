import { HttpClient } from '@angular/common/http';

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  registered = false;

  constructor(private http: HttpClient) { }

  ngOnInit() {}

  registerUser() { this.registered = true; }

  canceledRegister(cancelRegister: boolean) { this.registered = !cancelRegister; }

}
