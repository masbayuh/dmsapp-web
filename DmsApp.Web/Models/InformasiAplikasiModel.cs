using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DmsApp.Web.Models
{
    public class InformasiAplikasiModel
    {
        public long Id { get; set; }
        [DisplayName("Nomor Applikasi")]
        [Required]
        public string NomorApplikasi { get; set; } = string.Empty;
        [Required]
        public string Nama {  get; set; } = string.Empty;
        [DisplayName("Tempat Lahir")]
        public string TempatLahir { get; set; } = string.Empty;
        [DisplayName("Tanggal Lahir")]
        public DateTime TanggalLahir { get; set; }
        [DisplayName("Jenis Kelamin")]
        public string JenisKelamin { get; set; } = string.Empty;
        [DisplayName("Kode Pos")]
        public string KodePos { get; set; } = string.Empty;
        public string Alamat { get; set; } = string.Empty;

    }
}
