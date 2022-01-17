import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminAddbookComponent } from './admin-addbook.component';

describe('AdminAddbookComponent', () => {
  let component: AdminAddbookComponent;
  let fixture: ComponentFixture<AdminAddbookComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminAddbookComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminAddbookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
