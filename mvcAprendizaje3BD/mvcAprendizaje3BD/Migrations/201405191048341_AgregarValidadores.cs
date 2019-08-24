namespace mvcAprendizaje3BD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarValidadores : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.clientes", "nombre", c => c.String(nullable: false));
            AlterColumn("dbo.clientes", "aprePaterno", c => c.String(nullable: false));
            AlterColumn("dbo.clientes", "apeMaterno", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.clientes", "apeMaterno", c => c.String());
            AlterColumn("dbo.clientes", "aprePaterno", c => c.String());
            AlterColumn("dbo.clientes", "nombre", c => c.String());
        }
    }
}
