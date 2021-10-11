
namespace SDD.Administration
{
    using SDD.Transaction;
    using Serenity.Services;

    public class ListRequestForum : ServiceRequest
    {
        public int? IdMasterForum { get; set; }
        public string DetailForum { get; set; }
        public string FotoDokumenForum { get; set; }
        public MyEnumStatus HiddenUser { get; set; }

    }

}