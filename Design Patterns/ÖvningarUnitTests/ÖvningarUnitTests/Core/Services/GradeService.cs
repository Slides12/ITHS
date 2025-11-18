namespace ÖvningarUnitTests.Core.Services
{
    public static class GradeService
    {
        public static string CalculateFinalGrade(int[] assignmentPoints, int examPoints)
        {
            if (examPoints < 0 || examPoints > 100)
                throw new ArgumentException("Exam points must be between 0 and 100");

            int totalAssignments = assignmentPoints?.Sum() ?? 0;

            if (totalAssignments < 0 || totalAssignments > 200)
                throw new ArgumentException("Invalid assignment total");

            int total = totalAssignments + examPoints;

            if (examPoints < 50)
                return "Fail";

            if (total >= 200)
                return "Pass with Distinction";

            return "Pass";
        }
    }
}
