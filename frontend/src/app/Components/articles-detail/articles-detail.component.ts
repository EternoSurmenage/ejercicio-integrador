import { Component, OnInit, Input } from '@angular/core';

import { Article } from 'src/app/Models/Article';

@Component({
  selector: 'app-articles-detail',
  templateUrl: './articles-detail.component.html',
  styleUrls: ['./articles-detail.component.css']
})
export class ArticlesDetailComponent implements OnInit {
@Input() articles: Article[]; 

  constructor() { }

  ngOnInit() {
  }

}
