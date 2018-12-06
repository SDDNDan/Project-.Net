import { Component } from '@angular/core';
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'CoursesAndLabs';

  constructor(private http: HttpClient) { }

  submitRequestedCourse(name: string) {

    const requestedCourse = JSON.stringify(name);
    this.http.post("https://localhost:44337/api/Course", requestedCourse).subscribe(data => {
      alert("Course posted !");
    },
      error => {
        console.log(JSON.stringify(`CourseService:  ${error}`));

      }
    );
  }

  onClickMe() {
    this.submitRequestedCourse("Carapace");
  }

}
