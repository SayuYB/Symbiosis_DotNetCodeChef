import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-transfer-list-items',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './transfer-list-items.component.html',
  styleUrl: './transfer-list-items.component.css'
})
export class TransferListItemsComponent {
  availableItems: string[] = ['Clothes', 'Fruits', 'Suitcase', 'Vegetables', 'Laptop'];
  selectedItems: string[] = [];

  // Move item to selected list
  transferToSelected(item: string): void {
    this.selectedItems.push(item);
    this.availableItems = this.availableItems.filter(i => i !== item);
  }

  // Move item back to available list
  transferToAvailable(item: string): void {
    this.availableItems.push(item);
    this.selectedItems = this.selectedItems.filter(i => i !== item);
  }
}
