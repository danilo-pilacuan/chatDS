namespace chatDS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreacionBDD : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contactoes",
                c => new
                    {
                        idContacto = c.Int(nullable: false, identity: true),
                        idUsuarioEmisor = c.Int(nullable: false),
                        idUsuarioReceptor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.idContacto);
            
            CreateTable(
                "dbo.Mensajes",
                c => new
                    {
                        idMensaje = c.Int(nullable: false, identity: true),
                        idEmisor = c.Int(nullable: false),
                        idReceptor = c.Int(nullable: false),
                        contenidoMensaje = c.String(),
                        estadoMensaje = c.Int(nullable: false),
                        fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.idMensaje);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        idUsuario = c.Int(nullable: false, identity: true),
                        numCelular = c.String(),
                        claveUsuario = c.String(),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.idUsuario);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuarios");
            DropTable("dbo.Mensajes");
            DropTable("dbo.Contactoes");
        }
    }
}
