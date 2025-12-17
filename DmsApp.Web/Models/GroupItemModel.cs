using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DmsApp.Web.Models
{
    public class GroupItemModel
    {
        public long Id { get; set; }
        
        [DisplayName("Umur Pemohon")]
        [Required]
        public int UmurPemohon { get; set; }
        
        [DisplayName("Umur Pemohon + Tenor")]
        [Required]
        public string UmurPemohonPlusTenor { get; set; } = string.Empty;

        [DisplayName("Status Perkawinan")]
        [Required]
        public string StatusPerkawinan { get; set; } = string.Empty;
        
        [Required]
        public string Pendidikan { get; set; } = string.Empty;
        
        [DisplayName("Alamat Tempat Tinggal")]
        [Required]
        public string AlamatTempatTinggal { get; set; } = string.Empty;
        
        [DisplayName("Kepemilikan Tempat Tinggal")]
        [Required]
        public string KepemilikanTempatTinggal { get; set; } = string.Empty;

        [DisplayName("Lama Menempati (dalam tahun)")]
        [Required]
        public int LamaMenempati { get; set; }
        
        [DisplayName("Kategori Perusahaan")]
        [Required]
        public string KategoriPerusahaan { get; set; } = string.Empty;
        
        [Required]
        public string jabatan { get; set; } = string.Empty;

        [DisplayName("Lama Bekerja (dalam tahun)")]
        [Required]
        public int LamaBekerja { get; set; }

        [DisplayName("Pendapatan THP (dalam juta rupiah)")]
        [Required]
        public double PendapatanTHP { get; set; }

        [DisplayName("Rekening Bank")]
        [Required]
        public string RekeningBank { get; set; } = string.Empty;

        [DisplayName("Rata-rata Saldo per Bulan")]
        [Required]
        public int RataRataSaldoPerBulan { get; set; }

        [DisplayName("Track Record Pembayaran")]
        [Required]
        public string TrackRecordPembayaran { get; set; } = string.Empty;

        [DisplayName("Track Data SLIK")]
        [Required]
        public string TrackDataSLIK { get; set; } = string.Empty;
        
        [DisplayName("Kepemilikan Kartu Kredit")]
        [Required]
        public string KepemilikanKartuKredit { get; set; } = string.Empty;
        
        [Required]
        public int Tenor { get; set; }

        [DisplayName("Debt Service Ratio")]
        [Required]
        public int DebtServiceRatio { get; set; }

        [DisplayName("Hasil Appraisal")]
        [Required]
        public string HasilAppraisal { get; set; } = string.Empty;
        
        [DisplayName("Luas Bangunan")]
        [Required]
        public int LuasBangunan { get; set; }
        
        [DisplayName("Tujuan Dari Pembiayaan")]
        [Required]
        public string TujuanDariPembiayaan { get; set; } = string.Empty;
        
        [Required]
        public int LTV { get; set; }
    }
}
