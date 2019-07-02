import { Subscription } from "rxjs";

import { Component, OnDestroy, OnInit } from "@angular/core";

import { MessageService } from "../../Services/message.service";

@Component({
  selector: "app-messages",
  templateUrl: "./messages.component.html",
  styleUrls: ["./messages.component.css"]
})
export class MessagesComponent implements OnInit, OnDestroy {
  messages: Array<any> = [];

  constructor(public messageService: MessageService) {
    this.messageService.messages$.subscribe(
      messages => (this.messages = messages)
    );
    console.log("MsgComponent: ", this.messages);
  }

  ngOnInit() {
    debugger;
    this.messageService.messages$.subscribe(
      messages => (this.messages = messages)
    );
    console.log("MsgComponent: ", this.messages);
  }

  ngOnDestroy() {
    this.messageService.messages$.unsubscribe();
  }
}
