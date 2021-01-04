using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TKA.Posts.Models
{
    [Table("TKAComments")]
    public class Comments 
    {
        public int CommentId { get; set; }
        public int ModuleId { get; set; }
        public int PostId { get; set; }
        public string Comment { get; set; }

        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string IsDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
