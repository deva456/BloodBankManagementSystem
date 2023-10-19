using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BloodBank.Models;

namespace BloodBank.Configuration
{
    public class CityConfig:IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(s => s.c_id);
            builder.ToTable(nameof(City));
            builder.Property(s => s.c_id).IsRequired(true);

            builder.HasData(
                new City
                {
                    c_id = 1,
                    c_name = "Nashik"
                },
                 new City
                 {
                     c_id= 2, 
                     c_name = "Pune"
                 }
                ); ;

        }

    }
    public class HospitalConfig : IEntityTypeConfiguration<Hospital>
    {
        public void Configure(EntityTypeBuilder<Hospital> builder)
        {
            builder.HasKey(s => s.h_Id);
            builder.ToTable(nameof(Hospital));
            builder.Property(s => s.h_city).IsRequired(true);
            builder.Property(s => s.h_loc_url).IsRequired(true);
            builder.Property(s => s.h_bloodquantity).IsRequired(true);
            builder.Property(s => s.h_img).IsRequired(true);
            builder.Property(s => s.h_location).IsRequired(true);
            builder.Property(s => s.h_name).IsRequired(true);


            builder.HasData(
                new Hospital
                {
                    h_Id = 1,
                    h_name = "Six Sigma Hospital",
                    h_city = "Nashik",
                    h_location = "Mahatma Nagar Nashik",
                    h_loc_url = "Google Maps URL",
                    h_img = "https://previews.123rf.com/images/msvetlana/msvetlana1404/msvetlana140400006/27517099-city-hospital-building-with-reflection-on-a-blue-background.jpg",
                    h_bloodquantity =230,

                }
                 
                ); 

        }

    }
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(s => s.u_Id);
            builder.ToTable(nameof(User));
            builder.Property(s => s.u_Name).IsRequired(true);
            builder.Property(s => s.u_Email).IsRequired(true);
            builder.Property(s => s.u_Password).IsRequired(true);
            builder.Property(s => s.u_PhoneNumber).IsRequired(true);
            builder.Property(s => s.u_Address).IsRequired(true);
            builder.Property(s => s.u_bloodgroup).IsRequired(true);
            builder.Property(s => s.u_wallet).IsRequired(false);
            builder.Property(s => s.u_status).IsRequired(false);



            builder.HasData(
                new User
                {
                    u_Id=1,
                    u_Name = "Devashish Kapadnis",
                    u_Email ="devashishkapadnis075@gmail.com",
                    u_Password = "devashish",
                    u_PhoneNumber = "7058204270",
                    u_Address = "Google Maps URL",
                    u_bloodgroup = "B+",
                    u_wallet=0,
                    u_status="Active"

                }

                );

        }

    }
    public class Blood_dataConfig : IEntityTypeConfiguration<Blood_data>
    {
        public void Configure(EntityTypeBuilder<Blood_data> builder)
        {
            builder.HasKey(s => s.b_Id);
            builder.ToTable(nameof(Blood_data));
            builder.Property(s => s.b_type).IsRequired(true);
            builder.Property(s => s.b_quantity).IsRequired(true);
            builder.Property(s => s.b_price).IsRequired(true);
            builder.Property(s => s.h_id).IsRequired(true);
           



            builder.HasData(
                new Blood_data
                {
                    b_Id = 1,
                    h_id=1,
                    b_type="A+",
                    b_quantity=10,
                    b_price=1900

                },
                 new Blood_data
                 {
                     b_Id = 2,
                     h_id = 1,
                     b_type = "A-",
                     b_quantity = 10,
                     b_price = 1900

                 },
                  new Blood_data
                  {
                      b_Id = 3,
                      h_id = 1,
                      b_type = "AB+",
                      b_quantity = 10,
                      b_price = 1900

                  },
                   new Blood_data
                   {
                       b_Id = 4,
                       h_id = 1,
                       b_type = "AB-",
                       b_quantity = 10,
                       b_price = 1900

                   },
                    new Blood_data
                    {
                        b_Id = 5,
                        h_id = 1,
                        b_type = "B-",
                        b_quantity = 10,
                        b_price = 1900

                    },
                     new Blood_data
                     {
                         b_Id = 6,
                         h_id = 1,
                         b_type = "B+",
                         b_quantity = 10,
                         b_price = 1900

                     },
                      new Blood_data
                      {
                          b_Id = 7,
                          h_id = 1,
                          b_type = "O-",
                          b_quantity = 10,
                          b_price = 1900

                      },
                       new Blood_data
                       {
                           b_Id = 8,
                           h_id = 1,
                           b_type = "O+",
                           b_quantity = 10,
                           b_price = 1900

                       }

                );

        }

    }
    public class AdminConfig : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(s => s.Id);
            builder.ToTable(nameof(Admin));
            builder.Property(s => s.Name).IsRequired(true);
            builder.Property(s => s.password).IsRequired(true);


            builder.HasData(
                new Admin
                {
                   Id=1,
                   Name="Kunal",
                   password="kunal+"
                }

                );

        }

    }
}
