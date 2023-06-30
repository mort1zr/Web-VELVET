using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProyectoVF.Models;

public partial class VentaC : DbContext
{
    public VentaC()
    {
    }

    public VentaC(DbContextOptions<VentaC> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-DSEE4698\\SQLEXPRESS;Initial Catalog=BD_Ventas;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.IdCategoria);

            entity.ToTable("CATEGORIA");

            entity.Property(e => e.IdCategoria).HasColumnName("idCATEGORIA");
            entity.Property(e => e.NombreCategoria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCATEGORIA");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("CLIENTE");

            entity.Property(e => e.IdCliente).HasColumnName("idCLIENTE");
            entity.Property(e => e.ApellidoCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellidoCLIENTE");
            entity.Property(e => e.DireccionCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccionCLIENTE");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCLIENTE");
            entity.Property(e => e.PasswordCliente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("passwordCLIENTE");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.IdDv);

            entity.ToTable("detalleVENTA");

            entity.HasIndex(e => e.IdVenta, "IX_detalleVENTA");

            entity.Property(e => e.IdDv).HasColumnName("idDV");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.IdProducto).HasColumnName("idPRODUCTO");
            entity.Property(e => e.IdVenta).HasColumnName("idVENTA");
            entity.Property(e => e.PrecioVenta).HasColumnName("precioVENTA");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalleVENTA_PRODUCT");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_detalleVENTA_VENTA");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.IdProducto);

            entity.ToTable("PRODUCT");

            entity.Property(e => e.IdProducto).HasColumnName("idPRODUCTO");
            entity.Property(e => e.DesProducto)
                .HasColumnType("text")
                .HasColumnName("desProducto");
            entity.Property(e => e.IdCategoria).HasColumnName("idCATEGORIA");
            entity.Property(e => e.ImgProducto)
                .IsUnicode(false)
                .HasColumnName("imgPRODUCTO");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombrePRODUCTO");
            entity.Property(e => e.PrecioProducto).HasColumnName("precioPRODUCTO");
            entity.Property(e => e.StockProducto).HasColumnName("stockPRODUCTO");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.IdCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PRODUCT_CATEGORIA");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.IdVenta);

            entity.ToTable("VENTA");

            entity.Property(e => e.IdVenta).HasColumnName("idVENTA");
            entity.Property(e => e.EstadoVenta)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("estadoVENTA");
            entity.Property(e => e.FechaVenta)
                .HasColumnType("date")
                .HasColumnName("fechaVENTA");
            entity.Property(e => e.IdCliente).HasColumnName("idCLIENTE");
            entity.Property(e => e.MontoVenta).HasColumnName("montoVENTA");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdCliente)
                .HasConstraintName("FK_VENTA_CLIENTE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
