import { Patient } from './Patient';

export interface Photo {
  id: number;
  url: string;
  description: string;
  isMain: boolean;
  patient: Patient;
}
