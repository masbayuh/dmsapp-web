using System.ComponentModel.DataAnnotations;

namespace DmsApp.Web.Models.ViewModel
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Display(Name = "Menu Name")]
        [Required]
        public string MenuName { get; set; } = string.Empty;
        [Display(Name = "Menu Code")]
        public string MenuCode { get; set; } = string.Empty;
        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;
        [Display(Name = "Last Update")]
        public DateTime LastUpdate { get; set; }
        [Display(Name = "PIC")]
        public string PIC { get; set; } = string.Empty;
        [Display(Name = "Version")]
        public string Version { get; set; } = string.Empty;
        [Display(Name = "Module")]
        public string Module { get; set; } = string.Empty;
        [Display(Name = "Status")]
        public string Status { get; set; } = string.Empty;
        [Display(Name = "Notes")]
        public string Notes { get; set; } = string.Empty;
    }
}
