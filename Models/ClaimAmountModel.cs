using System.ComponentModel.DataAnnotations;

namespace CrudMicroProject.Models
{
    public class ClaimAmountModel
    {
        [Key]
        public int Id { get; set; }
        public int PolicyID { get; set; }
        public int AddOnPolicyID { get; set; }
        public int ClaimID { get; set; }
        public int IDVvalue { get; set; }
        public double ClaimAmount { get; set; }
    }
}
