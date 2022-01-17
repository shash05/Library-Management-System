import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminRouteComponent } from './admin-route.component';

describe('AdminRouteComponent', () => {
  let component: AdminRouteComponent;
  let fixture: ComponentFixture<AdminRouteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminRouteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AdminRouteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
