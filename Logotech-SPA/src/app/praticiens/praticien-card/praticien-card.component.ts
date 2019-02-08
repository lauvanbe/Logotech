import { Component, OnInit, Input } from '@angular/core';
import { Praticien } from 'src/app/_models/praticien';

@Component({
  selector: 'app-praticien-card',
  templateUrl: './praticien-card.component.html',
  styleUrls: ['./praticien-card.component.css']
})
export class PraticienCardComponent implements OnInit {
  @Input() praticien: Praticien;

  constructor() { }

  ngOnInit() {
  }

}
