import { Injectable } from "@angular/core";
import { Subject, Observable, BehaviorSubject } from "rxjs";

@Injectable({
  providedIn: "root"
})
export class MessageService {
  messages: string[] = [];
  messages$ = new Subject<any>();

  outputMessages: string[] = [];

  add(message: string) {
    this.messages.push(message);
    this.messages$.next(this.messages);
    console.log("MsgService: ", this.messages);
  }

  addMessages(combinedMessage: string) {
    debugger;
    this.outputMessages = this.splitMessage(combinedMessage);

    for (var index in this.outputMessages) {
      this.add(this.outputMessages[index]);
    }
  }

  clear() {
    this.messages = [];
  }
  getMessage(): Observable<any> {
    return this.messages$.asObservable();
  }

  splitMessage(message: string): string[] {
    return message.split("\n").filter(Boolean);
  }

  buildMessage(errorsMessage: string, message: string): string {
    return (errorsMessage += message + "\n");
  }
}
