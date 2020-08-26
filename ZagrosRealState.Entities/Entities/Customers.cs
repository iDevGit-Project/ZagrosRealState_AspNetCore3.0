using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZagrosRealState.Entities.Entities
{
    public class Customers
    {
        [Key]
        public int Customers_Id { get; set; }
        public string Customers_Name { get; set; }
        public string Customers_Family { get; set; }
        public string Customers_CodeMelli { get; set; }
        public string Customers_Tell { get; set; }
        public string Customers_Mobile { get; set; }
        public string Customers_Job { get; set; }
        public string Customers_Address { get; set; }

        [Column(TypeName = "image")]
        public byte[] Customers_Image { get; set; }
        public string Customers_Url { get; set; }
        public DateTime? Customers_DatePublish { get; set; }
        public bool? Customers_Delete { get; set; }

        //public string ShamsiDate { get; set; }
        //public string ShamsiTime { get; set; }
        public int Customers_UserId { get; set; }

        public virtual Cities Cities { get; set; }
    }

    // ارتباط جداول منزل با یکدیگر
    public class Customers_PrimeryCategory
    {
        public int Customers_PrimeryCategoryID { get; set; }
        public string Customers_PrimeryCategoryName { get; set; }
    }

    public class Customers_SubPrimeryCategory
    {
        public int Customers_SubPrimeryCategoryID { get; set; }
        public string Customers_SubPrimeryCategoryName { get; set; }
    }

    //***********************************************************************************

    // لیست کلیه آیتم های مربوط به مشتری
    public class Customers_LST_JOB
    {
        [Key]
        public int Customers_LST_JOBId { get; set; }
        public string Customers_LST_JOBName { get; set; }
    }
}
