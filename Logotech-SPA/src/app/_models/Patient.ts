import { Adresse } from './adresse';
import { Photo } from './photo';

export interface Patient {
    id: number;
    nom: string;
    prenom: string;
    dateNaissance: Date;
    email: string;
    personneContact: string;
    anamnese: string;
    lateralite: string;
    commentaire: string;
    adresse: Adresse;
    photoUrl: string;
    telContact?: number;
    telFixe?: number;
    gsm?: number;
    photos?: Photo[];
}
