using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZagrosRealState.Entities.Entities
{
    public class Shop
    {
        [Key]
        public int Shop_Id { get; set; }
        public string ShopCode_Id { get; set; }
        public string Shop_Mougheyat { get; set; }
        public string Shop_Metrazh { get; set; }
        public string Shop_TypeDarb { get; set; }
        public string Shop_StatusEjareh { get; set; }
        public string Shop_Balakon { get; set; }
        public string Shop_BalakonMetrazh { get; set; }
        public string Shop_BeARZ { get; set; }
        public string Shop_InsidePooshesh { get; set; }
        public string Shop_AB { get; set; }
        public string Shop_Gaz { get; set; }
        public string Shop_Bargh { get; set; }
        public string Shop_Tell { get; set; }
        public string Shop_HagheCharge { get; set; }
        public string Shop_PriceCharge { get; set; }
        public string Shop_PriceRahn { get; set; }
        public string Shop_PriceEjareh { get; set; }
        public string Shop_Address { get; set; }
        public string Shop_PayaneKar { get; set; }
        public string Shop_TypeSenf { get; set; }
        public string Shop_Family { get; set; }
        public string Shop_Mobile { get; set; }
        public string Shop_Comment { get; set; }
        public string Shop_Anbary { get; set; }
        public string Shop_Asansor { get; set; }
        public string Shop_Shoofazh { get; set; }
        public string Shop_Status_Rah_OR_Ejareh { get; set; }
        public DateTime? Shop_DatePublish { get; set; }
        public bool? Shop_Delete { get; set; }

        //public string ShamsiDate { get; set; }
        //public string ShamsiTime { get; set; }

        [Column(TypeName = "image")]
        public byte[] Shop_Image { get; set; }
        public string Shop_Url { get; set; }
        public int Shop_UserId { get; set; }

        //***********************************************************************************
    }
    // ارتباط جداول مغازه با یکدیگر
    public class Shop_PrimeryCategory
    {
        [Key]
        public int Shop_PrimeryCategoryID { get; set; }
        public string Shop_PrimeryCategoryName { get; set; }
    }

    public class Shop_SubPrimeryCategory
    {
        [Key]
        public int Shop_SubPrimeryCategoryID { get; set; }
        public string Shop_SubPrimeryCategoryName { get; set; }
    }

    //***********************************************************************************

    // لیست کلیه آیتم های مربوط به مغازه
    public class Shop_LST_Location
    {
        [Key]
        public int Shop_LST_LocationId { get; set; }
        public string Shop_LST_LocationName { get; set; }

    }
    public class Shop_LST_Darb
    {
        [Key]
        public int Shop_LST_DarbId { get; set; }
        public string Shop_LST_DarbName { get; set; }

    }
    public class Shop_LST_Ejareh
    {
        [Key]
        public int Shop_LST_EjarehId { get; set; }
        public string Shop_LST_EjarehName { get; set; }

    }
    public class Shop_LST_Balakon
    {
        [Key]
        public int Shop_LST_BalakonId { get; set; }
        public string Shop_LST_BalakonName { get; set; }

    }
    public class Shop_LST_InsideDesign
    {
        [Key]
        public int Shop_LST_InsideDesignId { get; set; }
        public string Shop_LST_InsideDesignName { get; set; }

    }
    public class Shop_LST_AB
    {
        [Key]
        public int Shop_LST_ABId { get; set; }
        public string Shop_LST_ABName { get; set; }

    }
    public class Shop_LST_Gaz
    {
        [Key]
        public int Shop_LST_GazId { get; set; }
        public string Shop_LST_GazName { get; set; }

    }
    public class Shop_LST_Bargh
    {
        [Key]
        public int Shop_LST_BarghId { get; set; }
        public string Shop_LST_BarghName { get; set; }

    }
    public class Shop_LST_Tell
    {
        [Key]
        public int Shop_LST_TellId { get; set; }
        public string Shop_LST_TellName { get; set; }

    }
    public class Shop_LST_HagheCharge
    {
        [Key]
        public int Shop_LST_HagheChargeId { get; set; }
        public string Shop_LST_HagheChargeName { get; set; }

    }
    public class Shop_LST_PayaneKar
    {
        [Key]
        public int Shop_LST_PayaneKarId { get; set; }
        public string Shop_LST_PayaneKarName { get; set; }

    }
    public class Shop_LST_Senf
    {
        [Key]
        public int Shop_LST_SenfId { get; set; }
        public string Shop_LST_SenfName { get; set; }

    }
    public class Shop_LST_Anbary
    {
        [Key]
        public int Shop_LST_AnbaryId { get; set; }
        public string Shop_LST_AnbaryName { get; set; }

    }
    public class Shop_LST_Asansor
    {
        [Key]
        public int Shop_LST_AsansorId { get; set; }
        public string Shop_LST_AsansorName { get; set; }

    }
    public class Shop_LST_Shoofazh
    {
        [Key]
        public int Shop_LST_ShoofazhId { get; set; }
        public string Shop_LST_ShoofazhName { get; set; }

    }
    public class Shop_LST_Rahn_OR_Ejareh
    {
        [Key]
        public int Shop_LST_Rahn_OR_EjarehId { get; set; }
        public string Shop_LST_Rahn_OR_EjarehName { get; set; }

    }
}
