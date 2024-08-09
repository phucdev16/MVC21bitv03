using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DEVDOCNETMidtest.Models.DBEntities
{
    public class Customer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
            public string   Name { get; set; }
            public  DateTime   BirthDate { get; set; }
        public blood IsyoungDriver { get; set; }


    }


}
