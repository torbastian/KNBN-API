// <auto-generated />
using System;
using KNBN_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KNBN_API.Migrations
{
    [DbContext(typeof(KanbanContext))]
    [Migration("20210324084252_update1")]
    partial class update1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KNBN_API.Models.Board", b =>
                {
                    b.Property<int>("BoardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BoardId");

                    b.HasIndex("UserId");

                    b.ToTable("Boards");
                });

            modelBuilder.Entity("KNBN_API.Models.Board_Members", b =>
                {
                    b.Property<int>("Board_MembersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BoardId")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Board_MembersId");

                    b.HasIndex("BoardId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Board_Members");
                });

            modelBuilder.Entity("KNBN_API.Models.Card", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<int?>("TableId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardId");

                    b.HasIndex("TableId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("KNBN_API.Models.Card_Labels", b =>
                {
                    b.Property<int>("Card_LabelsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.Property<int?>("LabelsId")
                        .HasColumnType("int");

                    b.HasKey("Card_LabelsId");

                    b.HasIndex("CardId");

                    b.HasIndex("LabelsId");

                    b.ToTable("Card_Labels");
                });

            modelBuilder.Entity("KNBN_API.Models.Card_Members", b =>
                {
                    b.Property<int>("Card_MembersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Board_MembersId")
                        .HasColumnType("int");

                    b.Property<int?>("CardId")
                        .HasColumnType("int");

                    b.HasKey("Card_MembersId");

                    b.HasIndex("Board_MembersId");

                    b.HasIndex("CardId");

                    b.ToTable("Card_Members");
                });

            modelBuilder.Entity("KNBN_API.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("KNBN_API.Models.Group_Member", b =>
                {
                    b.Property<int>("Group_MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Group_MemberId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Group_Members");
                });

            modelBuilder.Entity("KNBN_API.Models.Labels", b =>
                {
                    b.Property<int>("LabelsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("LabelsId");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("KNBN_API.Models.Permission_Members", b =>
                {
                    b.Property<int>("Permission_MemebersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BoardId")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int?>("PermissionsId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Permission_MemebersId");

                    b.HasIndex("BoardId");

                    b.HasIndex("GroupId");

                    b.HasIndex("PermissionsId");

                    b.HasIndex("UserId");

                    b.ToTable("Permission_Members");
                });

            modelBuilder.Entity("KNBN_API.Models.Permissions", b =>
                {
                    b.Property<int>("PermissionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PermissionsId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("KNBN_API.Models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BoardId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("BoardId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("KNBN_API.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("KNBN_API.Models.Board", b =>
                {
                    b.HasOne("KNBN_API.Models.User", null)
                        .WithMany("Boards")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("KNBN_API.Models.Board_Members", b =>
                {
                    b.HasOne("KNBN_API.Models.Board", null)
                        .WithMany("Board_Members")
                        .HasForeignKey("BoardId");

                    b.HasOne("KNBN_API.Models.Group", null)
                        .WithMany("Board_Members")
                        .HasForeignKey("GroupId");

                    b.HasOne("KNBN_API.Models.User", null)
                        .WithMany("Board_Members")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("KNBN_API.Models.Card", b =>
                {
                    b.HasOne("KNBN_API.Models.Table", null)
                        .WithMany("Card")
                        .HasForeignKey("TableId");
                });

            modelBuilder.Entity("KNBN_API.Models.Card_Labels", b =>
                {
                    b.HasOne("KNBN_API.Models.Card", null)
                        .WithMany("Card_Labels")
                        .HasForeignKey("CardId");

                    b.HasOne("KNBN_API.Models.Labels", null)
                        .WithMany("Card_Labels")
                        .HasForeignKey("LabelsId");
                });

            modelBuilder.Entity("KNBN_API.Models.Card_Members", b =>
                {
                    b.HasOne("KNBN_API.Models.Board_Members", null)
                        .WithMany("Card_Members")
                        .HasForeignKey("Board_MembersId");

                    b.HasOne("KNBN_API.Models.Card", null)
                        .WithMany("Card_Members")
                        .HasForeignKey("CardId");
                });

            modelBuilder.Entity("KNBN_API.Models.Group_Member", b =>
                {
                    b.HasOne("KNBN_API.Models.Group", null)
                        .WithMany("Group_Members")
                        .HasForeignKey("GroupId");

                    b.HasOne("KNBN_API.Models.User", null)
                        .WithMany("Group_Members")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("KNBN_API.Models.Permission_Members", b =>
                {
                    b.HasOne("KNBN_API.Models.Board", null)
                        .WithMany("Permission_Members")
                        .HasForeignKey("BoardId");

                    b.HasOne("KNBN_API.Models.Group", null)
                        .WithMany("Permission_Members")
                        .HasForeignKey("GroupId");

                    b.HasOne("KNBN_API.Models.Permissions", null)
                        .WithMany("Permission_Members")
                        .HasForeignKey("PermissionsId");

                    b.HasOne("KNBN_API.Models.User", null)
                        .WithMany("Permission_Members")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("KNBN_API.Models.Table", b =>
                {
                    b.HasOne("KNBN_API.Models.Board", null)
                        .WithMany("Tables")
                        .HasForeignKey("BoardId");
                });

            modelBuilder.Entity("KNBN_API.Models.Board", b =>
                {
                    b.Navigation("Board_Members");

                    b.Navigation("Permission_Members");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("KNBN_API.Models.Board_Members", b =>
                {
                    b.Navigation("Card_Members");
                });

            modelBuilder.Entity("KNBN_API.Models.Card", b =>
                {
                    b.Navigation("Card_Labels");

                    b.Navigation("Card_Members");
                });

            modelBuilder.Entity("KNBN_API.Models.Group", b =>
                {
                    b.Navigation("Board_Members");

                    b.Navigation("Group_Members");

                    b.Navigation("Permission_Members");
                });

            modelBuilder.Entity("KNBN_API.Models.Labels", b =>
                {
                    b.Navigation("Card_Labels");
                });

            modelBuilder.Entity("KNBN_API.Models.Permissions", b =>
                {
                    b.Navigation("Permission_Members");
                });

            modelBuilder.Entity("KNBN_API.Models.Table", b =>
                {
                    b.Navigation("Card");
                });

            modelBuilder.Entity("KNBN_API.Models.User", b =>
                {
                    b.Navigation("Board_Members");

                    b.Navigation("Boards");

                    b.Navigation("Group_Members");

                    b.Navigation("Permission_Members");
                });
#pragma warning restore 612, 618
        }
    }
}
