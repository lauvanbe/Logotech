import { Component, OnInit } from '@angular/core';
import { Praticien } from '../../_models/praticien';
import { PraticienService } from '../../_services/praticien.service';
import { AlertifyService } from '../../_services/alertify.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-liste-praticiens',
  templateUrl: './liste-praticiens.component.html',
  styleUrls: ['./liste-praticiens.component.css']
})
export class ListePraticiensComponent implements OnInit {
  praticiens: Praticien[];
  praticien: string;

  constructor(private praticienService: PraticienService, private alertify: AlertifyService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.praticiens = data['praticiens'];
    });
  }

  // loadPraticiens() {
  //   this.praticienService.getPraticiens().subscribe((praticiens: Praticien[]) => {
  //     this.praticiens = praticiens;
  //   }, error => {
  //     this.alertify.error(error);
  //   });
  // }

}
