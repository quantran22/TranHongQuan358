// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace TranHongQuan358.Migrations
{
    [DbContext(typeof(BaiTapDBContext))]
    partial class BaiTapDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("DemoDotNetMVC.Models.UniversityTHQ358", b =>
                {
                    b.Property<string>("UniversityId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("UniversityName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("UniversityId");

                    b.ToTable("UniversityTHQ358s");
                });

            modelBuilder.Entity("TranHongQuan358.Models.THQ358", b =>
                {
                    b.Property<string>("THQId")
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<bool>("THQGender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("THQName")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("THQId");

                    b.ToTable("THQ358");
                });
#pragma warning restore 612, 618
        }
    }
}
