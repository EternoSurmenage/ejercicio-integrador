import { Headline } from "../Models/Headline";

export class Article {
  web_URL: string;
  snippet: string;
  headline: Headline;
  pub_Date: Date;
  statusAvailable: boolean;
}
