import { Injectable } from "@angular/core";
import { HttpErrorResponse } from "@angular/common/http";

@Injectable({
  providedIn: "root"
})
export class ErrorService {
  getClientErrorMessage(error: Error): string {
    debugger;
    return error.message ? error.message : error.toString();
  }

  getServerErrorMessage(error: HttpErrorResponse): string {
    switch (error.status) {
      case 0: {
        return "We are sorry! Something happened and we can't process your request right now, please try again later";
        break;
      }
      case 400: {
        return "There is something wrong with the request you've made. Please follow validation messages and retry";
        break;
      }
      case 401: {
        return "You don't have permission to perform this action, please contact your system administrator";
        break;
      }
      case 404: {
        return "We couldn't proccess your request";
        break;
      }
      case 500: {
        return "Our search system is not available right now, please try again later. Sorry!";
      }
    }

    return navigator.onLine ? error.message : "No Internet Connection";
  }
}
