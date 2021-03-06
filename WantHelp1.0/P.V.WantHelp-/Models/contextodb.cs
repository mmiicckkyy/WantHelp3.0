﻿namespace P.V.WantHelp_.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class contextodb:DbContext
    {
        public contextodb()
            : base("name=PlataformaVirtualEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public DbSet<archivos> archivos { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<inscripcion> inscripcion { get; set; }
        public DbSet<Material> Material { get; set; }
        public DbSet<mensajes> mensajes { get; set; }
        public DbSet<Preguntas> Preguntas { get; set; }
        public DbSet<puntuacionChat> puntuacionChat { get; set; }
        public DbSet<puntuacionRes> puntuacionRes { get; set; }
        public DbSet<Respuestas> Respuestas { get; set; }
        public DbSet<Respuestas_Chat> Respuestas_Chat { get; set; }
        public DbSet<sesiones> sesiones { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<webpages_Membership> webpages_Membership { get; set; }
        public DbSet<webpages_OAuthMembership> webpages_OAuthMembership { get; set; }
        public DbSet<webpages_Roles> webpages_Roles { get; set; }
        public DbSet<webpages_UsersInRoles> webpages_UsersInRoles { get; set; }
        public DbSet<DetalleRolesAsignadosUsers> DetalleRolesAsignadosUsers { get; set; }
    }
}