import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-temperature-convertor',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './temperature-convertor.component.html',
  styleUrl: './temperature-convertor.component.css'
})
export class TemperatureConvertorComponent {
  celsius: number | null = null;
  fahrenheit: number | null = null;

  // Converts Celsius to Fahrenheit
  convertToFahrenheit(): void {
    if (this.celsius !== null) {
      this.fahrenheit = (this.celsius * 9/5) + 32;
    }
  }

  // Converts Fahrenheit to Celsius
  convertToCelsius(): void {
    if (this.fahrenheit !== null) {
      this.celsius = (this.fahrenheit - 32) * 5/9;
    }
  }

  // Clears the input fields
  clearFields(): void {
    this.celsius = null;
    this.fahrenheit = null;
  }
}
