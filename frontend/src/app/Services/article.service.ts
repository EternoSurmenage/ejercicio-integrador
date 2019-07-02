import { Observable, throwError, of } from "rxjs";

import { Injectable } from "@angular/core";
import {
  HttpClient,
  HttpHeaders,
  HttpResponse,
  HttpErrorResponse
} from "@angular/common/http";
import { environment } from "../../environments/environment";

import { Article } from "../Models/Article";
import { ValidatorService } from "./Validators/validator.service";
import { MessageService } from "./message.service";

@Injectable({
  providedIn: "root"
})
export class ArticleService {
  apiURL = environment.apiURL;
  response: string;

  httpOptions = {
    headers: new HttpHeaders({ "Content-Type": "application/json" })
  };

  constructor(
    private http: HttpClient,
    private validatorService: ValidatorService,
    private messageService: MessageService
  ) {}

  getArticles(
    searchTerm: string,
    startDate: string,
    endDate: string
  ): Observable<Article[]> {
    this.messageService.clear();
    debugger;
    this.validatorService.isInputValid(searchTerm, startDate, endDate);

    //Dates are valid
    return this.http.get<Article[]>(
      this.apiURL +
        `?search=${searchTerm}&startDate=${startDate}&endDate=${endDate}`
     //"http://demo5167316.mockable.io/apitest"
    );
  }
}
