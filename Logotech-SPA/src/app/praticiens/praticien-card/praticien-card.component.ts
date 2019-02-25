import { Component, OnInit, Input } from '@angular/core';
import { Docteur } from 'src/app/_models/docteur';

@Component({
  selector: 'app-praticien-card',
  templateUrl: './praticien-card.component.html',
  styleUrls: ['./praticien-card.component.css']
})
export class PraticienCardComponent implements OnInit {
  @Input() praticien: Docteur;

  constructor() { }

  ngOnInit() {
  }

}
