using Esr.Core.Domain.Catalog;
using Esr.Core.Domain.ConfNumbering;
using Esr.Core.Domain.FiltersCompanies;
using Esr.Core.Domain.Other;
using Esr.Core.Domain.Translation;
using System.Collections.Generic;

namespace Esr.Core.Domain.Authentication
{
    public class GlobalUser
    {
        public static User User;
        public static Company Company { get; set; }
        public static IList<Translate> Translates { get; set; }
        public static IList<Table> Forms { get; set; }
        public static IList<DbTable> Tables { get; set; }
        public static IList<AutomaticNumbering> AutomaticNumberings { get; set; }
        public static IList<Log> Logs { get; set; } = new List<Log>();
    }
}
