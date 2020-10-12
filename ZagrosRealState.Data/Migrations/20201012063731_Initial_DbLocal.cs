using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ZagrosRealState.Data.Migrations
{
    public partial class Initial_DbLocal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apartment_LST_Anbaris",
                columns: table => new
                {
                    LST_AnbariAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_AnbariAPName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_Anbaris", x => x.LST_AnbariAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_ApartemanStatuses",
                columns: table => new
                {
                    LST_ApartemanStatusAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_ApartemanStatusAPName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_ApartemanStatuses", x => x.LST_ApartemanStatusAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_Asansors",
                columns: table => new
                {
                    LST_AsansorAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_AsansorAPName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_Asansors", x => x.LST_AsansorAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_Ejarehs",
                columns: table => new
                {
                    LST_EjarehAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_EjarehAPName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_Ejarehs", x => x.LST_EjarehAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_HagheCharges",
                columns: table => new
                {
                    LST_HagheChargeAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_HagheChargeAPName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_HagheCharges", x => x.LST_HagheChargeAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_NumABs",
                columns: table => new
                {
                    LST_NumABAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_NumABAP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_NumABs", x => x.LST_NumABAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_NumBarghs",
                columns: table => new
                {
                    LST_NumBarghAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_NumBarghAP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_NumBarghs", x => x.LST_NumBarghAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_NumGAZs",
                columns: table => new
                {
                    LST_NumGAZAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_NumGAZAP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_NumGAZs", x => x.LST_NumGAZAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_NumKhabs",
                columns: table => new
                {
                    LST_NumKhabAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_NumKhabAP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_NumKhabs", x => x.LST_NumKhabAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_NumTELLs",
                columns: table => new
                {
                    LST_NumTELLAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_NumTELLAP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_NumTELLs", x => x.LST_NumTELLAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_Parkings",
                columns: table => new
                {
                    LST_ParkingAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_ParkingAPName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_Parkings", x => x.LST_ParkingAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_Shoofazhs",
                columns: table => new
                {
                    LST_ShoofazhAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_ShoofazhAPName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_Shoofazhs", x => x.LST_ShoofazhAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_Takhliyehs",
                columns: table => new
                {
                    LST_TakhliyehAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_TakhliyehAPName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_Takhliyehs", x => x.LST_TakhliyehAPId);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    Apartment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apartment_CodeId = table.Column<string>(nullable: true),
                    Apartment_Metrazh = table.Column<string>(nullable: true),
                    Apartment_Tabaghe = table.Column<string>(nullable: true),
                    Apartment_Ejareh = table.Column<string>(nullable: true),
                    Apartment_Takhliyeh = table.Column<string>(nullable: true),
                    Apartment_NumKhab = table.Column<string>(nullable: true),
                    Apartment_NumBolook = table.Column<string>(nullable: true),
                    Apartment_NumVahed = table.Column<string>(nullable: true),
                    Apartment_DateTakhliyeh = table.Column<DateTime>(nullable: true),
                    Apartment_Enshaaab_Aab = table.Column<string>(nullable: true),
                    Apartment_Enshaaab_Gaaz = table.Column<string>(nullable: true),
                    Apartment_Enshaaab_Baargh = table.Column<string>(nullable: true),
                    Apartment_Enshaaab_Telephone = table.Column<string>(nullable: true),
                    Apartment_StatusEnshaaab = table.Column<string>(nullable: true),
                    Apartment_Parking = table.Column<string>(nullable: true),
                    Apartment_Anbari = table.Column<string>(nullable: true),
                    Apartment_Asansor = table.Column<string>(nullable: true),
                    Apartment_Shoofazh = table.Column<string>(nullable: true),
                    Apartment_HagheCharge = table.Column<string>(nullable: true),
                    Apartment_HagheCharge_Price = table.Column<string>(nullable: true),
                    Apartment_PriceRahn = table.Column<string>(nullable: true),
                    Apartment_PriceEjareh = table.Column<string>(nullable: true),
                    Apartment_Address = table.Column<string>(nullable: true),
                    Apartment_StatusRahnAparteman = table.Column<string>(nullable: true),
                    Apartment_MojerName = table.Column<string>(nullable: true),
                    Apartment_MojerTell = table.Column<string>(nullable: true),
                    Apartment_Description = table.Column<string>(nullable: true),
                    Apartment_Delete = table.Column<bool>(nullable: true),
                    Apartment_Image = table.Column<byte[]>(type: "image", nullable: true),
                    Apartment_PublishDate = table.Column<DateTime>(nullable: true),
                    Apartment_Url = table.Column<string>(nullable: true),
                    Apartment_UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.Apartment_Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ByeAndSell_LST_JahatMoameles",
                columns: table => new
                {
                    ByeAndSell_LST_JahatMoameleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ByeAndSell_LST_JahatMoameleName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ByeAndSell_LST_JahatMoameles", x => x.ByeAndSell_LST_JahatMoameleId);
                });

            migrationBuilder.CreateTable(
                name: "ByeAndSell_LST_Karbaries",
                columns: table => new
                {
                    ByeAndSell_LST_TypeKarbaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ByeAndSell_LST_TypeKarbaryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ByeAndSell_LST_Karbaries", x => x.ByeAndSell_LST_TypeKarbaryId);
                });

            migrationBuilder.CreateTable(
                name: "ByeAndSell_LST_MoredeMoamelehs",
                columns: table => new
                {
                    ByeAndSell_LST_MoredeMoameleh_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ByeAndSell_LST_MoredeMoameleh_Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ByeAndSell_LST_MoredeMoamelehs", x => x.ByeAndSell_LST_MoredeMoameleh_Id);
                });

            migrationBuilder.CreateTable(
                name: "ByeAndSells",
                columns: table => new
                {
                    ByeAndSell_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ByeAndSellCode_Id = table.Column<string>(nullable: true),
                    ByeAndSell_TypeMoredeMoameleh = table.Column<string>(nullable: true),
                    ByeAndSell_JahateMoameleh = table.Column<string>(nullable: true),
                    ByeAndSell_TypeKarbary = table.Column<string>(nullable: true),
                    ByeAndSell_Moshakhasat = table.Column<string>(nullable: true),
                    ByeAndSell_Address = table.Column<string>(nullable: true),
                    ByeAndSell_TypeEstefadeh = table.Column<string>(nullable: true),
                    ByeAndSell_Price = table.Column<string>(nullable: true),
                    ByeAndSell_CodePosty = table.Column<string>(nullable: true),
                    ByeAndSell_Family = table.Column<string>(nullable: true),
                    ByeAndSell_Mobile = table.Column<string>(nullable: true),
                    ByeAndSell_Delete = table.Column<bool>(nullable: true),
                    ByeAndSell_Image = table.Column<byte[]>(type: "image", nullable: true),
                    ByeAndSell_Url = table.Column<string>(nullable: true),
                    ByeAndSell_UserId = table.Column<int>(nullable: false),
                    ByeAndSell_DatePublish = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ByeAndSells", x => x.ByeAndSell_Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers_LST_JOBs",
                columns: table => new
                {
                    Customers_LST_JOBId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customers_LST_JOBName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers_LST_JOBs", x => x.Customers_LST_JOBId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Abs",
                columns: table => new
                {
                    House_LST_AbId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_AbName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Abs", x => x.House_LST_AbId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Barghs",
                columns: table => new
                {
                    House_LST_BarghId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_BarghName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Barghs", x => x.House_LST_BarghId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Darbs",
                columns: table => new
                {
                    House_LST_DarbId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_DarbName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Darbs", x => x.House_LST_DarbId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Ejarehs",
                columns: table => new
                {
                    House_LST_EjarehId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_EjarehName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Ejarehs", x => x.House_LST_EjarehId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Gazs",
                columns: table => new
                {
                    House_LST_GazId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_GazName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Gazs", x => x.House_LST_GazId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_NumKhabs",
                columns: table => new
                {
                    House_LST_NumKhabId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_NumKhabName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_NumKhabs", x => x.House_LST_NumKhabId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Parkings",
                columns: table => new
                {
                    House_LST_ParkingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_ParkingName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Parkings", x => x.House_LST_ParkingId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Statuses",
                columns: table => new
                {
                    House_LST_StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_StatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Statuses", x => x.House_LST_StatusId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Tabaghehs",
                columns: table => new
                {
                    House_LST_TabaghehId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_TabaghehName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Tabaghehs", x => x.House_LST_TabaghehId);
                });

            migrationBuilder.CreateTable(
                name: "House_LST_Voroodies",
                columns: table => new
                {
                    House_LST_VoroodyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    House_LST_VoroodyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_House_LST_Voroodies", x => x.House_LST_VoroodyId);
                });

            migrationBuilder.CreateTable(
                name: "Houses",
                columns: table => new
                {
                    House_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HouseCode_Id = table.Column<string>(nullable: true),
                    House_Metrazh = table.Column<string>(nullable: true),
                    House_NumTabagheh = table.Column<string>(nullable: true),
                    House_TypeDarb = table.Column<string>(nullable: true),
                    House_StatusEjareh = table.Column<string>(nullable: true),
                    House_NumKahb = table.Column<string>(nullable: true),
                    House_Tabagheh = table.Column<string>(nullable: true),
                    House_Parking = table.Column<string>(nullable: true),
                    House_VoroodyType = table.Column<string>(nullable: true),
                    House_DatePublish = table.Column<DateTime>(nullable: true),
                    House_AB = table.Column<string>(nullable: true),
                    House_Gaz = table.Column<string>(nullable: true),
                    House_Bargh = table.Column<string>(nullable: true),
                    House_OtherEmkanat = table.Column<string>(nullable: true),
                    House_PriceRahn = table.Column<string>(nullable: true),
                    House_PriceEjareh = table.Column<string>(nullable: true),
                    House_Address = table.Column<string>(nullable: true),
                    House_StatusManzel = table.Column<string>(nullable: true),
                    House_Family = table.Column<string>(nullable: true),
                    House_Mobile = table.Column<string>(nullable: true),
                    House_Comment = table.Column<string>(nullable: true),
                    House_Delete = table.Column<bool>(nullable: true),
                    House_Image = table.Column<byte[]>(type: "image", nullable: true),
                    House_Url = table.Column<string>(nullable: true),
                    House_UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Houses", x => x.House_Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceID = table.Column<int>(nullable: false),
                    ProvinceName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceID);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_ABs",
                columns: table => new
                {
                    Shop_LST_ABId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_ABName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_ABs", x => x.Shop_LST_ABId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Anbaries",
                columns: table => new
                {
                    Shop_LST_AnbaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_AnbaryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Anbaries", x => x.Shop_LST_AnbaryId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Asansors",
                columns: table => new
                {
                    Shop_LST_AsansorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_AsansorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Asansors", x => x.Shop_LST_AsansorId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Balakons",
                columns: table => new
                {
                    Shop_LST_BalakonId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_BalakonName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Balakons", x => x.Shop_LST_BalakonId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Barghs",
                columns: table => new
                {
                    Shop_LST_BarghId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_BarghName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Barghs", x => x.Shop_LST_BarghId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Darbs",
                columns: table => new
                {
                    Shop_LST_DarbId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_DarbName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Darbs", x => x.Shop_LST_DarbId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Ejarehs",
                columns: table => new
                {
                    Shop_LST_EjarehId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_EjarehName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Ejarehs", x => x.Shop_LST_EjarehId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Gazs",
                columns: table => new
                {
                    Shop_LST_GazId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_GazName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Gazs", x => x.Shop_LST_GazId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_HagheCharges",
                columns: table => new
                {
                    Shop_LST_HagheChargeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_HagheChargeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_HagheCharges", x => x.Shop_LST_HagheChargeId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_InsideDesigns",
                columns: table => new
                {
                    Shop_LST_InsideDesignId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_InsideDesignName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_InsideDesigns", x => x.Shop_LST_InsideDesignId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Locations",
                columns: table => new
                {
                    Shop_LST_LocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_LocationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Locations", x => x.Shop_LST_LocationId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_PayaneKars",
                columns: table => new
                {
                    Shop_LST_PayaneKarId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_PayaneKarName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_PayaneKars", x => x.Shop_LST_PayaneKarId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Rahn_OR_Ejarehs",
                columns: table => new
                {
                    Shop_LST_Rahn_OR_EjarehId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_Rahn_OR_EjarehName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Rahn_OR_Ejarehs", x => x.Shop_LST_Rahn_OR_EjarehId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Senfs",
                columns: table => new
                {
                    Shop_LST_SenfId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_SenfName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Senfs", x => x.Shop_LST_SenfId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Shoofazhs",
                columns: table => new
                {
                    Shop_LST_ShoofazhId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_ShoofazhName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Shoofazhs", x => x.Shop_LST_ShoofazhId);
                });

            migrationBuilder.CreateTable(
                name: "Shop_LST_Tells",
                columns: table => new
                {
                    Shop_LST_TellId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Shop_LST_TellName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_LST_Tells", x => x.Shop_LST_TellId);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Shop_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopCode_Id = table.Column<string>(nullable: true),
                    Shop_Mougheyat = table.Column<string>(nullable: true),
                    Shop_Metrazh = table.Column<string>(nullable: true),
                    Shop_TypeDarb = table.Column<string>(nullable: true),
                    Shop_StatusEjareh = table.Column<string>(nullable: true),
                    Shop_Balakon = table.Column<string>(nullable: true),
                    Shop_BalakonMetrazh = table.Column<string>(nullable: true),
                    Shop_BeARZ = table.Column<string>(nullable: true),
                    Shop_InsidePooshesh = table.Column<string>(nullable: true),
                    Shop_AB = table.Column<string>(nullable: true),
                    Shop_Gaz = table.Column<string>(nullable: true),
                    Shop_Bargh = table.Column<string>(nullable: true),
                    Shop_Tell = table.Column<string>(nullable: true),
                    Shop_HagheCharge = table.Column<string>(nullable: true),
                    Shop_PriceCharge = table.Column<string>(nullable: true),
                    Shop_PriceRahn = table.Column<string>(nullable: true),
                    Shop_PriceEjareh = table.Column<string>(nullable: true),
                    Shop_Address = table.Column<string>(nullable: true),
                    Shop_PayaneKar = table.Column<string>(nullable: true),
                    Shop_TypeSenf = table.Column<string>(nullable: true),
                    Shop_Family = table.Column<string>(nullable: true),
                    Shop_Mobile = table.Column<string>(nullable: true),
                    Shop_Comment = table.Column<string>(nullable: true),
                    Shop_Anbary = table.Column<string>(nullable: true),
                    Shop_Asansor = table.Column<string>(nullable: true),
                    Shop_Shoofazh = table.Column<string>(nullable: true),
                    Shop_Status_Rah_OR_Ejareh = table.Column<string>(nullable: true),
                    Shop_DatePublish = table.Column<DateTime>(nullable: true),
                    Shop_Delete = table.Column<bool>(nullable: true),
                    Shop_Image = table.Column<byte[]>(type: "image", nullable: true),
                    Shop_Url = table.Column<string>(nullable: true),
                    Shop_UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Shop_Id);
                });

            migrationBuilder.CreateTable(
                name: "Willing_LST_Jahats",
                columns: table => new
                {
                    Willing_LST_JahatId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Willing_LST_JahatName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Willing_LST_Jahats", x => x.Willing_LST_JahatId);
                });

            migrationBuilder.CreateTable(
                name: "Willing_LSTs",
                columns: table => new
                {
                    Willing_LSTId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Willing_LSTName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Willing_LSTs", x => x.Willing_LSTId);
                });

            migrationBuilder.CreateTable(
                name: "Willings",
                columns: table => new
                {
                    Willing_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Willing_Name = table.Column<string>(nullable: true),
                    Willing_Family = table.Column<string>(nullable: true),
                    Willing_Mobile = table.Column<string>(nullable: true),
                    Willing_Price = table.Column<string>(nullable: true),
                    Willing_KhahanList = table.Column<string>(nullable: true),
                    Willing_JahatList = table.Column<string>(nullable: true),
                    Willing_Moshakhasat = table.Column<string>(nullable: true),
                    Willing_Address = table.Column<string>(nullable: true),
                    Willing_Image = table.Column<byte[]>(type: "image", nullable: true),
                    Willing_Delete = table.Column<bool>(nullable: true),
                    Willing_Url = table.Column<string>(nullable: true),
                    Willing_DatePublish = table.Column<DateTime>(nullable: true),
                    Willing_UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Willings", x => x.Willing_Id);
                });

            migrationBuilder.CreateTable(
                name: "Apartment_LST_EmkanatSatus",
                columns: table => new
                {
                    LST_EmkanatSatusAPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LST_EmkanatSatusAPName = table.Column<string>(nullable: true),
                    Entity_ApartemanApartment_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartment_LST_EmkanatSatus", x => x.LST_EmkanatSatusAPId);
                    table.ForeignKey(
                        name: "FK_Apartment_LST_EmkanatSatus_Apartments_Entity_ApartemanApartment_Id",
                        column: x => x.Entity_ApartemanApartment_Id,
                        principalTable: "Apartments",
                        principalColumn: "Apartment_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(nullable: false),
                    CityName = table.Column<string>(nullable: true),
                    ProvinceID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceID",
                        column: x => x.ProvinceID,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Customers_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customers_Name = table.Column<string>(nullable: true),
                    Customers_Family = table.Column<string>(nullable: true),
                    Customers_CodeMelli = table.Column<string>(nullable: true),
                    Customers_Tell = table.Column<string>(nullable: true),
                    Customers_Mobile = table.Column<string>(nullable: true),
                    Customers_Job = table.Column<string>(nullable: true),
                    Customers_Address = table.Column<string>(nullable: true),
                    Customers_Image = table.Column<byte[]>(type: "image", nullable: true),
                    Customers_Url = table.Column<string>(nullable: true),
                    Customers_DatePublish = table.Column<DateTime>(nullable: true),
                    Customers_Delete = table.Column<bool>(nullable: true),
                    Customers_UserId = table.Column<int>(nullable: false),
                    CitiesCityID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Customers_Id);
                    table.ForeignKey(
                        name: "FK_Customers_Cities_CitiesCityID",
                        column: x => x.CitiesCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_Anbaris",
                columns: new[] { "LST_AnbariAPId", "LST_AnbariAPName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_ApartemanStatuses",
                columns: new[] { "LST_ApartemanStatusAPId", "LST_ApartemanStatusAPName" },
                values: new object[,]
                {
                    { 1, "رهن شده" },
                    { 2, "تخلیه شده" },
                    { 3, "اجاره شده" },
                    { 4, "به فروش رسیده" },
                    { 5, "تحت تملک می باشد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_Asansors",
                columns: new[] { "LST_AsansorAPId", "LST_AsansorAPName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_Ejarehs",
                columns: new[] { "LST_EjarehAPId", "LST_EjarehAPName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_EmkanatSatus",
                columns: new[] { "LST_EmkanatSatusAPId", "Entity_ApartemanApartment_Id", "LST_EmkanatSatusAPName" },
                values: new object[,]
                {
                    { 3, null, "فاقد هر گونه امکانات" },
                    { 1, null, "کلیه امکانات مشترک" },
                    { 2, null, "کلیه امکانات مستقل" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_HagheCharges",
                columns: new[] { "LST_HagheChargeAPId", "LST_HagheChargeAPName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_NumABs",
                columns: new[] { "LST_NumABAPId", "LST_NumABAP" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_NumBarghs",
                columns: new[] { "LST_NumBarghAPId", "LST_NumBarghAP" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_NumGAZs",
                columns: new[] { "LST_NumGAZAPId", "LST_NumGAZAP" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_NumKhabs",
                columns: new[] { "LST_NumKhabAPId", "LST_NumKhabAP" },
                values: new object[,]
                {
                    { 5, "5" },
                    { 4, "4" },
                    { 1, "1" },
                    { 2, "2" },
                    { 3, "3" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_NumTELLs",
                columns: new[] { "LST_NumTELLAPId", "LST_NumTELLAP" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_Parkings",
                columns: new[] { "LST_ParkingAPId", "LST_ParkingAPName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_Shoofazhs",
                columns: new[] { "LST_ShoofazhAPId", "LST_ShoofazhAPName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Apartment_LST_Takhliyehs",
                columns: new[] { "LST_TakhliyehAPId", "LST_TakhliyehAPName" },
                values: new object[,]
                {
                    { 2, "تخلیه شده" },
                    { 3, "در حال تخلیه" },
                    { 1, "تخلیه فوری" }
                });

            migrationBuilder.InsertData(
                table: "ByeAndSell_LST_JahatMoameles",
                columns: new[] { "ByeAndSell_LST_JahatMoameleId", "ByeAndSell_LST_JahatMoameleName" },
                values: new object[,]
                {
                    { 1, "خرید" },
                    { 2, "فروش" },
                    { 3, "معاوضه" },
                    { 4, "سایر" }
                });

            migrationBuilder.InsertData(
                table: "ByeAndSell_LST_Karbaries",
                columns: new[] { "ByeAndSell_LST_TypeKarbaryId", "ByeAndSell_LST_TypeKarbaryName" },
                values: new object[,]
                {
                    { 9, "مرغداری" },
                    { 13, "باغ و باغچه" },
                    { 12, "پرورش ماهی" },
                    { 11, "گلخانه" },
                    { 10, "دامپروری" },
                    { 8, "دامداری" },
                    { 5, "ورزشی" },
                    { 6, "بهداشتی" },
                    { 4, "صنعتی" },
                    { 3, "آموزشی" },
                    { 2, "تجاری" },
                    { 1, "مسکونی" },
                    { 7, "خدماتی" }
                });

            migrationBuilder.InsertData(
                table: "ByeAndSell_LST_MoredeMoamelehs",
                columns: new[] { "ByeAndSell_LST_MoredeMoameleh_Id", "ByeAndSell_LST_MoredeMoameleh_Name" },
                values: new object[,]
                {
                    { 11, "دستگاه سوله" },
                    { 10, "قطعه پارکینگ" },
                    { 9, "قطعه انباری" },
                    { 8, "منزل ویلایی" },
                    { 7, "باغ شهر" },
                    { 4, "یک واحد تجاری دوبلکس" },
                    { 5, "یک واحد آپارتمان" },
                    { 3, "یک واحد تجاری" },
                    { 2, "یک باب مغازه تجاری" },
                    { 1, "یک دستگاه آپارتمان" },
                    { 6, "یک قطعه زمین" }
                });

            migrationBuilder.InsertData(
                table: "Customers_LST_JOBs",
                columns: new[] { "Customers_LST_JOBId", "Customers_LST_JOBName" },
                values: new object[,]
                {
                    { 7, "بازنشسته" },
                    { 6, "معلم" },
                    { 4, "دانشجو" },
                    { 5, "استاد دانشگاه" },
                    { 2, "آزاد" },
                    { 1, "دولتی" },
                    { 3, "بیکار" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Abs",
                columns: new[] { "House_LST_AbId", "House_LST_AbName" },
                values: new object[,]
                {
                    { 1, "دارد. مستقل" },
                    { 2, "دارد. مشترک" },
                    { 3, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Barghs",
                columns: new[] { "House_LST_BarghId", "House_LST_BarghName" },
                values: new object[,]
                {
                    { 1, "دارد. مستقل" },
                    { 2, "دارد. مشترک" },
                    { 3, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Darbs",
                columns: new[] { "House_LST_DarbId", "House_LST_DarbName" },
                values: new object[,]
                {
                    { 6, "دونبش" },
                    { 5, "نبش" },
                    { 4, "ساختمان - مشترک" },
                    { 2, "حیاط - مشترک" },
                    { 1, "حیاط - مستقل" },
                    { 3, "ساختمان - مستقل" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Ejarehs",
                columns: new[] { "House_LST_EjarehId", "House_LST_EjarehName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Gazs",
                columns: new[] { "House_LST_GazId", "House_LST_GazName" },
                values: new object[,]
                {
                    { 1, "دارد. مستقل" },
                    { 2, "دارد. مشترک" },
                    { 3, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_NumKhabs",
                columns: new[] { "House_LST_NumKhabId", "House_LST_NumKhabName" },
                values: new object[,]
                {
                    { 5, "5" },
                    { 4, "4" },
                    { 1, "1" },
                    { 2, "2" },
                    { 3, "3" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Parkings",
                columns: new[] { "House_LST_ParkingId", "House_LST_ParkingName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Statuses",
                columns: new[] { "House_LST_StatusId", "House_LST_StatusName" },
                values: new object[,]
                {
                    { 1, "تخلیه شده" },
                    { 2, "در حال تخلیه" },
                    { 3, "خالی" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Tabaghehs",
                columns: new[] { "House_LST_TabaghehId", "House_LST_TabaghehName" },
                values: new object[,]
                {
                    { 5, "5" },
                    { 3, "3" },
                    { 4, "4" },
                    { 1, "1" },
                    { 2, "2" }
                });

            migrationBuilder.InsertData(
                table: "House_LST_Voroodies",
                columns: new[] { "House_LST_VoroodyId", "House_LST_VoroodyName" },
                values: new object[,]
                {
                    { 1, "مستقل" },
                    { 2, "مشترک" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_ABs",
                columns: new[] { "Shop_LST_ABId", "Shop_LST_ABName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Anbaries",
                columns: new[] { "Shop_LST_AnbaryId", "Shop_LST_AnbaryName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Asansors",
                columns: new[] { "Shop_LST_AsansorId", "Shop_LST_AsansorName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Balakons",
                columns: new[] { "Shop_LST_BalakonId", "Shop_LST_BalakonName" },
                values: new object[,]
                {
                    { 2, "ندارد" },
                    { 1, "دارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Barghs",
                columns: new[] { "Shop_LST_BarghId", "Shop_LST_BarghName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Darbs",
                columns: new[] { "Shop_LST_DarbId", "Shop_LST_DarbName" },
                values: new object[,]
                {
                    { 10, "سایر" },
                    { 9, "فلزی" },
                    { 7, "پرده" },
                    { 6, "پلاستیک فشرده" },
                    { 8, "درب  برقی هوشمند" },
                    { 4, "آلومینیوم" },
                    { 3, "آهنی" },
                    { 2, "کرکره ای" },
                    { 1, "شیشه ای" },
                    { 5, "چوبی" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Ejarehs",
                columns: new[] { "Shop_LST_EjarehId", "Shop_LST_EjarehName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Gazs",
                columns: new[] { "Shop_LST_GazId", "Shop_LST_GazName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_HagheCharges",
                columns: new[] { "Shop_LST_HagheChargeId", "Shop_LST_HagheChargeName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_InsideDesigns",
                columns: new[] { "Shop_LST_InsideDesignId", "Shop_LST_InsideDesignName" },
                values: new object[,]
                {
                    { 7, "کاغذ دیواری" },
                    { 6, "سیمانی" },
                    { 5, "گچی" },
                    { 4, "خشت و گل" },
                    { 2, "آجری" },
                    { 1, "سرامیک" },
                    { 3, "بتنی" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Locations",
                columns: new[] { "Shop_LST_LocationId", "Shop_LST_LocationName" },
                values: new object[,]
                {
                    { 11, "سر خیابان" },
                    { 9, "سر کوچه" },
                    { 8, "داخل کوچه" },
                    { 7, "بیرون گاراژ" },
                    { 6, "داخل گاراژ" },
                    { 10, "بر خیابان" },
                    { 4, "داخل مجتمع" },
                    { 3, "بیرون پاساژ" },
                    { 2, "داخل پاساژ" },
                    { 1, "تجاری" },
                    { 5, "بیرون مجتمع" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_PayaneKars",
                columns: new[] { "Shop_LST_PayaneKarId", "Shop_LST_PayaneKarName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Rahn_OR_Ejarehs",
                columns: new[] { "Shop_LST_Rahn_OR_EjarehId", "Shop_LST_Rahn_OR_EjarehName" },
                values: new object[,]
                {
                    { 1, "رهن کامل" },
                    { 2, "رهن موقت" },
                    { 3, "اجاره موقت" },
                    { 4, "رهن و اجاره" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Senfs",
                columns: new[] { "Shop_LST_SenfId", "Shop_LST_SenfName" },
                values: new object[,]
                {
                    { 7, "خدمات ماشین های اداری" },
                    { 9, "خدمات درب و پنجره" },
                    { 10, "سایر خدمات" },
                    { 8, "خدمات کافی نت، گیم نت" },
                    { 6, "خدمات لاستیک خودرو" },
                    { 2, "قطعات یدکی خودرو سنگین" },
                    { 4, "خدمات برق و باتری" },
                    { 3, "قطعات یدکی موتورسیکلت" },
                    { 1, "قطعات یدکی خودرو سبک" },
                    { 5, "خدمات روغن و مکانیکی" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Shoofazhs",
                columns: new[] { "Shop_LST_ShoofazhId", "Shop_LST_ShoofazhName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Shop_LST_Tells",
                columns: new[] { "Shop_LST_TellId", "Shop_LST_TellName" },
                values: new object[,]
                {
                    { 1, "دارد" },
                    { 2, "ندارد" }
                });

            migrationBuilder.InsertData(
                table: "Willing_LST_Jahats",
                columns: new[] { "Willing_LST_JahatId", "Willing_LST_JahatName" },
                values: new object[,]
                {
                    { 3, "خرید" },
                    { 2, "رهن و اجاره" },
                    { 1, "رهن" },
                    { 5, "معاوضه" },
                    { 4, "فروش" }
                });

            migrationBuilder.InsertData(
                table: "Willing_LSTs",
                columns: new[] { "Willing_LSTId", "Willing_LSTName" },
                values: new object[,]
                {
                    { 3, "یک باب منزل ویلایی" },
                    { 2, "یک باب مغازه" },
                    { 4, "یک قطعه زمین" },
                    { 1, "یک واحد آپارتمان" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartment_LST_EmkanatSatus_Entity_ApartemanApartment_Id",
                table: "Apartment_LST_EmkanatSatus",
                column: "Entity_ApartemanApartment_Id");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceID",
                table: "Cities",
                column: "ProvinceID");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_CitiesCityID",
                table: "Customers",
                column: "CitiesCityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apartment_LST_Anbaris");

            migrationBuilder.DropTable(
                name: "Apartment_LST_ApartemanStatuses");

            migrationBuilder.DropTable(
                name: "Apartment_LST_Asansors");

            migrationBuilder.DropTable(
                name: "Apartment_LST_Ejarehs");

            migrationBuilder.DropTable(
                name: "Apartment_LST_EmkanatSatus");

            migrationBuilder.DropTable(
                name: "Apartment_LST_HagheCharges");

            migrationBuilder.DropTable(
                name: "Apartment_LST_NumABs");

            migrationBuilder.DropTable(
                name: "Apartment_LST_NumBarghs");

            migrationBuilder.DropTable(
                name: "Apartment_LST_NumGAZs");

            migrationBuilder.DropTable(
                name: "Apartment_LST_NumKhabs");

            migrationBuilder.DropTable(
                name: "Apartment_LST_NumTELLs");

            migrationBuilder.DropTable(
                name: "Apartment_LST_Parkings");

            migrationBuilder.DropTable(
                name: "Apartment_LST_Shoofazhs");

            migrationBuilder.DropTable(
                name: "Apartment_LST_Takhliyehs");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ByeAndSell_LST_JahatMoameles");

            migrationBuilder.DropTable(
                name: "ByeAndSell_LST_Karbaries");

            migrationBuilder.DropTable(
                name: "ByeAndSell_LST_MoredeMoamelehs");

            migrationBuilder.DropTable(
                name: "ByeAndSells");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Customers_LST_JOBs");

            migrationBuilder.DropTable(
                name: "House_LST_Abs");

            migrationBuilder.DropTable(
                name: "House_LST_Barghs");

            migrationBuilder.DropTable(
                name: "House_LST_Darbs");

            migrationBuilder.DropTable(
                name: "House_LST_Ejarehs");

            migrationBuilder.DropTable(
                name: "House_LST_Gazs");

            migrationBuilder.DropTable(
                name: "House_LST_NumKhabs");

            migrationBuilder.DropTable(
                name: "House_LST_Parkings");

            migrationBuilder.DropTable(
                name: "House_LST_Statuses");

            migrationBuilder.DropTable(
                name: "House_LST_Tabaghehs");

            migrationBuilder.DropTable(
                name: "House_LST_Voroodies");

            migrationBuilder.DropTable(
                name: "Houses");

            migrationBuilder.DropTable(
                name: "Shop_LST_ABs");

            migrationBuilder.DropTable(
                name: "Shop_LST_Anbaries");

            migrationBuilder.DropTable(
                name: "Shop_LST_Asansors");

            migrationBuilder.DropTable(
                name: "Shop_LST_Balakons");

            migrationBuilder.DropTable(
                name: "Shop_LST_Barghs");

            migrationBuilder.DropTable(
                name: "Shop_LST_Darbs");

            migrationBuilder.DropTable(
                name: "Shop_LST_Ejarehs");

            migrationBuilder.DropTable(
                name: "Shop_LST_Gazs");

            migrationBuilder.DropTable(
                name: "Shop_LST_HagheCharges");

            migrationBuilder.DropTable(
                name: "Shop_LST_InsideDesigns");

            migrationBuilder.DropTable(
                name: "Shop_LST_Locations");

            migrationBuilder.DropTable(
                name: "Shop_LST_PayaneKars");

            migrationBuilder.DropTable(
                name: "Shop_LST_Rahn_OR_Ejarehs");

            migrationBuilder.DropTable(
                name: "Shop_LST_Senfs");

            migrationBuilder.DropTable(
                name: "Shop_LST_Shoofazhs");

            migrationBuilder.DropTable(
                name: "Shop_LST_Tells");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "Willing_LST_Jahats");

            migrationBuilder.DropTable(
                name: "Willing_LSTs");

            migrationBuilder.DropTable(
                name: "Willings");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
