namespace WepProjesi.Models
{
    public class AntrenorModeli
    {
        public int Id { get; set; }
        public string Ad { get; set; }           // اسم المدرب
        public string Uzmanlik { get; set; }     // التخصص
        public string MusaitSaatler { get; set; }// الساعات المتاحة
        public string Hizmetler { get; set; }    // أنواع الخدمات
    }
}
