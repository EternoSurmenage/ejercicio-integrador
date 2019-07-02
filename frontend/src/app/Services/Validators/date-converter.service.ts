import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root"
})
export class DateConverterService {
  convertDateStringToDate(dateString: string): Date {
    let parts = dateString.split("-");
    let formatted = parts[0] + "/" + parts[1] + "/" + parts[2];
    let date = new Date(formatted);
    return date;
  }
}
