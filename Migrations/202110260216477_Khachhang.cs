namespace BTLLTQL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Khachhang : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khachhang",
                c => new
                    {
                        Stt = c.Int(nullable: false, identity: true),
                        Makhachhang = c.String(),
                        Tenkhachhang = c.String(unicode: false),
                        Sdt = c.Int(nullable: false),
                        Diachi = c.String(),
                    })
                .PrimaryKey(t => t.Stt);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khachhang");
        }
    }
}
