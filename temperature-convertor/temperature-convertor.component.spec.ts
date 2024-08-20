import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemperatureConvertorComponent } from './temperature-convertor.component';

describe('TemperatureConvertorComponent', () => {
  let component: TemperatureConvertorComponent;
  let fixture: ComponentFixture<TemperatureConvertorComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [TemperatureConvertorComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TemperatureConvertorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
