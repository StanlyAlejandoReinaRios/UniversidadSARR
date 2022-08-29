import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UniversidadsarrComponent } from './universidadsarr.component';

describe('UniversidadsarrComponent', () => {
  let component: UniversidadsarrComponent;
  let fixture: ComponentFixture<UniversidadsarrComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UniversidadsarrComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UniversidadsarrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
