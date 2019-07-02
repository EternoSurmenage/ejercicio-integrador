import { Injectable } from "@angular/core";
import { Article } from "../../Models/Article";
import { MessageService } from "../message.service";
import { throwError } from "rxjs";
import { DateValidatorService } from "./date-validator.service";
import { DateConverterService } from "./date-converter.service";

@Injectable({
  providedIn: "root"
})
export class ValidatorService {
  constructor(
    private dateValidator: DateValidatorService,
    private dateConverter: DateConverterService,
    private messageService: MessageService
  ) {}

  isTermEmpty(term: string): boolean {
    if (!term) {
      return true;
    }
    return false;
  }

  // Validates form inputs
  isInputValid(searchTerm: string, startDate: string, endDate: string) {
    let start = this.dateConverter.convertDateStringToDate(startDate);
    let end = this.dateConverter.convertDateStringToDate(endDate);

    let errorsMessage: string = "";

    if (this.isTermEmpty(searchTerm)) {
      errorsMessage = this.messageService.buildMessage(
        errorsMessage,
        "Search term is required"
      );
    }
    if (this.isTermEmpty(startDate) || this.isTermEmpty(endDate)) {
      errorsMessage = this.messageService.buildMessage(
        errorsMessage,
        "Dates cannot be empty"
      );
    }
    if (
      this.dateValidator.isDateFuture(start) ||
      this.dateValidator.isDateFuture(end)
    ) {
      errorsMessage = this.messageService.buildMessage(
        errorsMessage,
        "Dates cannot be in the future"
      );
    }
    if (!this.dateValidator.isDateRangeValid(start, end)) {
      errorsMessage = this.messageService.buildMessage(
        errorsMessage,
        "From date cannot be greater than To date"
      );
    }
    //If errorMessage is not null, throw error with the message that will be split in messages.
    if (errorsMessage.length != 0) {
      throw Error(errorsMessage);
    }
  }
}
