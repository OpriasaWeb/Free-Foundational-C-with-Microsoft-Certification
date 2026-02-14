// using System;


// // initialize variables - graded assignments 
// int currentAssignments = 5;

// // Store student's grades in an array
// int[] sophiaGrades = { 90, 86, 87, 98, 100 };
// int[] andrewGrades = { 92, 89, 81, 96, 90 };
// int[] emmaGrades = { 90, 85, 87, 98, 68 };
// int[] loganGrades = { 90, 95, 87, 88, 96 };

// string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan" };

// foreach (string name in studentNames)
// {
//   if(name == "Sophia")
//   {
//     int sophiaSum = 0;
//     decimal sophiaScore;

//     foreach (int grade in sophiaGrades)
//     {
//       sophiaSum += grade;
//     }

//     sophiaScore = (decimal)sophiaSum / currentAssignments;
//     Console.WriteLine("Student\t\tGrade\n");
//     Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-\n\n");

//   }
//   else if(name == "Andrew")
//   {
//     int andrewSum = 0;
//     decimal andrewScore;

//     foreach (int grade in andrewGrades)
//     {
//       andrewSum += grade;
//     }

//     andrewScore = (decimal)andrewSum / currentAssignments;
//     Console.WriteLine("Student\t\tGrade\n");
//     Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+\n\n");

//   }
//   else if(name == "Emma")
//   {
//     int emmaSum = 0;
//     decimal emmaScore;

//     foreach (int grade in emmaGrades)
//     {
//       emmaSum += grade;
//     }
//     emmaScore = (decimal)emmaSum / currentAssignments;
//     Console.WriteLine("Student\t\tGrade\n");
//     Console.WriteLine("Emma:\t\t" + emmaScore + "\tB\n\n");

//   }
//   else if(name == "Logan")
//   {
//     int loganSum = 0;
//     decimal loganScore;

//     foreach (int grade in loganGrades)
//     {
//       loganSum += grade;
//     }
//     loganScore = (decimal)loganSum / currentAssignments;
//     Console.WriteLine("Student\t\tGrade\n");
//     Console.WriteLine("Logan:\t\t" + loganScore + "\tA-\n\n");

//   }

// }

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();


// using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

// Store student's grades in an array
int[] sophiaScores = { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = { 91, 91, 91, 91, 91, 91, 91 };    

// Student names
string[] studentNames = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
  string currentStudent = name;

  if (currentStudent == "Sophia")
      studentScores = sophiaScores;
  else if (currentStudent == "Andrew")
      studentScores = andrewScores;
  else if (currentStudent == "Emma")
      studentScores = emmaScores;
  else if (currentStudent == "Logan")
      studentScores = loganScores;
  else if (currentStudent == "Becky")
    studentScores = beckyScores;
  else if (currentStudent == "Chris")
      studentScores = chrisScores;
  else if (currentStudent == "Eric")
      studentScores = ericScores;
  else if (currentStudent == "Gregor")
      studentScores = gregorScores;
  else
      continue;

  // initialize/reset the sum of scored assignments
  int sumAssignmentScores = 0;

  // initialize/reset the calculated average of exam + extra credit scores
  decimal currentStudentGrade = 0;

  // initialize/reset a counter for the number of assignment 
  int gradedAssignments = 0;

  // loop through the scores array and complete calculations for currentStudent
  foreach (int score in studentScores)
  {
    // increment the assignment counter
    gradedAssignments += 1;

    if(gradedAssignments <= currentAssignments)
    {
      // add the exam score to the sum
      sumAssignmentScores += score;
    }
    else
    {
      // add the extra credit points to the sum - bonus points equal to 10% of an exam score. rounding errors are acceptable
      sumAssignmentScores += score / 10;
    }
  }

  currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

  // student letter grading variable
  // Define grade thresholds and corresponding letter grades
  int[] gradeThresholds = { 97, 93, 90, 87, 83, 80, 77, 73, 70, 67, 63, 60, 0 };
  string[] letterGrades = { "A+", "A", "A-", "B+", "B", "B-", "C+", "C", "C-", "D+", "D", "D-", "F" };

  // Then in your loop, replace the long if-else chain:
  currentStudentLetterGrade = "F"; // default
  for (int i = 0; i < gradeThresholds.Length; i++)
  {
      if (currentStudentGrade >= gradeThresholds[i])
      {
          currentStudentLetterGrade = letterGrades[i];
          break;
      }
  }

  Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
