import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { RepetitiveCharacterComponent } from './repetitive-character/repetitive-character.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,RepetitiveCharacterComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'TrialProject';
}
