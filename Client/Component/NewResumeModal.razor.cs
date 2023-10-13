using AboutMe.Client.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace AboutMe.Client.Component;

public partial class NewResumeModal
{
    private ImageFile fileBase64;

    [Parameter]
    public ResumeModel ResumeInstance { get; set; }

    [Parameter]
    public EventCallback<ResumeModel> OnSubmit { get; set; }

    private Dictionary<int, string> _workDescriptionsInputList = new Dictionary<int, string>();
    private Dictionary<int, string> WorkDescriptionsInputList
    {
        get { return _workDescriptionsInputList; }
        set { _workDescriptionsInputList = value; }
    }

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
    private List<string> SoftSkills { get; set; } = new List<string>();
    private List<string> Tools { get; set; } = new List<string>();
    private List<string> WorkDescriptions { get; set; } = new List<string>();
    private string HardSkillsInput { get; set; } = "";
    private string SoftSkillsInput { get; set; } = "";
    private string ToolsInput { get; set; } = "";
    private int _nextExperienceId { get; set; } = 1;

    private void AddExperience()
    {
        _nextExperienceId++;
        var newExp = new ExperienceModel { Id = _nextExperienceId };
        ResumeInstance.Experiences.Add(newExp);
        WorkDescriptionsInputList.Add(_nextExperienceId, "");
    }

    private void AddLanguage()
    {
        ResumeInstance.Languages.Add(new LanguageModel());
    }

    private void AddEducation()
    {
        ResumeInstance.Educations.Add(new EducationModel());
    }

    private async Task OnChange(InputFileChangeEventArgs e)
    {
        var file = e.File;
        var resizedFile = await file.RequestImageFileAsync("image/png", 640, 480);  // resize the image file
        var buf = new byte[resizedFile.Size];  // allocate a buffer to fill with the file's data
        using (var stream = resizedFile.OpenReadStream())
        {
            await stream.ReadAsync(buf);  // copy the stream to the buffer
        }
        fileBase64 = new ImageFile { base64data = Convert.ToBase64String(buf), contentType = file.ContentType, fileName = file.Name };  // convert to a base64 string!!
        ResumeInstance.BasicInfo.ProfilePhoto = fileBase64.base64data;
    }

    private void SaveResume()
    {
        // Split the hard skills input into a list of strings
        HardSkills = HardSkillsInput.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();
        SoftSkills = SoftSkillsInput.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();
        Tools = ToolsInput.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList();
        ResumeInstance.HardSkills = HardSkills;
        ResumeInstance.SoftSkills = SoftSkills;
        ResumeInstance.Tools = Tools;

        // Split the work descriptions input into a list of strings for each experience
        foreach (var experience in ResumeInstance.Experiences)
        {
            experience.WorkDescriptions = WorkDescriptionsInputList[experience.Id].Split("\n").ToList();
        }
        OnSubmit.InvokeAsync(ResumeInstance);
        // Save the resume
    }
}

