import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root"
})
export class DateValidatorService {
  // Check if date isn't older than today
  isDateFuture(date: Date): boolean {
    let today = new Date();

    if (date > today) {
      return true;
    } else {
      return false;
    }
  }

  //Check if startDate is not greater than endDate
  isDateRangeValid(startDate: Date, endDate: Date): boolean {
    if (startDate > endDate) {
      return false;
    }
    return true;
  }
}
