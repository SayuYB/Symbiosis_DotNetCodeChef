import { Component } from '@angular/core';
import { RepetitiveCharacterService } from '../repetitive-character.service';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-repetitive-character',
  standalone: true,
  imports: [FormsModule, CommonModule],
  templateUrl: './repetitive-character.component.html',
  styleUrl: './repetitive-character.component.css'
})
export class RepetitiveCharacterComponent {
  inputString: string = '';
  mostRepetitiveChar: string | null = null;

  constructor(private RepetitiveCharacterService: RepetitiveCharacterService) {}

  findRepetitve() {
    this.mostRepetitiveChar = this.RepetitiveCharacterService.findMostRepetitiveChar(this.inputString);
  }
}
