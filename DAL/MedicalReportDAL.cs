using Dapper;
using ImportMedicalReportAPI.Interfaces;
using ImportMedicalReportAPI.Models.DTOs;
using System.Data;
using System.Data.SqlClient;

namespace ImportMedicalReportAPI.DAL
{
    public class MedicalReportDAL : IMedicalReportDAL
    {
        private readonly IConfiguration _configuration;

        public MedicalReportDAL(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private IDbConnection CreateConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString("DefaultConnection"));
        }

        public IEnumerable<MedicalReportDTO> GetMedicalReportList(int patientID)
        {
            using (var connection = CreateConnection())
            {
                string query = @"
                    SELECT DATA as DATAORA, REFERTOTESTORTF as TESTORTF, PROGRESSIVOANNO, PAZIENTE 
                    FROM EESAMI 
                    WHERE PAZIENTE = @Id";

                var result = connection.Query<MedicalReportDTO>(query, 
                    new {   
                         Id = patientID 
                    }).ToList();

                return result;
            }
        }
    }
}
