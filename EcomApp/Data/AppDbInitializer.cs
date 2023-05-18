using EcomApp.Data.Enums;
using EcomApp.Models;

namespace EcomApp.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Customer
                if (!context.Customers.Any())
                {
                    context.Customers.AddRange(new List<Customer>() {

                         new Customer()
                         {
                            FirstName = "Nipuna",
                            LastName = "Kusal",
                            Email = "nipunakusal98@gmail.com",
                            Password = "1234",
                            MobileNumber = "1234567890"
                         }

                });
                    context.SaveChanges();

                }

                //ComputerCategory
                if (!context.ComputerCategories.Any())
                {
                    context.ComputerCategories.AddRange(new List<ComputerCategory>() {

                        new ComputerCategory()
                        {
                            CategoryName ="Desktop",
                            CategoryPictuerURL ="https://images.easytechjunkie.com/slideshow-mobile-small/black-desktop-computer.jpg"
                        },

                        new ComputerCategory()
                        {
                            CategoryName ="Notebook",
                            CategoryPictuerURL ="https://images.easytechjunkie.com/slideshow-mobile-small/black-desktop-computer.jpg"
                        }
                    }); ;
                    context.SaveChanges();
                }



                //ComputerSeries
                if (!context.ComputerSeries.Any())
                {
                    context.ComputerSeries.AddRange(new List<ComputerSeries>() {

                        new ComputerSeries()
                        {
                            SeriesName = "Home Premium",
                            SeriesIconURL ="",
                            ComputerCategoryId = 2


                        },

                            new ComputerSeries()
                        {
                            SeriesName = "Budget PC",
                            SeriesIconURL ="",
                            ComputerCategoryId = 1


                        },

                          new ComputerSeries()
                        {
                            SeriesName = "Business Plus",
                            SeriesIconURL ="",
                            ComputerCategoryId = 2


                        },

                            new ComputerSeries()
                        {
                            SeriesName = "High Performance PC",
                            SeriesIconURL ="",
                            ComputerCategoryId = 1


                        },

                            new ComputerSeries()
                        {
                            SeriesName = "Gamer",
                            SeriesIconURL ="",
                            ComputerCategoryId = 2


                        },

                                new ComputerSeries()
                        {
                            SeriesName = "Home PC",
                            SeriesIconURL ="",
                            ComputerCategoryId = 1


                        },
                    });
                    context.SaveChanges();
                }


                //ComputerProcessor
                if (!context.ComputerProcessors.Any())
                {
                    context.ComputerProcessors.AddRange(new List<ComputerProcessor> {
                        new ComputerProcessor()
                        {
                            ProcessorDescription = "2nd generation Intel® Core™ i7-2860QM processor 2.50 GHz",
                            ProcessorPictuerURL= "",
                            ProcessorPrice= 23000
                        },
                        new ComputerProcessor()
                         {
                            ProcessorDescription = "3rd generation Intel® Core™ i5-2860QM processor 6.50 GHz",
                            ProcessorPictuerURL= "",
                            ProcessorPrice= 43000
                        },
                    });
                }

                //ComputerRAM
                if (!context.ComputerRAMs.Any())
                {
                    context.ComputerRAMs.AddRange(new List<ComputerRAM>(){
                        new ComputerRAM()
                        {
                            RAMId = 1,
                            RAMDescription = "Kingston DDR3 8Gb DIMM",
                            RAMPictuerURL = "",
                            RAMPrice = 3400,


                        },

                        new ComputerRAM()
                        {
                            RAMId=2,
                            RAMDescription = "SanDisk DDR3 4Gb DIMM",
                            RAMPictuerURL = "",
                            RAMPrice = 2400,


                        },
                    });
                    context.SaveChanges();
                }

                //ComputerVGA
                if (!context.ComputerVGAs.Any())
                {
                    context.ComputerVGAs.AddRange(new List<ComputerVGA>(){
                        new ComputerVGA()
                        {
                            ComputerVGADescription = "MSI GTX 1080",
                            VGAPictuerURL = "",
                            ComputerVGAPrice = 2400,
                        },

                        new ComputerVGA()
                         {
                            ComputerVGADescription = "NVidia GTR 1080",
                            VGAPictuerURL = "",
                            ComputerVGAPrice = 24000,
                        }
                    });
                    context.SaveChanges();
                }



                //ComputerModel
                if (!context.ComputerModels.Any())
                {
                    context.ComputerModels.AddRange(new List<ComputerModel>() {

                        new ComputerModel()
                        {
                            Name ="Asus X515 Notebook Laptop",
                            Price = 00,
                            ModelPictuerURL = "",
                            AntiVirus =AntiVirus.Kaspersky,
                            OperatingSystems = OperatingSystems.Windows,
                            ComputerSeriesId =1,
                            RAMId =1,
                            ComputerVGAId =1,
                            ComputerProcessorId =1,



                        },

                         new ComputerModel()
                        {
                            Name ="Acer  Notebook Laptop",
                            Price = 100,
                            ModelPictuerURL = "",
                            AntiVirus =AntiVirus.Avast,
                            OperatingSystems = OperatingSystems.Windows,
                            ComputerSeriesId =2,
                            RAMId =2,
                            ComputerVGAId =2,
                            ComputerProcessorId =2,



                        },

                    });

                    context.SaveChanges();
                }
                
                
                
                
                //ConfigurationItem
                if (!context.ConfigurationItems.Any()) 
                {
                    context.ConfigurationItems.AddRange(new List<ConfigurationItem> {
                        new ConfigurationItem() 
                        {
                            ComputerModelId = 1,
                            AntiVirus = AntiVirus.Defender,
                            OperatingSystems = OperatingSystems.Ubuntu,
                            ConfigurationType =ConfigurationType.Customized,
                            Price = 34235
                        }
                    });
                    context.SaveChanges();
                }
                ////Order
                //if (!context.Orders.Any()) { }
                ////Payment
                //if (!context.Payments.Any()) { }


            }
        }
    }
}
