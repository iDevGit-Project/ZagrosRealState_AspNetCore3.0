using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ZagrosRealState.Entities.Entities
{
    public class Apartment
    {
        [Key]
        public int Apartment_Id { get; set; }
        public string Apartment_CodeId { get; set; }
        public string Apartment_Metrazh { get; set; }
        public string Apartment_Tabaghe { get; set; }
        public string Apartment_Ejareh { get; set; }
        public string Apartment_Takhliyeh { get; set; }
        public string Apartment_NumKhab { get; set; }
        public string Apartment_NumBolook { get; set; }
        public string Apartment_NumVahed { get; set; }
        public DateTime? Apartment_DateTakhliyeh { get; set; }
        public string Apartment_Enshaaab_Aab { get; set; }
        public string Apartment_Enshaaab_Gaaz { get; set; }
        public string Apartment_Enshaaab_Baargh { get; set; }
        public string Apartment_Enshaaab_Telephone { get; set; }
        public string Apartment_StatusEnshaaab { get; set; }
        public string Apartment_Parking { get; set; }
        public string Apartment_Anbari { get; set; }
        public string Apartment_Asansor { get; set; }
        public string Apartment_Shoofazh { get; set; }
        public string Apartment_HagheCharge { get; set; }
        public string Apartment_HagheCharge_Price { get; set; }
        public string Apartment_PriceRahn { get; set; }
        public string Apartment_PriceEjareh { get; set; }
        public string Apartment_Address { get; set; }
        public string Apartment_StatusRahnAparteman { get; set; }
        public string Apartment_MojerName { get; set; }
        public string Apartment_MojerTell { get; set; }
        public string Apartment_Description { get; set; }
        public bool? Apartment_Delete { get; set; }
        public byte[] Apartment_Image { get; set; }
        public DateTime? Apartment_PublishDate { get; set; }
        public string Apartment_Url { get; set; }
        public int Apartment_UserId { get; set; }

        //***********************************************************************************
    }

    // ارتباط جداول آپارتمان با یکدیگر
    public class Aparteman_PrimeryCategory
    {
        [Key]
        public int Aparteman_PrimeryCategoryID { get; set; }
        public string Aparteman_PrimeryCategoryName { get; set; }
        public List<Aparteman_SubPrimeryCategory> Aparteman_SubPrimeryCategories { get; set; }
    }

    public class Aparteman_SubPrimeryCategory
    {
        [Key]
        public int Aparteman_SubPrimeryCategoryID { get; set; }
        public string Aparteman_SubPrimeryCategoryName { get; set; }
        public Aparteman_PrimeryCategory Aparteman_PrimeryCategory { get; set; }
    }

    //***********************************************************************************

    // لیست کلیه آیتم های مربوط به آپارتمان
    public class Apartment_LST_Ejareh
    {
        [Key]
        public int LST_EjarehAPId { get; set; }
        public string LST_EjarehAPName { get; set; }
    }

    public class Apartment_LST_Takhliyeh
    {
        [Key]
        public int LST_TakhliyehAPId { get; set; }
        public string LST_TakhliyehAPName { get; set; }
    }

    public class Apartment_LST_NumKhab
    {
        [Key]
        public int LST_NumKhabAPId { get; set; }
        public string LST_NumKhabAP { get; set; }
    }

    public class Apartment_LST_NumAB
    {
        [Key]
        public int LST_NumABAPId { get; set; }
        public string LST_NumABAP { get; set; }
    }

    public class Apartment_LST_NumBargh
    {
        [Key]
        public int LST_NumBarghAPId { get; set; }
        public string LST_NumBarghAP { get; set; }
    }

    public class Apartment_LST_NumGAZ
    {
        [Key]
        public int LST_NumGAZAPId { get; set; }
        public string LST_NumGAZAP { get; set; }
    }

    public class Apartment_LST_NumTELL
    {
        [Key]
        public int LST_NumTELLAPId { get; set; }
        public string LST_NumTELLAP { get; set; }
    }

    public class Apartment_LST_EmkanatSatus
    {
        [Key]
        public int LST_EmkanatSatusAPId { get; set; }
        public string LST_EmkanatSatusAPName { get; set; }

        public virtual Apartment Entity_Aparteman { get; set; }

    }

    public class Apartment_LST_Parking
    {
        [Key]
        public int LST_ParkingAPId { get; set; }
        public string LST_ParkingAPName { get; set; }
    }
    public class Apartment_LST_Anbari
    {
        [Key]
        public int LST_AnbariAPId { get; set; }
        public string LST_AnbariAPName { get; set; }
    }
    public class Apartment_LST_Asansor
    {
        [Key]
        public int LST_AsansorAPId { get; set; }
        public string LST_AsansorAPName { get; set; }
    }
    public class Apartment_LST_Shoofazh
    {
        [Key]
        public int LST_ShoofazhAPId { get; set; }
        public string LST_ShoofazhAPName { get; set; }
    }
    public class Apartment_LST_HagheCharge
    {
        [Key]
        public int LST_HagheChargeAPId { get; set; }
        public string LST_HagheChargeAPName { get; set; }
    }
    public class Apartment_LST_ApartemanStatus
    {
        [Key]
        public int LST_ApartemanStatusAPId { get; set; }
        public string LST_ApartemanStatusAPName { get; set; }
    }
}
