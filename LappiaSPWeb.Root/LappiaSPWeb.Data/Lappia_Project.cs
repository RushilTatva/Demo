using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace EducationSite
{

    public class Project_Detail
    {
        public string Hanke_ID { get; set; }
        public string Nimi { get; set; }
        public string Tavoite { get; set; }
        public string Tulokset { get; set; }
        public string Paatoteuttaja { get; set; }
        public string Yhteistyokumppanit { get; set; }
        public string Aikataulu { get; set; }
        public string Lisatietoja { get; set; }
        public string Kotisivut { get; set; }
        public string Rahoituslahde { get; set; }
        public string Logo { get; set; }
        public string Liitteet { get; set; }
    }

    public class Document_Detail
    {
        public string Filename { get; set; }
        public string DokumenttiURL { get; set; }
        public string ReportCode { get; set; }
    }

    public class Paatoteuttaja_Detail
    {
        public string Hanke_ID { get; set; }
        public string Rooli { get; set; }
        public string Yhteiso { get; set; }
        public string Rahoituslahde { get; set; }
    }

    public class Rahoituslahde_Detail
    {
        public string Hanke_ID { get; set; }
        public string Rahoituslahde { get; set; }
    }

    public class Project_Listing
    {
        public string Hanke_ID { get; set; }
        public string Nimi { get; set; }
        public string JulkaisuPaikka { get; set; }
        public DateTime Aikataulu { get; set; }
    }

    public class Project_Pagemap
    {   
        public string Name { get; set; }
        public string Subsection { get; set; }
        public string Url { get; set; }
        public Guid TermId { get; set; }
    }
}
