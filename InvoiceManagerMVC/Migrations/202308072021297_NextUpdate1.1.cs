namespace InvoiceManagerMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NextUpdate11 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Clients", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Clients", new[] { "Address_Id" });
            DropColumn("dbo.Clients", "AddresId");
            RenameColumn(table: "dbo.Clients", name: "Address_Id", newName: "AddresId");
            AlterColumn("dbo.Clients", "AddresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "AddresId");
            AddForeignKey("dbo.Clients", "AddresId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "AddresId", "dbo.Addresses");
            DropIndex("dbo.Clients", new[] { "AddresId" });
            AlterColumn("dbo.Clients", "AddresId", c => c.Int());
            RenameColumn(table: "dbo.Clients", name: "AddresId", newName: "Address_Id");
            AddColumn("dbo.Clients", "AddresId", c => c.Int(nullable: false));
            CreateIndex("dbo.Clients", "Address_Id");
            AddForeignKey("dbo.Clients", "Address_Id", "dbo.Addresses", "Id");
        }
    }
}
