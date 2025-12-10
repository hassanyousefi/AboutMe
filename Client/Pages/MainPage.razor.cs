using AboutMe.Client.Models;
using System;

namespace AboutMe.Client.Pages;
public partial class MainPage
{

    private ResumeModel ResumeInstance = new ResumeModel();
    public bool isModalOpen = false;

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
        ResumeInstance = new()
        {
            BasicInfo = new BasicInfoModel
            {
                Name = "HASSAN YOUSEFI",
                JobTitle = "Senior Frontend Developer",
                PhoneNumber = "+98 922 118 0851",
                Email = "hasanusefi69@gmail.com",
                GitAddress = "https://github.com/hassanyousefi",
                Location = "Iran, Tehran",
                ProfilePhoto = "images/my-pic.jpg"
            },
            Experiences = new List<ExperienceModel> {
                    new ExperienceModel {
                        PostTitle = "Full-Stack Developer",
                        CompanyName = "SciPub+ (Deepentix)",
                        WorkDateRange = new()
                            {
                                StartDate = new DateTimeOffset(new DateTime(2023, 4, 10), DateTimeOffset.Now.Offset)
                            },
                        CompanySiteAddress = "https://scipubplus.com",
                        WorkDescriptions = new List<string> {
                            "Collaborated in a small, fast-paced team of four developers to deliver production-ready features.",
                            "Worked on web products that integrate advanced <span style='font-weight: 100'>AI</span> capabilities into core user workflows.",
                            "Implemented and refined responsive UIs, improving usability and consistency across the application.",
                            "Generated and optimized UI layouts and components, ensuring clean, maintainable frontend code.",
                            "Expanded skills into DevOps (CI/CD pipelines) and backend API development using ASP.NET."
                        }
                    },
                    new ExperienceModel {
                        PostTitle = "Angular Developer",
                        CompanyName = "RIGID ROBOTICS",
                        WorkDateRange = new()
                            {
                                StartDate = new DateTimeOffset(new DateTime(2021, 11, 1), DateTimeOffset.Now.Offset),
                                EndDate = new DateTimeOffset(new DateTime(2023, 4, 1), DateTimeOffset.Now.Offset)
                            },
                        CompanySiteAddress = "https://rigidrobotics.com",
                        WorkDescriptions = new List<string> {
                            "Served as a key member of a remote seven-person Scrum team (“Bit Foundation”) delivering production features.",
                            "Translated complex UI/UX designs from Figma into clean, reusable, and responsive user interfaces.",
                            "Led frontend development of an enterprise IoT device portal, including a dynamic visualization of the data flow from devices to end-users."
                        }
                    },
                    new ExperienceModel {
                        PostTitle = "Angular Developer",
                        CompanyName = "Jabiz Parda",
                        WorkDateRange = new()
                            {
                                StartDate = new DateTimeOffset(new DateTime(2021, 1, 1), DateTimeOffset.Now.Offset),
                                EndDate = new DateTimeOffset(new DateTime(2022, 1, 1), DateTimeOffset.Now.Offset)
                            },
                        CompanySiteAddress = "https://jabizparda.com",
                        WorkDescriptions = new List<string> {
                            "Led and mentored a remote team of five frontend developers, coordinating delivery and code quality.",
                            "Developed custom web applications for small and medium-sized businesses, tailored to their specific workflows.",
                            "Oversaw the implementation of UI/UX designs from Zeplin and Figma into high-quality, responsive web interfaces."
                        }
                    },
                    new ExperienceModel {
                        PostTitle = "Angular Developer",
                        CompanyName = "MelkRadar",
                        WorkDateRange = new()
                            {
                                StartDate = new DateTimeOffset(new DateTime(2019, 11, 1), DateTimeOffset.Now.Offset),
                                EndDate = new DateTimeOffset(new DateTime(2021, 1, 1), DateTimeOffset.Now.Offset)
                            },
                        CompanySiteAddress = "melkradar.com",
                        WorkDescriptions = new List<string> {
                            "Collaborated in a nine-person Scrum team to deliver new features on a regular cadence.",
                            "Developed frontend components and ensured smooth implementation of UI/UX designs from Zeplin.",
                            "Contributed to a cross-platform real estate application optimized for web, Android WebView, and PWA with a consistent, unified user interface across all platforms."
                        }
                    },
                    new ExperienceModel {
                        PostTitle = "Intern",
                        CompanyName = "CS Internship",
                        WorkDateRange = new()
                            {
                                StartDate = new DateTimeOffset(new DateTime(2019, 3, 1), DateTimeOffset.Now.Offset),
                                EndDate = new DateTimeOffset(new DateTime(2019, 11, 1), DateTimeOffset.Now.Offset)
                            },
                        CompanySiteAddress = "https://virgool.io/cs-internship",
                        WorkDescriptions = new List<string> {
                            "Completed an intensive remote programming internship, strengthening both technical abilities and collaboration skills in a fully online environment."
                        }
                    },
            },
            Educations = new List<EducationModel>
            {
                    new EducationModel
                    {
                        FieldOfStudy = "Computer Science",
                        UniversityName = "University of Tabriz",
                        EducationDateRange = new()
                            {
                                StartDate = new DateTimeOffset(new DateTime(2018, 9, 23), DateTimeOffset.Now.Offset),
                                EndDate = new DateTimeOffset(new DateTime(2022, 9, 23), DateTimeOffset.Now.Offset)
                            },
                    }
            },
            Languages = new List<LanguageModel> {
                    new LanguageModel
                    {
                        LangName = "Persian",
                        Level = 100,
                    },
                    new LanguageModel
                    {
                        LangName = "English",
                        Level = 60,
                    }
            },
            TelegramId = "hassanusefi",
            LinkedInProfile = "hassan-yousefi",
            HardSkills = new List<string> {
                    "JavaScript",
                    "TypeScript",
                    "Angular",
                    "HTML",
                    "CSS",
                    "SCSS",
                    "Tailwind",
                    "Nest.js",
                    "Git",
            },
            SoftSkills = new List<string> {
                    "Teamwork",
                    "Responsibility",
                    "Remote Work",
                    "Active listening"
            },
            Tools = new List<string> {
                    "VS Code",
                    "Visual Studio",
                    "Github Actions",
                    "Microsoft Azure",
                    "Trello",
                    "Slack",
                    "AWS",
                    "Cloudflare"
            }
        };
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
