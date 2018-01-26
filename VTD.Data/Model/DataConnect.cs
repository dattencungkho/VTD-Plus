namespace VTD.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DataConnect : DbContext
    {
        public DataConnect()
            : base("name=DataConnect")
        {
        }

        public virtual DbSet<district_food> district_food { get; set; }
        public virtual DbSet<food_customer> food_customer { get; set; }
        public virtual DbSet<food_feedback> food_feedback { get; set; }
        public virtual DbSet<food_home_delivery> food_home_delivery { get; set; }
        public virtual DbSet<food_items> food_items { get; set; }
        public virtual DbSet<food_menu> food_menu { get; set; }
        public virtual DbSet<food_order_details> food_order_details { get; set; }
        public virtual DbSet<food_orders> food_orders { get; set; }
        public virtual DbSet<food_restaurant> food_restaurant { get; set; }
        public virtual DbSet<food_sale_detail> food_sale_detail { get; set; }
        public virtual DbSet<food_user_group1> food_user_group1 { get; set; }
        public virtual DbSet<province_food> province_food { get; set; }
        public virtual DbSet<slide_food> slide_food { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<food_customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.comfirm)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.creator_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.created_at)
                .IsFixedLength();

            modelBuilder.Entity<food_customer>()
                .Property(e => e.updator_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_customer>()
                .Property(e => e.deletor_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_feedback>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<food_feedback>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<food_feedback>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<food_home_delivery>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<food_home_delivery>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<food_home_delivery>()
                .Property(e => e.payment_type)
                .IsUnicode(false);

            modelBuilder.Entity<food_items>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<food_items>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<food_items>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<food_items>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<food_items>()
                .Property(e => e.menu_id)
                .IsFixedLength();

            modelBuilder.Entity<food_items>()
                .Property(e => e.creator_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_items>()
                .Property(e => e.created_at)
                .IsFixedLength();

            modelBuilder.Entity<food_items>()
                .Property(e => e.updator_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_items>()
                .Property(e => e.deletor_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_menu>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<food_menu>()
                .Property(e => e.category)
                .IsUnicode(false);

            modelBuilder.Entity<food_order_details>()
                .Property(e => e.price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<food_orders>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.location)
                .IsUnicode(false);

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.contact)
                .IsUnicode(false);

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.details)
                .IsUnicode(false);

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.creator_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.created_at)
                .IsFixedLength();

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.updator_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_restaurant>()
                .Property(e => e.deletor_code)
                .IsUnicode(false);

            modelBuilder.Entity<food_sale_detail>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<food_sale_detail>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<food_user_group1>()
                .Property(e => e.name)
                .IsUnicode(false);
        }
    }
}
