// initialize variables - graded assignments 
int currentAssignments = 5;
int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];    

// Student names
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"];

Console.WriteLine("Student\t\tGrade\n");
foreach (string student in studentNames)
{
    decimal studentScore = 0;
    decimal extraCredit = 0;
    string studentGrade = "";
    if (student == "Sophia")
    {
        studentScore = sophiaScores.Take(5).Sum();
        extraCredit = (decimal)sophiaScores.Skip(5).Sum(score => score * 0.10);
        studentScore += extraCredit;
        studentScore /= currentAssignments;
        studentGrade = getStudentGrade(studentScore);
    }
    else if (student == "Andrew")
    {
        studentScore = andrewScores.Take(5).Sum();
        extraCredit = (decimal)andrewScores.Skip(5).Sum(score => score * 0.10);
        studentScore += extraCredit;
        studentScore /= currentAssignments;
        studentGrade = getStudentGrade(studentScore);
    }
    else if (student == "Emma")
    {
        studentScore = emmaScores.Take(5).Sum();
        extraCredit = (decimal)emmaScores.Skip(5).Sum(score => score * 0.10);
        studentScore += extraCredit;
        studentScore /= currentAssignments;
        studentGrade = getStudentGrade(studentScore);
    }
    else if (student == "Logan")
    {
        studentScore = loganScores.Take(5).Sum(); 
        extraCredit = (decimal)loganScores.Skip(5).Sum(score => score * 0.10);
        studentScore += extraCredit;
        studentScore /= currentAssignments;
        studentGrade = getStudentGrade(studentScore);
    }
    else if (student == "Becky")
    {
        studentScore = beckyScores.Take(5).Sum();
        extraCredit = (decimal)beckyScores.Skip(5).Sum(score => score * 0.10);
        studentScore += extraCredit;
        studentScore /= currentAssignments;
        studentGrade = getStudentGrade(studentScore);
    }
    else if (student == "Chris")
    {
        studentScore = chrisScores.Take(5).Sum();
        extraCredit = (decimal)chrisScores.Skip(5).Sum(score => score * 0.10);
        studentScore += extraCredit;
        studentScore /= currentAssignments;
        studentGrade = getStudentGrade(studentScore);
    }
    else if (student == "Eric")
    {
        studentScore = ericScores.Take(5).Sum();
        extraCredit = (decimal)ericScores.Skip(5).Sum(score => score * 0.10);
        studentScore += extraCredit;
        studentScore /= currentAssignments;
        studentGrade = getStudentGrade(studentScore);
    }
    else if (student == "Gregor")
    {
        studentScore = gregorScores.Take(5).Sum();
        extraCredit = (decimal)gregorScores.Skip(5).Sum(score => score * 0.10);
        studentScore += extraCredit;
        studentScore /= currentAssignments;
        studentGrade = getStudentGrade(studentScore);
    }
    else 
        continue;
    
    Console.WriteLine($"{student}\t\t{studentScore}\t{studentGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

static string getStudentGrade(decimal studentScore)
{
    return studentScore switch
    {
        >= 97 => "A+",
        >= 93 => "A",
        >= 90 => "A-",
        >= 87 => "B+",
        >= 83 => "B",
        >= 80 => "B-",
        >= 77 => "C+",
        >= 73 => "C",
        >= 70 => "C-",
        >= 67 => "D+",
        >= 63 => "D",
        >= 60 => "D-",
        _ => "F",
    };
}
