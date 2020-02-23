using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace VCNNetworkEquipment.Models
{
	public class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();

			context.Database.Migrate();

			if (!context.Products.Any())
			{
				context.Products.AddRange(
					new Product
					{
<<<<<<< HEAD
						Name = "Corn",
						Description = "Natural gluten-free",
						
						Category = "Vegetables",
						Price = 25.99,
						Year = "2020",
=======
						Name = "TP-Link TL-SG1008D",
						Description = "15K Jumbo frame improves performance of large data transfers",
						
						Category = "Hub",
						Price = 25.99,
						Year = "2017",
>>>>>>> 1b0fd60acba595427cb53534d15d821b76cf7348
						FreeShip = "Free Ship"
					},
					new Product
					{
<<<<<<< HEAD
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    },
					new Product
					{
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    },
					new Product
					{
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    },
					new Product
					{
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    },
					new Product
					{
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    },
					new Product
					{
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    },
					new Product
					{
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    },
					new Product
					{
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    },
					new Product
					{
                        Name = "Corn",
                        Description = "Natural gluten-free",

                        Category = "Vegetables",
                        Price = 25.99,
                        Year = "2020",
                        FreeShip = "Free Ship"
                    }
=======
						Name = "NETGEAR Nighthawk AC1990",
						Description = "600+1300 Mbps Wifi Speed",
						
						Category = "Router",
						Price = 170.99,
						Year = "2018",
						FreeShip = "Apply Fee"
					},
					new Product
					{
						Name = "Linksys AC1900",
						Description = "Expand Wi-Fi coverage up to 10,000 quare feet",
						
						Category = "Repeater",
						Price = 122.75,
						Year = "2016",
						FreeShip = "Apply Fee"
					},
					new Product
					{
						Name = "Ubiquiti Networks USG-Pro-4",
						Description = "Provide cost-effective, reliable routing and advanced security for your network",
					
						Category = "Gateway",
						Price = 489.50,
						Year = "2016",
						FreeShip = "Free Ship"
					},
					new Product
					{
						Name = "10Gtek for Intel E10GSFPLR",
						Description = "SFP + LR Transceiver. Data Rate: 10.3Gb/s",
						
						Category = "Transceiver",
						Price = 83.50,
						Year = "2017",
						FreeShip = "Apply Fee"
					},
					new Product
					{
						Name = "Tripp Lite 16-port USB",
						Description = "Sync and charge up to 16 tables, phones or other mobile device",
					
						Category = "Hub",
						Price = 455.00,
						Year = "2015",
						FreeShip = "Free Ship"
					},
					new Product
					{
						Name = "STARTECH HP J4859C",
						Description = "Delivers reliable Gigabit Ethernet connections for 1000Base-LX compliant networks",

						Category = "Transceiver",
						Price = 86.99,
						Year = "2016",
						FreeShip = "Free Ship"
					},
					new Product
					{
						Name = "Grandstream VoIP",
						Description = " 8-Port FXS with Gigabit NAT Router",

						Category = "Gateway",
						Price = 86.99,
						Year = "2018",
						FreeShip = "Apply Fee"
					},
					new Product
					{
						Name = "D-Link AC1900",
						Description = "4 gigabit ethernet Ports enable wired connections up to 1000Mbps",
	
						Category = "Router",
						Price = 146.44,
						Year = "2017",
						FreeShip = "Apply Fee"
					},
					new Product
					{
						Name = "ASUS AC2900",
						Description = "Dual-band (2.4 + 5 GHz) with the lastest 802.11ac MU-MINO technology",
					
						Category = "Router",
						Price = 292.99,
						Year = "2018",
						FreeShip = "Free Ship"
					}
>>>>>>> 1b0fd60acba595427cb53534d15d821b76cf7348
					);
				context.SaveChanges();
			}
		}
	}
}
