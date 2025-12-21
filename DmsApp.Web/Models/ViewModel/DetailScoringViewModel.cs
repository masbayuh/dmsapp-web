using DmsApp.Web.Models.Dto;

namespace DmsApp.Web.Models.ViewModel
{
    public class DetailScoringViewModel
    {
        public InformasiApplikasiViewModel InformasiAplikasi { get; set; } = new InformasiApplikasiViewModel();
        public GroupItemBobotModel BobotGroupItem { get; set; } = new GroupItemBobotModel();
        public GroupitemSummaryModel GroupitemSummary { get; set; } = new GroupitemSummaryModel();
        public double SummaryBobot { get; set; }
    }
}
