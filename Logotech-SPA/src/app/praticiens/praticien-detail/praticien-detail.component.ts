import { Component, OnInit } from '@angular/core';
import { Praticien } from 'src/app/_models/praticien';
import { PraticienService } from 'src/app/_services/praticien.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-praticien-detail',
  templateUrl: './praticien-detail.component.html',
  styleUrls: ['./praticien-detail.component.css']
})
export class PraticienDetailComponent implements OnInit {
  praticien: Praticien;

  constructor(private praticienService: PraticienService, private alertify: AlertifyService,
    private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.praticien = data['praticien'];
    });
  }
}
