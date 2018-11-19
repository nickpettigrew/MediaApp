import { Component, OnInit, Input } from '@angular/core';
import { User } from '../_models/user';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css']
})
export class ContentComponent implements OnInit {
  @Input() user: User;

  constructor() { }

  ngOnInit() {
  }

}
