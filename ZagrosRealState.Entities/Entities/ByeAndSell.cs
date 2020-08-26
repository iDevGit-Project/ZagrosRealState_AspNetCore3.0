using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZagrosRealState.Entities.Entities
{
    public class ByeAndSell
    {
        [Key]
        public int ByeAndSell_Id { get; set; }
        public string ByeAndSellCode_Id { get; set; }
        public string ByeAndSell_TypeMoredeMoameleh { get; set; }
        public string ByeAndSell_JahateMoameleh { get; set; }
        public string ByeAndSell_TypeKarbary { get; set; }
        public string ByeAndSell_Moshakhasat { get; set; }
        public string ByeAndSell_Address { get; set; }
        public string ByeAndSell_TypeEstefadeh { get; set; }
        public string ByeAndSell_Price { get; set; }
        public string ByeAndSell_CodePosty { get; set; }
        public string ByeAndSell_Family { get; set; }
        public string ByeAndSell_Mobile { get; set; }
        public bool? ByeAndSell_Delete { get; set; }

        [Column(TypeName = "image")]
        public byte[] ByeAndSell_Image { get; set; }
        public string ByeAndSell_Url { get; set; }
        public int ByeAndSell_UserId { get; set; }
        public DateTime? ByeAndSell_DatePublish { get; set; }
    }

    // ارتباط جداول خرید و فروش با یکدیگر
    public class ByeAndSell_PrimeryCategory
    {
        [Key]
        public int ByeAndSell_PrimeryCategoryID { get; set; }
        public string ByeAndSell_PrimeryCategoryName { get; set; }
    }

    public class ByeAndSell_SubPrimeryCategory
    {
        [Key]
        public int ByeAndSell_SubPrimeryCategoryID { get; set; }
        public string ByeAndSell_SubPrimeryCategoryName { get; set; }
    }

    //***********************************************************************************

    // لیست کلیه آیتم های مربوط به خرید و فروش
    public class ByeAndSell_LST_MoredeMoameleh
    {
        [Key]
        public int ByeAndSell_LST_MoredeMoameleh_Id { get; set; }
        public string ByeAndSell_LST_MoredeMoameleh_Name { get; set; }
    }
    public class ByeAndSell_LST_Karbary
    {
        [Key]
        public int ByeAndSell_LST_TypeKarbaryId { get; set; }
        public string ByeAndSell_LST_TypeKarbaryName { get; set; }
    }

    public class ByeAndSell_LST_JahatMoamele
    {
        [Key]
        public int ByeAndSell_LST_JahatMoameleId { get; set; }
        public string ByeAndSell_LST_JahatMoameleName { get; set; }
    }
}
