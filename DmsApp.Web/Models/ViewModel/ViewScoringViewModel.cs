using DmsApp.Web.Models.Dto;

namespace DmsApp.Web.Models.ViewModel
{
    public class ViewScoringViewModel
    {
        public InformasiApplikasiViewModel InformasiAplikasi { get; set; } = new InformasiApplikasiViewModel();
        public GroupItemBobotModel BobotGroupItem { get; set; } = new GroupItemBobotModel();
        public GroupitemSummaryModel GroupitemSummary { get; set; } = new GroupitemSummaryModel();
    }
}
