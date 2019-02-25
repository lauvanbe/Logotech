import { Adresse } from './adresse';
import { Photo } from './photo';

export interface Patient {
    id: number;
    nom: string;
    prenom: string;
    dateNaissance: Date;
    email: string;
    telFixe: number;
    gsm: number;
    personneContact: string;
    telContact: number;
    anamnese: string;
    lateralite: string;
    commentaire: string;
    adresse: Adresse;
    photo: Photo;
}
