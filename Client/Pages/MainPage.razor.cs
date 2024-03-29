﻿using AboutMe.Client.Models;
using System;

namespace AboutMe.Client.Pages;
public partial class MainPage
{

    private ResumeModel ResumeInstance = new ResumeModel();
    public bool isModalOpen = true;

    private async Task HandleSubmit(ResumeModel resumeData)
    {
        // Store the submitted data in a private field or property of your main page component.
        ResumeInstance = resumeData;
        isModalOpen = false;
        // Call the StateHasChanged method to update the UI with the new data.
        // This is necessary because the data has changed outside of the normal Blazor data flow.
        await InvokeAsync(StateHasChanged);
    }
    protected async override Task OnInitializedAsync()
    {
        //ResumeInstance = new()
        //{
        //    BasicInfo = new BasicInfoModel
        //    {
        //        Name = "HASSAN YOUSEFI",
        //        JobTitle = "Frontend Developer",
        //        PhoneNumber = "+98 922 118 0851",
        //        Email = "hasanusefi69@gmail.com",
        //        GitAddress = "github.com/hassanyousefi",
        //        Location = "Iran, Tehran",
        //    },
        //    Experiences = new List<ExperienceModel> {
        //            new ExperienceModel {
        //                PostTitle = "Angular Developer",
        //                CompanyName = "RIGID ROBOTICS",
        //                WorkDateRange = new()
        //                    {
        //                        StartDate = new DateTimeOffset(new DateTime(2020, 1, 17), DateTimeOffset.Now.Offset),
        //                        EndDate = new DateTimeOffset(new DateTime(2020, 1, 25), DateTimeOffset.Now.Offset)
        //                    },
        //                CompanySiteAddress = "rigidrobotics.com",
        //                WorkDescriptions = new List<string> {
        //                    "Collaborated remotely with a specialist team (called the <b>Bit Foundation</b> team) of 6 other members",
        //                    "With the scrum methodology",
        //                    "The UI/UX design by Figma was delivered to the frontend team",
        //                    "The project was an enterprise portal for IoT devices, and one of the challenges was to implement and update a rather complex diagram that visualized the roadmap from IoT devices to customers."
        //                },
        //            },
        //            new ExperienceModel {
        //                PostTitle = "Angular Developer",
        //                CompanyName = "Jabiz Parda",
        //                WorkDateRange = new()
        //                    {
        //                        StartDate = new DateTimeOffset(new DateTime(2020, 1, 17), DateTimeOffset.Now.Offset),
        //                        EndDate = new DateTimeOffset(new DateTime(2020, 1, 25), DateTimeOffset.Now.Offset)
        //                    },
        //                CompanySiteAddress = "jabizparda.com",
        //                WorkDescriptions = new List<string> {
        //                    "Collaborated remotely with a team of 5 other members as frontend team leader",
        //                    "Developed various software applications for small businesses",
        //                    "The UI/UX design by Zeplin and Figma was delivered to the frontend team",
        //                },
        //            },
        //            new ExperienceModel {
        //                PostTitle = "Angular Developer",
        //                CompanyName = "MelkRadar",
        //                WorkDateRange = new()
        //                    {
        //                        StartDate = new DateTimeOffset(new DateTime(2020, 1, 17), DateTimeOffset.Now.Offset),
        //                        EndDate = new DateTimeOffset(new DateTime(2020, 1, 25), DateTimeOffset.Now.Offset)
        //                    },
        //                CompanySiteAddress = "melkradar.com",
        //                WorkDescriptions = new List<string> {
        //                    "Collaborated remotely with a specialist team of 8 other members",
        //                    "With the scrum methodology",
        //                    "The UI/UX design by Zeplin was delivered to the frontend team",
        //                    "A software project that collects home buying and selling ads and can be used in different ways, such as a website, an android app (webview) and a PWA. One of the major challenges was displaying the UI correctly on all platforms.",
        //                },
        //            },
        //            new ExperienceModel {
        //                PostTitle = "Intern",
        //                CompanyName = "CS Internship",
        //                WorkDateRange = new()
        //                    {
        //                        StartDate = new DateTimeOffset(new DateTime(2020, 1, 17), DateTimeOffset.Now.Offset),
        //                        EndDate = new DateTimeOffset(new DateTime(2020, 1, 25), DateTimeOffset.Now.Offset)
        //                    },
        //                CompanySiteAddress = "virgool.io/cs-internship",
        //                WorkDescriptions = new List<string> {
        //                    "The CS Internship is a remote programming training course that includes learning soft skills, hard skills, remote work and teamwork.",
        //                },
        //            },
        //    },
        //    Educations = new List<EducationModel>
        //    {
        //            new EducationModel
        //            {
        //                FieldOfStudy = "Computer Science",
        //                UniversityName = "University of Tabriz",
        //                EducationDateRange = new()
        //                    {
        //                        StartDate = new DateTimeOffset(new DateTime(2020, 1, 17), DateTimeOffset.Now.Offset),
        //                        EndDate = new DateTimeOffset(new DateTime(2020, 1, 25), DateTimeOffset.Now.Offset)
        //                    },
        //            },
        //            new EducationModel
        //            {
        //                FieldOfStudy = "Computer Science",
        //                UniversityName = "University of Tabriz",
        //                EducationDateRange = new()
        //                    {
        //                        StartDate = new DateTimeOffset(new DateTime(2020, 1, 17), DateTimeOffset.Now.Offset),
        //                        EndDate = new DateTimeOffset(new DateTime(2020, 1, 25), DateTimeOffset.Now.Offset)
        //                    },
        //            }
        //    },
        //    Languages = new List<LanguageModel> {
        //            new LanguageModel
        //            {
        //                LangName = "Persian",
        //                Level = 100,
        //            },
        //            new LanguageModel
        //            {
        //                LangName = "English",
        //                Level = 60,
        //            }
        //    },
        //    TelegramId = "hassanusefi",
        //    LinkedInProfile = "hassan-yousefi",
        //    HardSkills = new List<string> {
        //            "JavaScript",
        //            "TypeScript",
        //            "Angular",
        //            "HTML",
        //            "CSS",
        //            "SCSS",
        //            "Git",
        //    },
        //    SoftSkills = new List<string> {
        //            "Teamwork",
        //            "Responsibility",
        //            "Remote Work",
        //            "Active listening"
        //    },
        //    Tools = new List<string> {
        //            "VS Code",
        //            "Visual Studio",
        //            "Github",
        //            "Microsoft Azure",
        //            "Microsoft Teams",
        //    }
        //};
    }

    private static string GetLangLevel(int levelNumber)
    {
        if (levelNumber > 0 && levelNumber <= 20) return "Beginner";
        else if (levelNumber > 20 && levelNumber <= 40) return "Elementary";
        else if (levelNumber > 40 && levelNumber <= 50) return "Intermediate";
        else if (levelNumber > 50 && levelNumber <= 60) return "Upper Intermediate";
        else if (levelNumber > 60 && levelNumber <= 80) return "Advanced";
        else if (levelNumber > 80 && levelNumber <= 100) return "Native";
        return "unknown";
    }
}
