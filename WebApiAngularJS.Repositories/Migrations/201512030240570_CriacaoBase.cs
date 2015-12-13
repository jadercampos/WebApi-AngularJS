namespace WebApiAngularJS.Repositories.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CriacaoBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estabelecimento",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Descricao = c.String(maxLength: 300),
                        DtInc = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                        DtAlt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Estabelecimento");
        }
    }
}
