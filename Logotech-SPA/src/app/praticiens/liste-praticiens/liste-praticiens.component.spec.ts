/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { ListePraticiensComponent } from './liste-praticiens.component';

describe('ListePraticiensComponent', () => {
  let component: ListePraticiensComponent;
  let fixture: ComponentFixture<ListePraticiensComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListePraticiensComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListePraticiensComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
