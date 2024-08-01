import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-validate-digits',
  standalone: true,
  imports: [FormsModule,CommonModule,ReactiveFormsModule],
  templateUrl: './validate-digits.component.html',
  styleUrl: './validate-digits.component.css'
})
export class ValidateDigitsComponent {
  numberForm: FormGroup;
  formattedNumber: string | null = null;

  constructor(private fb: FormBuilder) {
    this.numberForm = this.fb.group({
      numberInput: ['', [Validators.required, Validators.pattern(/^\d{12}$/)]]
    });
  }

  onSubmit(): void {
    if (this.numberForm.valid) {
      const number = this.numberForm.value.numberInput;
      this.formattedNumber = this.transformNumber(number);
    }
  }

  transformNumber(number: string): string {
    return `${number.slice(0, 4)}-${number.slice(4, 8)}-${number.slice(8, 12)}`;
  }
}
