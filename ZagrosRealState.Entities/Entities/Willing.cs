using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZagrosRealState.Entities.Entities
{
    public class Willing
    {
        public int Willing_Id { get; set; }
        public string Willing_Name { get; set; }
        public string Willing_Family { get; set; }
        public string Willing_Mobile { get; set; }
        public string Willing_Price { get; set; }
        public string Willing_KhahanList { get; set; }
        public string Willing_JahatList { get; set; }
        public string Willing_Moshakhasat { get; set; }
        public string Willing_Address { get; set; }

        [Column(TypeName = "image")]
        public byte[] Willing_Image { get; set; }
        public bool? Willing_Delete { get; set; }
        public string Willing_Url { get; set; }
        public DateTime? Willing_DatePublish { get; set; }

        //public string ShamsiDate { get; set; }
        //public string ShamsiTime { get; set; }
        public int Willing_UserId { get; set; }

        //***********************************************************************************
    }
    // ارتباط جداول خواهان با یکدیگر
    public class Willing_PrimeryCategory
    {
        [Key]
        public int Willing_PrimeryCategoryID { get; set; }
        public string Willing_PrimeryCategoryName { get; set; }
    }

    public class Willing_SubPrimeryCategory
    {
        [Key]
        public int Willing_SubPrimeryCategoryID { get; set; }
        public string Willing_SubPrimeryCategoryName { get; set; }
    }

    //***********************************************************************************

    // لیست کلیه آیتم های مربوط به خواهان
    public class Willing_LST
    {
        [Key]
        public int Willing_LSTId { get; set; }
        public string Willing_LSTName { get; set; }
    }
    public class Willing_LST_Jahat
    {
        [Key]
        public int Willing_LST_JahatId { get; set; }
        public string Willing_LST_JahatName { get; set; }
    }
}
