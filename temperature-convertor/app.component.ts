import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TemperatureConvertorComponent } from './temperature-convertor/temperature-convertor.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,TemperatureConvertorComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'TrialProject';
}
