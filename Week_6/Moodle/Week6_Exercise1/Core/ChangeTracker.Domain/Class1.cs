
using ChangeTracker.Domain.Entities;
using ChangeTracker.Domain.Enums;

Console.WriteLine("Change Trcaker");

JobPost jobPost1 = new()
{
    Title = "Software Developer",
    Company = "InnoTech Innovations",
    Description = "We are seeking a talented and enthusiastic software developer to join our innovative team. The ideal candidate should have strong problem-solving skills and a passion for creating high-quality software solutions. Responsibilities include designing, coding, testing, and debugging software applications, as well as collaborating with cross-functional teams to define, design, and ship new features. Experience with popular web development frameworks and programming languages is a plus. Competitive salary and benefits package offered.",
    WorkMode = WorkMode.InOffice,
    CreatedOn = DateTime.Now,
};