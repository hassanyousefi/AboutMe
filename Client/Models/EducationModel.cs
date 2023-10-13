using Bit.BlazorUI;

namespace AboutMe.Client.Models;

public class EducationModel
{
    public string FieldOfStudy { get; set; }
    public string UniversityName { get; set; }
    public BitDateRangePickerValue EducationDateRange { get; set; }
}