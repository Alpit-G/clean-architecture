using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanitarianAssistance.Persistence.Migrations
{
    public partial class currencyDetailTblStatusFieldRemovedAndDateTimeNowRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrencyRate",
                table: "CurrencyDetails");

            migrationBuilder.DropColumn(
                name: "SalaryTaxFlag",
                table: "CurrencyDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CurrencyDetails");

            migrationBuilder.UpdateData(
                table: "AccountFilterType",
                keyColumn: "AccountFilterTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "AccountFilterType",
                keyColumn: "AccountFilterTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityTypes",
                keyColumn: "ActivityTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ActivityTypes",
                keyColumn: "ActivityTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 5,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 6,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 7,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 8,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 9,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 10,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 11,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 12,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 13,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 14,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 15,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 16,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 17,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 18,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 19,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 20,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 21,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 22,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 23,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 24,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 25,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 26,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 27,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 28,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 29,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 30,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 31,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 32,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 33,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 34,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 35,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 36,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 37,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 38,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 39,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 40,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 41,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 42,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 43,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 44,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 45,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 46,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 47,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 48,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 49,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 50,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 51,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 52,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 53,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 54,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 55,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 56,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 57,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 58,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 59,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 60,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 61,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 62,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 63,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 64,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 65,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 66,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 67,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 68,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 69,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 70,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 71,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 72,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 73,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 74,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 75,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 76,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 77,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 78,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 79,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 80,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 81,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 82,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 83,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 84,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 85,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 86,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 87,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 88,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "CountryDetails",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "CountryDetails",
                keyColumn: "CountryId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "CurrencyDetails",
                keyColumn: "CurrencyId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "CurrencyDetails",
                keyColumn: "CurrencyId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "CurrencyDetails",
                keyColumn: "CurrencyId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "CurrencyDetails",
                keyColumn: "CurrencyId",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 1L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 2L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 3L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 4L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 5L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 6L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 7L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 8L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 9L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 10L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 11L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 12L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 13L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 14L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 15L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 16L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 17L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 18L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 19L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 20L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 21L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 22L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 23L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 24L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 25L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 26L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 27L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 28L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 29L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 30L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 31L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 32L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 33L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 34L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 35L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 36L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 37L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 38L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 39L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 40L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 41L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 42L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 43L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 44L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 45L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 46L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 47L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 48L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 49L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 50L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 51L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 52L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 53L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 54L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 55L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 56L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 57L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 58L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 59L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 60L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 61L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 62L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 63L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 64L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 65L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 66L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 67L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 68L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 69L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 70L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 71L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 72L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 73L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 74L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 75L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 76L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 77L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 78L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 79L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 80L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 81L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 82L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 83L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 84L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 85L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 86L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 87L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 88L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 89L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 90L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 91L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 92L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 93L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 94L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 95L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 96L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 97L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 98L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 99L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 100L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 101L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 102L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 103L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 104L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 105L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 106L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 107L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 108L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 109L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 110L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 111L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 112L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 113L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 114L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 115L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 116L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 117L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 118L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 119L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 120L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 121L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 122L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 123L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "EmailType",
                keyColumn: "EmailTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "EmailType",
                keyColumn: "EmailTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "EmployeeTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "EmployeeTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "EmployeeTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "FinancialYearDetail",
                keyColumn: "FinancialYearId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 1L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 2L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 3L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 4L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 5L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 6L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 7L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 8L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 11,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LeaveReasonDetail",
                keyColumn: "LeaveReasonId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LeaveReasonDetail",
                keyColumn: "LeaveReasonId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "LeaveReasonDetail",
                keyColumn: "LeaveReasonId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "OfficeDetail",
                keyColumn: "OfficeId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 5,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProjectPhaseDetails",
                keyColumn: "ProjectPhaseDetailsId",
                keyValue: 1L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 5,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 6,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 7,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 8,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 9,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 10,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 11,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 12,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 13,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 14,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 15,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 16,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 17,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 18,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 19,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 20,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 21,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 22,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 23,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 24,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 25,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 26,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 27,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 28,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 29,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 30,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 31,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 32,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 33,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 34,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 35,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 36,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 37,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 38,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 39,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 40,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 41,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 42,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 43,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 44,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 45,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 46,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 47,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 48,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 49,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 50,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 51,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 52,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 53,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 54,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 55,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 56,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 57,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 58,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 59,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 60,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 61,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 62,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 63,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 64,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 65,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 66,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 67,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 68,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 69,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 70,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 71,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 72,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 73,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 74,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 75,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 76,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 77,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 78,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 79,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 80,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 81,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 82,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 83,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 1,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 2,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 3,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 4,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 5,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 6,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 7,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 8,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 9,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 10,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 11,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 1L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 2L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 3L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 4L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 5L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 6L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 7L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 8L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 9L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 10L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 11L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityDetail",
                keyColumn: "SecurityId",
                keyValue: 1L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityDetail",
                keyColumn: "SecurityId",
                keyValue: 2L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "SecurityDetail",
                keyColumn: "SecurityId",
                keyValue: 3L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "StrengthConsiderationDetail",
                keyColumn: "StrengthConsiderationId",
                keyValue: 1L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "StrengthConsiderationDetail",
                keyColumn: "StrengthConsiderationId",
                keyValue: 2L,
                column: "CreatedDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "StrengthConsiderationDetail",
                keyColumn: "StrengthConsiderationId",
                keyValue: 3L,
                column: "CreatedDate",
                value: null);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "CurrencyRate",
                table: "CurrencyDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "SalaryTaxFlag",
                table: "CurrencyDetails",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "CurrencyDetails",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountFilterType",
                keyColumn: "AccountFilterTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3852));

            migrationBuilder.UpdateData(
                table: "AccountFilterType",
                keyColumn: "AccountFilterTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(4583));

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(5277));

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(5298));

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(5299));

            migrationBuilder.UpdateData(
                table: "AccountHeadType",
                keyColumn: "AccountHeadTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(5300));

            migrationBuilder.UpdateData(
                table: "ActivityTypes",
                keyColumn: "ActivityTypeId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(8066));

            migrationBuilder.UpdateData(
                table: "ActivityTypes",
                keyColumn: "ActivityTypeId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(9279));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(483));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(492));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(493));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(496));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(504));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(505));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(509));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(535));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(553));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(555));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(559));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(562));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(565));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(567));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(571));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(575));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(578));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 84,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 85,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 86,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(581));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 87,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "ApplicationPages",
                keyColumn: "PageId",
                keyValue: 88,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(583));

            migrationBuilder.UpdateData(
                table: "CountryDetails",
                keyColumn: "CountryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(9141));

            migrationBuilder.UpdateData(
                table: "CountryDetails",
                keyColumn: "CountryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "CurrencyDetails",
                keyColumn: "CurrencyId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "SalaryTaxFlag", "Status" },
                values: new object[] { new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(1488), true, false });

            migrationBuilder.UpdateData(
                table: "CurrencyDetails",
                keyColumn: "CurrencyId",
                keyValue: 2,
                columns: new[] { "CreatedDate", "SalaryTaxFlag", "Status" },
                values: new object[] { new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(2400), false, false });

            migrationBuilder.UpdateData(
                table: "CurrencyDetails",
                keyColumn: "CurrencyId",
                keyValue: 3,
                columns: new[] { "CreatedDate", "SalaryTaxFlag", "Status" },
                values: new object[] { new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(2416), false, true });

            migrationBuilder.UpdateData(
                table: "CurrencyDetails",
                keyColumn: "CurrencyId",
                keyValue: 4,
                columns: new[] { "CreatedDate", "SalaryTaxFlag", "Status" },
                values: new object[] { new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(2417), false, false });

            migrationBuilder.UpdateData(
                table: "Department",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(6344));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(1464));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2242));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2248));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2251));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 12L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 13L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 14L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 15L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2257));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 16L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 17L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2259));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 18L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 19L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 20L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 21L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 22L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 23L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2265));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 24L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 25L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 26L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 27L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 28L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 29L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 30L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 31L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 32L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 33L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 34L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 35L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 36L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2282));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 37L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 38L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 39L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 40L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 41L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 42L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 43L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 44L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 45L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 46L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 47L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2294));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 48L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 49L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 50L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 51L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 52L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 53L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 54L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 55L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 56L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 57L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 58L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 59L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 60L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 61L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 62L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 63L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 64L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 65L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 66L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 67L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 68L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 69L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 70L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 71L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 72L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 73L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 74L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 75L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 76L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 77L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 78L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 79L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 80L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 81L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 82L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 83L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 84L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 85L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 86L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 87L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 88L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 89L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 90L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 91L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 92L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 93L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 94L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 95L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 96L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 97L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 98L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 99L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 100L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 101L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 102L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2476));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 103L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 104L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 105L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 106L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 107L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 108L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 109L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 110L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 111L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 112L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 113L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 114L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 115L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 116L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 117L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 118L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 119L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 120L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 121L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 122L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "DistrictDetail",
                keyColumn: "DistrictID",
                keyValue: 123L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 958, DateTimeKind.Utc).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "EmailType",
                keyColumn: "EmailTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(7578));

            migrationBuilder.UpdateData(
                table: "EmailType",
                keyColumn: "EmailTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(8335));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "EmployeeTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "EmployeeTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "EmployeeType",
                keyColumn: "EmployeeTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "FinancialYearDetail",
                keyColumn: "FinancialYearId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 957, DateTimeKind.Utc).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8421));

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8427));

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "GenderConsiderationDetail",
                keyColumn: "GenderConsiderationId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8432));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3046));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3068));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "LanguageDetail",
                keyColumn: "LanguageId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "LeaveReasonDetail",
                keyColumn: "LeaveReasonId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "LeaveReasonDetail",
                keyColumn: "LeaveReasonId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "LeaveReasonDetail",
                keyColumn: "LeaveReasonId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "OfficeDetail",
                keyColumn: "OfficeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 953, DateTimeKind.Utc).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "PayrollAccountHead",
                keyColumn: "PayrollHeadId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(651));

            migrationBuilder.UpdateData(
                table: "ProjectPhaseDetails",
                keyColumn: "ProjectPhaseDetailsId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(886));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1939));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1967));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1972));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1977));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1982));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1993));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2002));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2005));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2011));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2015));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2017));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2018));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2021));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2022));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2040));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2044));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2054));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2064));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 70,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 71,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2066));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 72,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 73,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 74,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2072));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 75,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 76,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 77,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 78,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 79,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 80,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 81,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 82,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "ProvinceDetails",
                keyColumn: "ProvinceId",
                keyValue: 83,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(3311));

            migrationBuilder.UpdateData(
                table: "ReceiptType",
                keyColumn: "ReceiptTypeId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 954, DateTimeKind.Utc).AddTicks(3312));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "SalaryHeadDetails",
                keyColumn: "SalaryHeadId",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 956, DateTimeKind.Utc).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 4L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 5L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 6L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 7L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 8L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 9L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 10L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "SecurityConsiderationDetail",
                keyColumn: "SecurityConsiderationId",
                keyValue: 11L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9812));

            migrationBuilder.UpdateData(
                table: "SecurityDetail",
                keyColumn: "SecurityId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "SecurityDetail",
                keyColumn: "SecurityId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "SecurityDetail",
                keyColumn: "SecurityId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(9122));

            migrationBuilder.UpdateData(
                table: "StrengthConsiderationDetail",
                keyColumn: "StrengthConsiderationId",
                keyValue: 1L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "StrengthConsiderationDetail",
                keyColumn: "StrengthConsiderationId",
                keyValue: 2L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "StrengthConsiderationDetail",
                keyColumn: "StrengthConsiderationId",
                keyValue: 3L,
                column: "CreatedDate",
                value: new DateTime(2019, 8, 9, 13, 14, 11, 955, DateTimeKind.Utc).AddTicks(7694));
        }
    }
}
