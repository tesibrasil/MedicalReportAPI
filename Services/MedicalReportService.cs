using ImportMedicalReportAPI.DAL;
using ImportMedicalReportAPI.Interfaces;
using ImportMedicalReportAPI.Models.DTOs;

namespace ImportMedicalReportAPI.Services
{
    public class MedicalReportService : IMedicalReportService
    {
        private readonly IMedicalReportDAL _medicalReportDAL;

        public MedicalReportService(IMedicalReportDAL medReportDAL)
        {
            _medicalReportDAL = medReportDAL;
        }

        public void GetPatientMedicalReportsList(int patientID) {

            var reportList = _medicalReportDAL.GetMedicalReportList(patientID);


        }
    }


}
