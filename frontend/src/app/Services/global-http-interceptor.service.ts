import {Injectable} from "@angular/core";
import {HttpEvent, HttpHandler, HttpInterceptor,HttpRequest,HttpResponse,HttpErrorResponse} from '@angular/common/http';
import {Observable, throwError} from "rxjs";
import {catchError} from 'rxjs/operators';
import { MessageService } from './message.service';
 
@Injectable()
export class GlobalHttpInterceptorService implements HttpInterceptor {
    constructor(private messageService : MessageService) {}
 
    intercept(req: HttpRequest<any>, next: HttpHandler): 
        Observable<HttpEvent<any>> {
 
          return next.handle(req).pipe(
             catchError( (error) => {
             
               return throwError(error);
               this.messageService.add(error);
          })
        )
    }
}