import { Injectable } from "@angular/core";
import { Article } from "../Models/Article";
import { MessageService } from "./message.service";

@Injectable({
  providedIn: "root"
})
export class ValidatorService {
  constructor(private messageService: MessageService) {}

// Check if search term is empty
isSearchTermEmpty(searchTerm:string){
  if (this.isTermEmpty(searchTerm))
  {
    throw Error("Search term is required");
  }
}

  // Check if date isn't older than today
  private isDateFuture(date: Date): boolean {
    let today = new Date();

    if (date > today) {
      return true;
    } else {
      return false;
    }
  }

  isURLAvailable(article: Article): boolean {
    if (article.statusAvailable == false) {
      return false;
    }
    return true;
  }

  private isDateRangeValid(startDate: Date, endDate: Date): boolean {
    if (startDate > endDate) {
      return false;
    }
    return true;
  }

  convertDateStringToDate(dateString: string): Date {
    let parts = dateString.split("-");
    let formatted = parts[0] + "/" + parts[1] + "/" + parts[2];
    let date = new Date(formatted);
    return date;
  }

  private isTermEmpty(term: string): boolean {
    if (!term) {
      return true;
    }
    return false;
  }

  isDateInputValid(startDate: string, endDate: string) {
    let start = this.convertDateStringToDate(startDate);
    let end = this.convertDateStringToDate(endDate);

    let errorMessages: string;
    errorMessages = "";

    if (this.isTermEmpty(startDate) || this.isTermEmpty(endDate)) {
      //throw Error("Dates cannot be empty");
      errorMessages += "Dates cannot be empty" + "\n";
    }
    if (this.isDateFuture(start) || this.isDateFuture(end)) {
      //throw Error("Dates cannot be in the future");
      errorMessages += "Dates cannot be in the future" + "\n";
    }
    if (!this.isDateRangeValid(start, end)) {
      //throw Error("From date cannot be greater than To date");
      errorMessages += "From date cannot be greater than To date" + "\n";
    }

    if (errorMessages.length != 0) {
      throw Error(errorMessages);
    }
  }
}
