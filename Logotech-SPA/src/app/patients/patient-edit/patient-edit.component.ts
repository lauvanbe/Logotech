import { Component, OnInit, ViewChild, HostListener } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Patient } from 'src/app/_models/Patient';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { NgForm } from '@angular/forms';
import { PatientService } from 'src/app/_services/patient.service';

@Component({
  selector: 'app-patient-edit',
  templateUrl: './patient-edit.component.html',
  styleUrls: ['./patient-edit.component.css']
})
export class PatientEditComponent implements OnInit {
  @ViewChild('editForm') editForm: NgForm;
  patient: Patient;
  @HostListener('window:beforeunload', ['$event'])
  unloadNotification($event: any) {
    if (this.editForm.dirty) {
      $event.returnValue = true;
    }
  }

  constructor(private route: ActivatedRoute, private alertify: AlertifyService, private patientService: PatientService) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.patient = data['patient'];
    });
  }

  updatePatient() {
    this.patientService.updatePatient(this.patient.id, this.patient).subscribe(next => {
      this.alertify.success('Le profil a bien été mis à jour');
      this.editForm.reset(this.patient);
    }, error => {
      this.alertify.error(error);
    });

  }

  updateMainPhoto(photoUrl) {
    this.patient.photoUrl = photoUrl;
  }

}
