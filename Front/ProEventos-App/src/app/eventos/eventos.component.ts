import { Component } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent {

/**
 * name
 */
public evento: any = {
  Tema: 'Angular',
  Local: 'Belo Horizonte'
}

}
