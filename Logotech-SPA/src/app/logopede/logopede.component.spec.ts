/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { LogopedeComponent } from './logopede.component';

describe('LogopedeComponent', () => {
  let component: LogopedeComponent;
  let fixture: ComponentFixture<LogopedeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LogopedeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LogopedeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
