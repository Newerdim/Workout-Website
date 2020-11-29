import { Component, OnInit } from '@angular/core';

declare const initialNav: any;

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss'],
})
export class NavComponent implements OnInit {
  constructor() {}

  ngOnInit(): void {
    initialNav();
  }
}
