using DmsApp.Web.Models.Dto;

namespace DmsApp.Web.Models.ViewModel
{
    public class ScoringViewModel
    {
        public InformasiApplikasiViewModel InformasiAplikasi { get; set; } = new InformasiApplikasiViewModel();
        public GroupItemModel GroupItem { get; set; } = new GroupItemModel();
    }
}
