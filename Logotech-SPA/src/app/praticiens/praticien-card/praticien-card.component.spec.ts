/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PraticienCardComponent } from './praticien-card.component';

describe('PraticienCardComponent', () => {
  let component: PraticienCardComponent;
  let fixture: ComponentFixture<PraticienCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PraticienCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PraticienCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
