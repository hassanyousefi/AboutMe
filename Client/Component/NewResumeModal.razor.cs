using AboutMe.Client.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Components.Forms;
using System.Collections.Generic;

namespace AboutMe.Client.Component;

public partial class NewResumeModal
{
    public ResumeModel ResumeInstance { get; set; }
    protected async override Task OnInitializedAsync()
    {
        ResumeInstance = new()
        {
            BasicInfo = new BasicInfoModel { },
            Experiences = new List<ExperienceModel> { },
            Languages = new List<LanguageModel> { },
            Educations = new List<EducationModel> { },
        };
    }



    private List<string> HardSkills { get; set; } = new List<string>();

    private List<string> WorkDescriptions { get; set; } = new List<string>();

    private string HardSkillsInput { get; set; } = "";

    private string SoftSkillsInput { get; set; } = "";

    private string ToolsInput { get; set; } = "";

    private List<string> WorkDescriptionsInputList { get; set; } = new List<string>();

    private string WorkDescriptionsInput
    {
        get
        {
            return string.Join("\n", WorkDescriptionsInputList);
        }
        set
        {
            WorkDescriptionsInputList = value.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }

    private void AddExperience()
    {
        ResumeInstance.Experiences.Add(new ExperienceModel());
        WorkDescriptionsInputList.Add("");
    }

    private void AddLanguage()
    {
        ResumeInstance.Languages.Add(new LanguageModel());
    }

    private void AddEducation()
    {
        ResumeInstance.Educations.Add(new EducationModel());
    }

    private void SaveResume()
    {
        // Split the hard skills input into a list of strings
        HardSkills = HardSkillsInput.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();
        ResumeInstance.HardSkills = HardSkills;

        // Split the work descriptions input into a list of strings for each experience
        for (int i = 0; i < ResumeInstance.Experiences.Count; i++)
        {
            WorkDescriptionsInputList[i] = WorkDescriptionsInputList[i].TrimEnd('\n');
            WorkDescriptions = WorkDescriptionsInputList[i].Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();
            ResumeInstance.Experiences[i].WorkDescriptions = WorkDescriptions;
        }

        // Save the resume
    }
}

