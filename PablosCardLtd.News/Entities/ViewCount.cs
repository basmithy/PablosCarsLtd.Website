using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PablosCardLtd.News.Entities
{
    public class ViewCount
    {
        public Guid ViewCountId { get; set; }
        public int ViewCountAmount { get; set; }

        
        public Article Article { get; set; }
    }
}
