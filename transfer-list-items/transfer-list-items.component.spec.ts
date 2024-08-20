import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TransferListItemsComponent } from './transfer-list-items.component';

describe('TransferListItemsComponent', () => {
  let component: TransferListItemsComponent;
  let fixture: ComponentFixture<TransferListItemsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TransferListItemsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TransferListItemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
