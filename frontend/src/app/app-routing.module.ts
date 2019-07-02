import { NgModule } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ArticlesComponent } from "./Components/articles/articles.component";
import { PageNotFoundComponent } from "./Components/page-not-found/page-not-found.component";
import { ErrorComponent } from "./Components/error/error.component";

const routes: Routes = [
  { path: "articles", component: ArticlesComponent },
  { path: "", redirectTo: "/articles", pathMatch: "full" },
  { path: "error", component: ErrorComponent },
  { path: "**", component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
