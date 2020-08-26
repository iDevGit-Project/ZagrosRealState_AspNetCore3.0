using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZagrosRealState.Entities.Entities
{
    public class House
    {
        [Key]
        public int House_Id { get; set; }
        public string HouseCode_Id { get; set; }
        public string House_Metrazh { get; set; }
        public string House_NumTabagheh { get; set; }
        public string House_TypeDarb { get; set; }
        public string House_StatusEjareh { get; set; }
        public string House_NumKahb { get; set; }
        public string House_Tabagheh { get; set; }
        public string House_Parking { get; set; }
        public string House_VoroodyType { get; set; }
        public DateTime? House_DatePublish { get; set; }

        //public string ShamsiDate { get; set; }
        //public string ShamsiTime { get; set; }
        public string House_AB { get; set; }
        public string House_Gaz { get; set; }
        public string House_Bargh { get; set; }
        public string House_OtherEmkanat { get; set; }
        public string House_PriceRahn { get; set; }
        public string House_PriceEjareh { get; set; }
        public string House_Address { get; set; }
        public string House_StatusManzel { get; set; }
        public string House_Family { get; set; }
        public string House_Mobile { get; set; }
        public string House_Comment { get; set; }
        public bool? House_Delete { get; set; }

        [Column(TypeName = "image")]
        public byte[] House_Image { get; set; }
        public string House_Url { get; set; }
        public int House_UserId { get; set; }

    }

    // ارتباط جداول منزل با یکدیگر
    public class House_PrimeryCategory
    {
        [Key]
        public int House_PrimeryCategoryID { get; set; }
        public string House_PrimeryCategoryName { get; set; }
    }

    public class House_SubPrimeryCategory
    {
        [Key]
        public int House_SubPrimeryCategoryID { get; set; }
        public string House_SubPrimeryCategoryName { get; set; }
    }

    //***********************************************************************************

    // لیست کلیه آیتم های مربوط به منزل
    public class House_LST_Darb
    {
        [Key]
        public int House_LST_DarbId { get; set; }
        public string House_LST_DarbName { get; set; }

    }
    public class House_LST_Ejareh
    {
        [Key]
        public int House_LST_EjarehId { get; set; }
        public string House_LST_EjarehName { get; set; }

    }
    public class House_LST_NumKhab
    {
        [Key]
        public int House_LST_NumKhabId { get; set; }
        public string House_LST_NumKhabName { get; set; }

    }
    public class House_LST_Tabagheh
    {
        [Key]
        public int House_LST_TabaghehId { get; set; }
        public string House_LST_TabaghehName { get; set; }

    }
    public class House_LST_Parking
    {
        [Key]
        public int House_LST_ParkingId { get; set; }
        public string House_LST_ParkingName { get; set; }

    }
    public class House_LST_Voroody
    {
        [Key]
        public int House_LST_VoroodyId { get; set; }
        public string House_LST_VoroodyName { get; set; }

    }
    public class House_LST_Ab
    {
        [Key]
        public int House_LST_AbId { get; set; }
        public string House_LST_AbName { get; set; }

    }
    public class House_LST_Gaz
    {
        [Key]
        public int House_LST_GazId { get; set; }
        public string House_LST_GazName { get; set; }

    }
    public class House_LST_Bargh
    {
        [Key]
        public int House_LST_BarghId { get; set; }
        public string House_LST_BarghName { get; set; }

    }
    public class House_LST_Status
    {
        [Key]
        public int House_LST_StatusId { get; set; }
        public string House_LST_StatusName { get; set; }

    }
}
