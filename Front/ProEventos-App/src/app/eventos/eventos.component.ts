import { NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  standalone: true,
  imports: [ NgFor],
  templateUrl: './eventos.component.html',
  styleUrl: './eventos.component.scss'
})
export class EventosComponent implements OnInit{
public evento: any = [
 {
  Tema: 'Angular 11',
  Local: 'Belo Horizonte'
},
{
  Tema: 'NET 5',
  Local: 'São Paulo'
}
,
{
  Tema: 'Angular e Suas Novidades',
  Local: 'Rio de Janeiro'
}
]
constructor(){}
ngOnInit(): void {
  
}
}
