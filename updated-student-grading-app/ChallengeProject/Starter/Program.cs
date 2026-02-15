/* 
This C# console application is designed to:
- Use arrays to store student names and assignment scores.
- Use a `foreach` statement to iterate through the student names as an outer program loop.
- Use an `if` statement within the outer loop to identify the current student name and access that student's assignment scores.
- Use a `foreach` statement within the outer loop to iterate though the assignment scores array and sum the values.
- Use an algorithm within the outer loop to calculate the average exam score for each student.
- Use an `if-elseif-else` construct within the outer loop to evaluate the average exam score and assign a letter grade automatically.
- Integrate extra credit scores when calculating the student's final score and letter grade as follows:
    - detects extra credit assignments based on the number of elements in the student's scores array.
    - divides the values of extra credit assignments by 10 before adding extra credit scores to the sum of exam scores.
*/

int examAssignments = 5;

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

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

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;
    int extraCreditCount = 0;

    // Calculate exam scores and extra credit separately
    int assignmentIndex = 0;
    foreach (int score in studentScores)
    {
        assignmentIndex += 1;

        if (assignmentIndex <= examAssignments)
            sumExamScores += score;
        else
        {
            sumExtraCreditScores += score;
            extraCreditCount += 1;
        }
    }

    // Calculate exam average
    decimal examAverage = (decimal)sumExamScores / examAssignments;

    // Calculate extra credit points (divide by 10, then divide by exam count)
    decimal extraCreditPoints = (decimal)sumExtraCreditScores / 10 / examAssignments;

    // Calculate overall grade
    decimal overallGrade = examAverage + extraCreditPoints;

    // Calculate average extra credit score for display
    decimal avgExtraCredit = extraCreditCount > 0 ? (decimal)sumExtraCreditScores / extraCreditCount : 0;

    // Determine letter grade based on overall grade
    if (overallGrade >= 97)
        currentStudentLetterGrade = "A+";
    else if (overallGrade >= 93)
        currentStudentLetterGrade = "A";
    else if (overallGrade >= 90)
        currentStudentLetterGrade = "A-";
    else if (overallGrade >= 87)
        currentStudentLetterGrade = "B+";
    else if (overallGrade >= 83)
        currentStudentLetterGrade = "B";
    else if (overallGrade >= 80)
        currentStudentLetterGrade = "B-";
    else if (overallGrade >= 77)
        currentStudentLetterGrade = "C+";
    else if (overallGrade >= 73)
        currentStudentLetterGrade = "C";
    else if (overallGrade >= 70)
        currentStudentLetterGrade = "C-";
    else if (overallGrade >= 67)
        currentStudentLetterGrade = "D+";
    else if (overallGrade >= 63)
        currentStudentLetterGrade = "D";
    else if (overallGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{currentStudent}\t\t{examAverage:F1}\t\t{overallGrade:F2}\t{currentStudentLetterGrade}\t{Math.Round(avgExtraCredit)} ({extraCreditPoints:F2} pts)");
}

Console.WriteLine("\n\rPress the Enter key to continue");
Console.ReadLine();