namespace AboutMe.Client.Models;
public class ResumeModel
{
    public BasicInfoModel BasicInfo { get; set; }

    public List<ExperienceModel> Experiences { get; set; }

    public EducationModel Education { get; set; }

    public List<LanguageModel> Languages { get; set; }

    public string TelegramId { get; set; }

    public string LinkedInProfile { get; set; }

    public List<string> HardSkills { get; set; }

    public List<string> SoftSkills { get; set; }

    public List<string> Tools { get; set; }

}
