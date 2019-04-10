import { Component, OnInit, Input } from '@angular/core';
import { Patient } from 'src/app/_models/Patient';
import { PatientService } from 'src/app/_services/patient.service';
import { AlertifyService } from 'src/app/_services/alertify.service';

@Component({
  selector: 'app-patient-card',
  templateUrl: './patient-card.component.html',
  styleUrls: ['./patient-card.component.css']
})
export class PatientCardComponent implements OnInit {
  @Input() patient: Patient;
  constructor(private patientService: PatientService, private alertify: AlertifyService) { }

  ngOnInit() {
  }

  deletePatient(id: number) {
    this.alertify.confirm('Etes vous sur de vouloir supprimer ce patient?', () => {
      this.patientService.deletePatient(id).subscribe(() => {
        this.alertify.success('Le patient a bien été supprimer');
        location.reload();
      }, error => {
        this.alertify.error('Impossible de supprimer ce patient');
      });
    });
  }

}
