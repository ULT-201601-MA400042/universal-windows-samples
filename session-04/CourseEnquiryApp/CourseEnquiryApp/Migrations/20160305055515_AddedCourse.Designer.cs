using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using CourseEnquiryApp.DataAccess.Models;

namespace CourseEnquiryApp.Migrations
{
    [DbContext(typeof(CourseEnquiryDbContext))]
    [Migration("20160305055515_AddedCourse")]
    partial class AddedCourse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348");

            modelBuilder.Entity("CourseEnquiryApp.DataAccess.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("LearnerId");

                    b.Property<string>("Name");

                    b.Property<string>("Overview");

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("Summary");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("CourseEnquiryApp.DataAccess.Models.Learner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("CourseEnquiryApp.DataAccess.Models.Course", b =>
                {
                    b.HasOne("CourseEnquiryApp.DataAccess.Models.Learner")
                        .WithMany()
                        .HasForeignKey("LearnerId");
                });
        }
    }
}
