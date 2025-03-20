using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TestBlazorHybridApp.Models
{
    public class tbl_fsu_list
    {
        [PrimaryKey, AutoIncrement]
        //auto Increment
        public int PK { get; set; }
        public Guid SurveyId { get; set; }
        public int FsuReferenceID { get; set; }
        public Guid UserId { get; set; }
        public string Fsu_id { get; set; }
        public string St { get; set; }
        public string Sro { get; set; }
        public string nss_reg { get; set; }
        public string Strm { get; set; }
        public string Sstrm { get; set; }
        public string Dc { get; set; }
        public string Dn { get; set; }
        public string Tehc { get; set; }
        public string Tehn { get; set; }
        public int Fc { get; set; }
        public string iv_unit { get; set; }
        public string Block { get; set; }
        public int FrameHh { get; set; }
        public string RoName { get; set; }
        public string SroName { get; set; }
        public string FsuName { get; set; }
        public string Tvc { get; set; }
        public string Tvn { get; set; }
        public int FramePop { get; set; }
        public int TotalSu { get; set; }
        public int SelSu { get; set; }
        public int SubRnd { get; set; }
        public string RoCode { get; set; }
        public string Asro { get; set; }
        public string Aro { get; set; }
        public string Stn { get; set; }
        public int visit_no { get; set; }
        public int quarter { get; set; }
        public int Sec { get; set; }
        public Guid Id { get; set; }

        public int sample { get; set; }
        public string enumerator { get; set; }
        public string supervisor { get; set; }

        public bool IsDoSelectionDone { get; set; }
        public bool IsDoSelectionDone_CMS { get; set; }
        public bool IsReSelectionEnabled { get; set; }
        public int updatelistingcount { get; set; }
        public int? assigntoEnumaretor { get; set; }
        public int? returnBacktoEnumaretor { get; set; }
        public int? casualty { get; set; }
        public int? submittedbyEnumaretorToSuperviosr { get; set; }
        public int? submiitedbySuperviosrToDs { get; set; }
        public int? acceptedByDS { get; set; }
        public int? returntoSuperviosrbyDS { get; set; }
        public int? lookupFsuSubmitStatus { get; set; }
        [JsonIgnore]
        public bool _showDownloadButton;
        public int? isSubstituteDone { get; set; } = 0;
        [JsonIgnore]
        public bool downloadNeeded { get; set; }
    }

    public class fsuhouse
    {
        public Guid id { get; set; }
        public int tenant_id { get; set; }
        public string fsu_id { get; set; }
        public int hhd_id { get; set; }
        public Guid survey_id { get; set; }
        public int lookup_submit_status { get; set; }
    }
}
