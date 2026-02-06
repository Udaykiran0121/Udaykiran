using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EsportsDetails.Models
{
    public class EsportsConnections: DbContext
    {
        public EsportsConnections():base("EsportsConnetion")
            {
                
            }
        public DbSet<Esports> EsportsDetails { get; set; }

    }
}