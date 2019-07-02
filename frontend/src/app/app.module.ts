import { BrowserModule } from "@angular/platform-browser";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { NgModule, ErrorHandler } from "@angular/core";
import { CommonModule } from "@angular/common";
import { ReactiveFormsModule } from "@angular/forms";

import { AppRoutingModule } from "./app-routing.module";
import { AppComponent } from "./app.component";
import { ArticlesComponent } from "./Components/articles/articles.component";
import { MessagesComponent } from "./Components/messages/messages.component";
import { GlobalErrorHandlerComponent } from "./Components/global-error-handler/global-error-handler.component";
import { PageNotFoundComponent } from "./Components/page-not-found/page-not-found.component";
import { ArticlesDetailComponent } from "./Components/articles-detail/articles-detail.component";
import { MessageService } from "./Services/message.service";
import { ErrorComponent } from './Components/error/error.component';

@NgModule({
  declarations: [
    AppComponent,
    ArticlesComponent,
    MessagesComponent,
    GlobalErrorHandlerComponent,
    PageNotFoundComponent,
    ArticlesDetailComponent,
    ErrorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    CommonModule,
    ReactiveFormsModule
  ],
  providers: [{ provide: ErrorHandler, useClass: GlobalErrorHandlerComponent }],
  bootstrap: [AppComponent]
})
export class AppModule {}
