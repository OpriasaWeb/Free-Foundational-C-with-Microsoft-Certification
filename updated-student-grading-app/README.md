# updated-student-grading-app

End users often ask developers to add new features to an application. User requests indicate that your application is being used, and more importantly, that the customer plans to continue using your application. The customer just wants some features updated. The ability to update an existing application based on user requests is very important. A successful update will preserve the integrity of the original application while providing the user with the improved experience that they requested.

Suppose you're a teacher's assistant at a school and that you developed an application to automate the grading process. The application uses arrays to store student names and graded assignments. The application also implements a combination of iteration and selection statements to calculate and report each student's final grade. Your application even differentiates between exam assignments and extra credit assignments when calculating student grades. Although the application does everything that the teacher asked for, you've received a request for new features. The teacher has asked you to update the grading report to show exam and extra credit assignment scores separately from the final numeric score and letter grade.

This module challenges you to add new capabilities to your Student Grading application.

In short, you need to use the teacher's updated grading report specification to:

- update the iteration and selection code to calculate separate final scores for exams, extra credit assignments, and the overall grade.
- update the code that writes the grading report to the console.


Your goal in this challenge is to implement the coding updates required to produce the teacher's requested score report.

The current score report lists the student's name followed by the calculated overall grade and letter grade. Here is the existing report format:

Output
- Student         Grade   Letter Grade

- Sophia          95.6    A
- Andrew          91.6    A-
- Emma            89.2    B+
- Logan           93      A

In addition to the student's final numeric score and letter grade, the teacher wants the updated report to include the exam score and the impact that extra credit work has on the student's final grade. The format of the updated score report should appear as follows:

Output
- Student         Exam Score      Overall Grade   Extra Credit

- Sophia          92.2            95.88   A       92 (3.68 pts)
- Andrew          89.6            91.38   A-      89 (1.78 pts)
- Emma            85.6            90.94   A-      89 (5.34 pts)
- Logan           91.2            93.12   A       96 (1.92 pts)