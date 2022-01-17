import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminViewbooksComponent } from './admin-viewbooks.component';

describe('AdminViewbooksComponent', () => {
  let component: AdminViewbooksComponent;
  let fixture: ComponentFixture<AdminViewbooksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminViewbooksComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminViewbooksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
