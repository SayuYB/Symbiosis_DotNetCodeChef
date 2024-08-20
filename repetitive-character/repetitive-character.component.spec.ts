import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RepetitiveCharacterComponent } from './repetitive-character.component';

describe('RepetitiveCharacterComponent', () => {
  let component: RepetitiveCharacterComponent;
  let fixture: ComponentFixture<RepetitiveCharacterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [RepetitiveCharacterComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(RepetitiveCharacterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
