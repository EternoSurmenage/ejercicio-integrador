import { Component, OnInit } from '@angular/core';

import {MessageService} from "../../Services/message.service";
import { Router } from '@angular/router';

@Component({
  selector: 'app-page-not-found',
  templateUrl: './page-not-found.component.html',
  styleUrls: ['./page-not-found.component.css']
})
export class PageNotFoundComponent implements OnInit {

  constructor(private messageService:MessageService, private router:Router) { }

  ngOnInit() {
    this.messageService.add("Page not found, we'll redirect you to home page");
    setTimeout(() => {
      this.router.navigate(['/articles']);
    }, 2000);
  }

}
