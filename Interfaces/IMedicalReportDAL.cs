using ImportMedicalReportAPI.Models.DTOs;

namespace ImportMedicalReportAPI.Interfaces
{
    public interface IMedicalReportDAL
    {
        IEnumerable<MedicalReportDTO>GetMedicalReportList(int patientID);
    }
}
