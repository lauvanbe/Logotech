import { PatientService } from 'src/app/_services/patient.service';
import { AlertifyService } from './../../_services/alertify.service';
import { environment } from '../../../environments/environment';
import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Photo } from 'src/app/_models/photo';
import { FileUploader } from 'ng2-file-upload';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-photo-editor',
  templateUrl: './photo-editor.component.html',
  styleUrls: ['./photo-editor.component.css']
})
export class PhotoEditorComponent implements OnInit {
  @Input() photos: Photo[];
  @Output() getPatientPhotoChange = new EventEmitter<string>();
  uploader: FileUploader;
  hasBaseDropZoneOver = false;
  baseUrl = environment.apiUrl;
  currentMain: Photo;

  constructor(private route: ActivatedRoute, private patientService: PatientService, private alertify: AlertifyService) {  }

  ngOnInit() {
    this.initializeUploader();
  }

  fileOverBase(e: any): void {
    this.hasBaseDropZoneOver = e;
  }

  initializeUploader() {
    const id: number = this.route.snapshot.params.id;
    this.uploader = new FileUploader({
      url: this.baseUrl + 'patients/' + id + '/photos',
      isHTML5: true,
      allowedFileType: ['image'],
      removeAfterUpload: true,
      autoUpload: false,
      maxFileSize: 10 * 1024 * 1024
    });

    this.uploader.onAfterAddingFile = (file) => {file.withCredentials = false; };

    this.uploader.onSuccessItem = (item, response, status, headers) => {
      if (response) {
        const res: Photo = JSON.parse(response);
        const photo = {
          id: res.id,
          url: res.url,
          dateAdded: res.dateAdded,
          description: res.description,
          isMain: res.isMain
        };
        this.photos.push(photo);

      }
    };
  }

  setMainPhoto(photo: Photo) {
    const idUrl: number = this.route.snapshot.params.id;

    this.patientService.setMainPhoto(idUrl, photo.id).subscribe(() => {
      this.currentMain = this.photos.filter(p => p.isMain === true)[0];
      this.currentMain.isMain = false;
      photo.isMain = true;
      this.getPatientPhotoChange.emit(photo.url);
    }, error => {
      this.alertify.error(error);
    });
  }

  deletePhoto(id: number) {
    const idUrl: number = this.route.snapshot.params.id;

      this.alertify.confirm('Etes vous sur de vouloir supprimer la photo?', () => {
        this.patientService.deletePhoto(idUrl, id).subscribe(() => {
          this.photos.splice(this.photos.findIndex(p => p.id === id), 1);
          this.alertify.success('La photo a bien été supprimée');
      }, error => {
        this.alertify.error('Impossible de supprimer la photo');
      });
    });
  }
}
