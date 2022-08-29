import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReadUniversidadsarrComponent } from './read-universidadsarr.component';

describe('ReadUniversidadsarrComponent', () => {
  let component: ReadUniversidadsarrComponent;
  let fixture: ComponentFixture<ReadUniversidadsarrComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ReadUniversidadsarrComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReadUniversidadsarrComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
