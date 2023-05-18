using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomApp.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComputerCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryPictuerURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerCategories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "ProcessorBrands",
                columns: table => new
                {
                    ProcessorBrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessorBrandName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcessorBrands", x => x.ProcessorBrandId);
                });

            migrationBuilder.CreateTable(
                name: "RAMBrands",
                columns: table => new
                {
                    RAMBrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RAMBrandName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMBrands", x => x.RAMBrandId);
                });

            migrationBuilder.CreateTable(
                name: "VGABrands",
                columns: table => new
                {
                    VGABrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VGABrandName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VGABrands", x => x.VGABrandId);
                });

            migrationBuilder.CreateTable(
                name: "ComputerSeries",
                columns: table => new
                {
                    SeriesId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SeriesIconURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerSeries", x => x.SeriesId);
                    table.ForeignKey(
                        name: "FK_ComputerSeries_ComputerCategories_ComputerCategoryId",
                        column: x => x.ComputerCategoryId,
                        principalTable: "ComputerCategories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ModelPictuerURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OperatingSystems = table.Column<int>(type: "int", nullable: false),
                    AntiVirus = table.Column<int>(type: "int", nullable: false),
                    RAMId = table.Column<int>(type: "int", nullable: false),
                    ComputerVGAId = table.Column<int>(type: "int", nullable: false),
                    ComputerRAMId = table.Column<int>(type: "int", nullable: false),
                    ComputerProcessorId = table.Column<int>(type: "int", nullable: false),
                    ComputerSeriesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComputerModels_ComputerSeries_ComputerSeriesId",
                        column: x => x.ComputerSeriesId,
                        principalTable: "ComputerSeries",
                        principalColumn: "SeriesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<int>(type: "int", nullable: false),
                    ShippingMethod = table.Column<int>(type: "int", nullable: false),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ComputerModelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_ComputerModels_ComputerModelId",
                        column: x => x.ComputerModelId,
                        principalTable: "ComputerModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConfigurationItems",
                columns: table => new
                {
                    ConfigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<int>(type: "int", nullable: false),
                    OperatingSystems = table.Column<int>(type: "int", nullable: false),
                    AntiVirus = table.Column<int>(type: "int", nullable: false),
                    ConfigurationType = table.Column<int>(type: "int", nullable: false),
                    ComputerModelId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfigurationItems", x => x.ConfigId);
                    table.ForeignKey(
                        name: "FK_ConfigurationItems_ComputerModels_ComputerModelId",
                        column: x => x.ComputerModelId,
                        principalTable: "ComputerModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConfigurationItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardholderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                    table.ForeignKey(
                        name: "FK_Payments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Payments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ComputerProcessors",
                columns: table => new
                {
                    ComputerProcessorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProcessorDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessorPictuerURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessorPrice = table.Column<int>(type: "int", nullable: false),
                    ConfigurationItemConfigId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerProcessors", x => x.ComputerProcessorId);
                    table.ForeignKey(
                        name: "FK_ComputerProcessors_ConfigurationItems_ConfigurationItemConfigId",
                        column: x => x.ConfigurationItemConfigId,
                        principalTable: "ConfigurationItems",
                        principalColumn: "ConfigId");
                });

            migrationBuilder.CreateTable(
                name: "ComputerRAMs",
                columns: table => new
                {
                    RAMId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RAMDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAMPictuerURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAMPrice = table.Column<int>(type: "int", nullable: false),
                    ConfigurationItemConfigId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerRAMs", x => x.RAMId);
                    table.ForeignKey(
                        name: "FK_ComputerRAMs_ConfigurationItems_ConfigurationItemConfigId",
                        column: x => x.ConfigurationItemConfigId,
                        principalTable: "ConfigurationItems",
                        principalColumn: "ConfigId");
                });

            migrationBuilder.CreateTable(
                name: "ComputerVGAs",
                columns: table => new
                {
                    ComputerVGAId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComputerVGADescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComputerVGAPrice = table.Column<int>(type: "int", nullable: false),
                    VGAPictuerURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfigurationItemConfigId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComputerVGAs", x => x.ComputerVGAId);
                    table.ForeignKey(
                        name: "FK_ComputerVGAs_ConfigurationItems_ConfigurationItemConfigId",
                        column: x => x.ConfigurationItemConfigId,
                        principalTable: "ConfigurationItems",
                        principalColumn: "ConfigId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComputerModels_ComputerProcessorId",
                table: "ComputerModels",
                column: "ComputerProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerModels_ComputerRAMId",
                table: "ComputerModels",
                column: "ComputerRAMId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerModels_ComputerSeriesId",
                table: "ComputerModels",
                column: "ComputerSeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerModels_RAMId",
                table: "ComputerModels",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerProcessors_ConfigurationItemConfigId",
                table: "ComputerProcessors",
                column: "ConfigurationItemConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerRAMs_ConfigurationItemConfigId",
                table: "ComputerRAMs",
                column: "ConfigurationItemConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerSeries_ComputerCategoryId",
                table: "ComputerSeries",
                column: "ComputerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ComputerVGAs_ConfigurationItemConfigId",
                table: "ComputerVGAs",
                column: "ConfigurationItemConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationItems_ComputerModelId",
                table: "ConfigurationItems",
                column: "ComputerModelId");

            migrationBuilder.CreateIndex(
                name: "IX_ConfigurationItems_OrderId",
                table: "ConfigurationItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ComputerModelId",
                table: "Orders",
                column: "ComputerModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_CustomerId",
                table: "Payments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerModels_ComputerProcessors_ComputerProcessorId",
                table: "ComputerModels",
                column: "ComputerProcessorId",
                principalTable: "ComputerProcessors",
                principalColumn: "ComputerProcessorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerModels_ComputerRAMs_RAMId",
                table: "ComputerModels",
                column: "RAMId",
                principalTable: "ComputerRAMs",
                principalColumn: "RAMId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerModels_ComputerVGAs_ComputerRAMId",
                table: "ComputerModels",
                column: "ComputerRAMId",
                principalTable: "ComputerVGAs",
                principalColumn: "ComputerVGAId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerModels_ComputerProcessors_ComputerProcessorId",
                table: "ComputerModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerModels_ComputerRAMs_RAMId",
                table: "ComputerModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerModels_ComputerSeries_ComputerSeriesId",
                table: "ComputerModels");

            migrationBuilder.DropForeignKey(
                name: "FK_ComputerModels_ComputerVGAs_ComputerRAMId",
                table: "ComputerModels");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "ProcessorBrands");

            migrationBuilder.DropTable(
                name: "RAMBrands");

            migrationBuilder.DropTable(
                name: "VGABrands");

            migrationBuilder.DropTable(
                name: "ComputerProcessors");

            migrationBuilder.DropTable(
                name: "ComputerRAMs");

            migrationBuilder.DropTable(
                name: "ComputerSeries");

            migrationBuilder.DropTable(
                name: "ComputerCategories");

            migrationBuilder.DropTable(
                name: "ComputerVGAs");

            migrationBuilder.DropTable(
                name: "ConfigurationItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "ComputerModels");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
