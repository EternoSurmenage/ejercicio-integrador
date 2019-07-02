import { Component, OnInit } from "@angular/core";
import { ErrorHandler, Injectable, Injector } from "@angular/core";
import { HttpErrorResponse } from "@angular/common/http";
import { ErrorService } from "../../Services/error.service";
import { MessageService } from "../../Services/message.service";
import { of, Observable } from "rxjs";
import { Router } from "@angular/router";

@Component({
  selector: "app-global-error-handler",
  templateUrl: "./global-error-handler.component.html",
  styleUrls: ["./global-error-handler.component.css"]
})
@Injectable()
export class GlobalErrorHandlerComponent implements ErrorHandler {
  
  constructor(private injector: Injector) {}

  handleError(error: Error | HttpErrorResponse, result?: any) {
    const errorService = this.injector.get(ErrorService);
    const messageService = this.injector.get(MessageService);
    const router = this.injector.get(Router);
    debugger;
    let message: string;
    messageService.clear();
    if (error instanceof HttpErrorResponse) {
      // Server error
      message = errorService.getServerErrorMessage(error);
      //stackTrace = errorService.getServerErrorStackTrace(error);
      messageService.add(message);
      console.log(message);
      //window.location.href="/error";
    } else {
      // Client Error
      message = errorService.getClientErrorMessage(error);
      // messageService.add(message);
      messageService.addMessages(message);
    }
    // Always log errors
    //console.error(error);
  }
}
