using System.ComponentModel.DataAnnotations;

namespace CrudMicroProject.Models
{
    public class InsuranceApplyModel
    {
        [Key]
        public int ApplyId { get; set; }
        public int UserID { get; set; }
        public int PolicyID { get; set; }
        public int AddOnPolicyID { get; set; }
        public int VehicleID { get; set; }
        public string ? status { get; set; }

    }
}
