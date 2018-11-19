import { Video } from './video';
import { Photo } from './photo';

export interface User {
    id: number;
    username: string;
    businessName: string;
    contactName: string;
    dateAdded: Date;
    videoURL?: string;
    photoURL?: string;
    abn?: string;
    industry?: string;
    summary?: string;
    videos?: Video[];
    photos?: Photo[];
}
