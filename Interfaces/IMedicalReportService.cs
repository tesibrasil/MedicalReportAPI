using ImportMedicalReportAPI.Models.DTOs;

namespace ImportMedicalReportAPI.Interfaces
{
    public interface IMedicalReportService
    {
        void GetPatientMedicalReportsList(int patientID);
    }
}
