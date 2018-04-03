namespace Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<Balance> Balances { get; set; }
        public virtual DbSet<Balance_Pay> Balance_Pay { get; set; }
        public virtual DbSet<CertificateInfo> CertificateInfoes { get; set; }
        public virtual DbSet<CompanyInfo> CompanyInfoes { get; set; }
        public virtual DbSet<Edu> Edus { get; set; }
        public virtual DbSet<Edu_Exper> Edu_Exper { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<MyCompany> MyCompanies { get; set; }
        public virtual DbSet<MyMoney> MyMoneys { get; set; }
        public virtual DbSet<MyMoney_Pay> MyMoney_Pay { get; set; }
        public virtual DbSet<Pro_Exper> Pro_Exper { get; set; }
        public virtual DbSet<resume> resumes { get; set; }
        public virtual DbSet<S_City> S_City { get; set; }
        public virtual DbSet<S_District> S_District { get; set; }
        public virtual DbSet<S_Province> S_Province { get; set; }
        public virtual DbSet<TuiJian_Resume> TuiJian_Resume { get; set; }
        public virtual DbSet<TuiJianXin> TuiJianXins { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<Work_Exper> Work_Exper { get; set; }
        public virtual DbSet<ZiJian> ZiJians { get; set; }
        public virtual DbSet<BLB_Money> BLB_Money { get; set; }
        public virtual DbSet<MianShiSM> MianShiSMS { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<User_WeChat> User_WeChat { get; set; }
        public virtual DbSet<UserCard> UserCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Balance>()
                .Property(e => e.Money)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Balance_Pay>()
                .Property(e => e.Money)
                .HasPrecision(16, 2);

            modelBuilder.Entity<CompanyInfo>()
                .Property(e => e.C_Email)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfo>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfo>()
                .Property(e => e.Pwd)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfo>()
                .Property(e => e.Scale)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfo>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfo>()
                .HasMany(e => e.Balances)
                .WithRequired(e => e.CompanyInfo)
                .HasForeignKey(e => e.C_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyInfo>()
                .HasMany(e => e.Balance_Pay)
                .WithRequired(e => e.CompanyInfo)
                .HasForeignKey(e => e.C_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CompanyInfo>()
                .HasMany(e => e.Jobs)
                .WithOptional(e => e.CompanyInfo)
                .HasForeignKey(e => e.C_ID);

            modelBuilder.Entity<CompanyInfo>()
                .HasMany(e => e.MyCompanies)
                .WithOptional(e => e.CompanyInfo)
                .HasForeignKey(e => e.Com_ID);

            modelBuilder.Entity<CompanyInfo>()
                .HasMany(e => e.ZiJians)
                .WithOptional(e => e.CompanyInfo)
                .HasForeignKey(e => e.C_ID);

            modelBuilder.Entity<CompanyInfo>()
                .HasMany(e => e.BLB_Money)
                .WithRequired(e => e.CompanyInfo)
                .HasForeignKey(e => e.C_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Edu_Exper>()
                .Property(e => e.Pro_desc)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Require)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.Balance_Pay)
                .WithOptional(e => e.Job)
                .HasForeignKey(e => e.Job_ID);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.TuiJian_Resume)
                .WithOptional(e => e.Job)
                .HasForeignKey(e => e.Job_ID);

            modelBuilder.Entity<Job>()
                .HasMany(e => e.ZiJians)
                .WithOptional(e => e.Job)
                .HasForeignKey(e => e.J_ID);

            modelBuilder.Entity<MyMoney>()
                .Property(e => e.Money)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Pro_Exper>()
                .Property(e => e.Project_Desc)
                .IsUnicode(false);

            modelBuilder.Entity<resume>()
                .Property(e => e.Pingjia)
                .IsUnicode(false);

            modelBuilder.Entity<S_City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<S_City>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<S_Province>()
                .Property(e => e.ProvinceName)
                .IsUnicode(false);

            modelBuilder.Entity<TuiJianXin>()
                .Property(e => e.tel)
                .IsUnicode(false);

            modelBuilder.Entity<TuiJianXin>()
                .Property(e => e.reason)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.OpenID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.Img)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.U_IP)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.CertificateInfoes)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Edu_Exper)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.MyCompanies)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.MyMoneys)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.MyMoney_Pay)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Pro_Exper)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.resumes)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.TuiJian_Resume)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.UU_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.TuiJian_Resume1)
                .WithOptional(e => e.UserInfo1)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.Work_Exper)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.ZiJians)
                .WithOptional(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.BLB_Money)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserInfo>()
                .HasMany(e => e.UserCards)
                .WithRequired(e => e.UserInfo)
                .HasForeignKey(e => e.U_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Work_Exper>()
                .Property(e => e.Job_desc)
                .IsUnicode(false);

            modelBuilder.Entity<BLB_Money>()
                .Property(e => e.money)
                .HasPrecision(16, 2);

            modelBuilder.Entity<MianShiSM>()
                .Property(e => e.Tel)
                .IsUnicode(false);

            modelBuilder.Entity<User_WeChat>()
                .Property(e => e.WeChat)
                .IsUnicode(false);

            modelBuilder.Entity<UserCard>()
                .Property(e => e.CardNum)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UserCard>()
                .Property(e => e.Tel)
                .IsUnicode(false);
        }
    }
}
