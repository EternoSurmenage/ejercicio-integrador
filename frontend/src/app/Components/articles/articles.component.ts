import { Component, OnInit } from "@angular/core";
import { FormGroup, Validators, FormBuilder } from "@angular/forms";

import { ArticleService } from "../../Services/article.service";
import { Article } from "../../Models/Article";
import { MessageService } from "../../Services/message.service";

@Component({
  selector: "app-articles",
  templateUrl: "./articles.component.html",
  styleUrls: ["./articles.component.css"]
})
export class ArticlesComponent implements OnInit {
  foundArticles: Article[];
  myForm: FormGroup;
  start: string;
  end: string;

  constructor(
    private articleService: ArticleService,
    private messageService: MessageService,
    private fb: FormBuilder
  ) {}

  ngOnInit() {
    //  this.messageService.clear();
    this.createForm();
  }

  // Initialize the Form myForm
  createForm() {
    this.myForm = this.fb.group({
      search: ["", Validators.required],
      startDate: ["", Validators.required],
      endDate: ["", Validators.required]
    });
  }

  // Returns arrays of articles based on search term and range dates input by user.
  getArticles() {
    this.articleService
      .getArticles(
        this.myForm.get("search").value,
        this.myForm.get("startDate").value,
        this.myForm.get("endDate").value
      )
      .subscribe(articles => (this.foundArticles = articles));
  }

  sendMessages() {
    this.messageService.add("Mensaje enviado");
  }
}
