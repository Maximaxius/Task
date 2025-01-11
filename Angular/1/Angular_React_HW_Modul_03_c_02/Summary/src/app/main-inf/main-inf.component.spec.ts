import { ComponentFixture, TestBed } from '@angular/core/testing';

import { MainInfComponent } from './main-inf.component';

describe('MainInfComponent', () => {
  let component: MainInfComponent;
  let fixture: ComponentFixture<MainInfComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [MainInfComponent]
    });
    fixture = TestBed.createComponent(MainInfComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
