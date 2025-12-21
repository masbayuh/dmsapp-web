using DmsApp.Web.Models.Dto;
using DmsApp.Web.Models.ViewModel;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DmsApp.Web.Services
{
    public class ScoringService
    {
        public DetailScoringViewModel DetailScoring (ScoringViewModel view) {
            var result = new DetailScoringViewModel ();
            result.InformasiAplikasi = view.InformasiAplikasi;

            result.BobotGroupItem = getBobotItem(view.GroupItem);
            result.GroupitemSummary = getSummaryBobot(result.BobotGroupItem);
            result.SummaryBobot = 
                result.GroupitemSummary.Informasi1 +
                result.GroupitemSummary.Informasi2 +
                result.GroupitemSummary.Informasi3 +
                result.GroupitemSummary.Informasi4 +
                result.GroupitemSummary.Informasi5 +
                result.GroupitemSummary.Informasi6;


            return result;
        }

        private GroupitemSummaryModel getSummaryBobot(GroupItemBobotModel bobotItem) {

            var summary = new GroupitemSummaryModel ();
            summary.Informasi1 = getBobot(bobotItem.UmurPemohonBobot + 
                bobotItem.UmurPemohonPlusTenorBobot + 
                bobotItem.StatusPerkawinanBobot + 
                bobotItem.PendidikanBobot, 5)  ;
            summary.Informasi2 = getBobot(bobotItem.AlamatTempatTinggalBobot + 
                bobotItem.KepemilikanTempatTinggalBobot + 
                bobotItem.LamaMenempatiBobot, 5);
            summary.Informasi3 = getBobot(bobotItem.KategoriPerusahaanBobot +
                bobotItem.JabatanBobot + 
                bobotItem.LamaBekerjaBobot + 
                bobotItem.PendapatanTHPBobot, 20);
            summary.Informasi4 = getBobot(bobotItem.RekeningBankBobot +
                bobotItem.RataSaldoPerBulanBobot + 
                bobotItem.TrackRecordPembayaranBobot + 
                bobotItem.TrackDataSLIKBobot + 
                bobotItem.KepemilikanKartuKreditBobot, 15);
            summary.Informasi5 = getBobot(bobotItem.TenorBobot +
                bobotItem.DebtServiceRatioBobot, 30);
            summary.Informasi6 = getBobot(bobotItem.HasilAppraisalBobot +
                bobotItem.LuasBangunanBobot + 
                bobotItem.TujuanPembiayaanBobot + 
                bobotItem.LTVBobot, 25);

            return summary;
        }

        private GroupItemBobotModel getBobotItem(GroupItemModel item) {
            GroupItemBobotModel bobotItem = new Models.Dto.GroupItemBobotModel();
            bobotItem.UmurPemohonBobot = getBobot(item.UmurPemohon, 30);
            bobotItem.UmurPemohonPlusTenorBobot = getBobot(item.UmurPemohonPlusTenor, 10);
            bobotItem.StatusPerkawinanBobot = getBobot(item.StatusPerkawinan, 40);
            bobotItem.PendidikanBobot = getBobot(item.Pendidikan, 20);
            bobotItem.AlamatTempatTinggalBobot = getBobot(item.AlamatTempatTinggal, 40);
            bobotItem.KepemilikanTempatTinggalBobot = getBobot(item.KepemilikanTempatTinggal, 30);
            bobotItem.LamaMenempatiBobot = getBobot(item.LamaMenempati, 30);
            bobotItem.KategoriPerusahaanBobot = getBobot(item.KategoriPerusahaan, 20);
            bobotItem.JabatanBobot = getBobot(item.Jabatan, 30);
            bobotItem.LamaBekerjaBobot = getBobot(item.LamaBekerja, 20);
            bobotItem.PendapatanTHPBobot = getBobot(item.PendapatanTHP, 40);
            bobotItem.RekeningBankBobot = getBobot(item.RekeningBank, 10);
            bobotItem.RataSaldoPerBulanBobot = getBobot(item.RataSaldoPerBulan, 15);
            bobotItem.TrackRecordPembayaranBobot = getBobot(item.TrackRecordPembayaran, 15);
            bobotItem.TrackDataSLIKBobot = getBobot(item.TrackDataSLIK, 40);
            bobotItem.KepemilikanKartuKreditBobot = getBobot(item.KepemilikanKartuKredit, 20);
            bobotItem.TenorBobot = getBobot(item.Tenor, 25);
            bobotItem.DebtServiceRatioBobot = getBobot(item.DebtServiceRatio, 75);
            bobotItem.HasilAppraisalBobot = getBobot(item.HasilAppraisal, 10);
            bobotItem.LuasBangunanBobot = getBobot(item.LuasBangunan, 20);
            bobotItem.TujuanPembiayaanBobot = getBobot(item.TujuanPembiayaan, 10);
            bobotItem.LTVBobot = getBobot(item.LTV, 50);

            return bobotItem;
        }

        private double getBobot (double nilaiItem, double bobotMaksimal) {
            return (nilaiItem / 100) * bobotMaksimal;
        }
    }
}
