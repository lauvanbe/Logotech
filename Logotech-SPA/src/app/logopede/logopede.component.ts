import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-logopede',
  templateUrl: './logopede.component.html',
  styleUrls: ['./logopede.component.css']
})
export class LogopedeComponent implements OnInit {
  logopedes: any;

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getLogopedes();
  }

  getLogopedes() {
    this.http.get('http://localhost:5000/api/values').subscribe(response => {
      this.logopedes = response;
    }, error => {
      console.log(error);
    });
  }
}
