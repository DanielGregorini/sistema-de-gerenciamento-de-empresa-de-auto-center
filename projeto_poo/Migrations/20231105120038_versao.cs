using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutoCenter.Migrations
{
    /// <inheritdoc />
    public partial class versao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rg = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf_Cnpj = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cliente", x => x.ClienteId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_empresa",
                columns: table => new
                {
                    EmpresaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RazaoSocial = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CNPJ = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Endereco = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Telefone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_empresa", x => x.EmpresaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_produto",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Preco = table.Column<double>(type: "double", nullable: false),
                    Quantidade = table.Column<double>(type: "double", nullable: false),
                    CustoMedio = table.Column<double>(type: "double", nullable: false),
                    CustoUltimaEntrada = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_produto", x => x.ProdutoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_veiculo",
                columns: table => new
                {
                    VeiculoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Modelo = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Placa = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_veiculo", x => x.VeiculoId);
                    table.ForeignKey(
                        name: "FK_tb_veiculo_tb_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tb_cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_caixa",
                columns: table => new
                {
                    CaixaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Login = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_caixa", x => x.CaixaId);
                    table.ForeignKey(
                        name: "FK_tb_caixa_tb_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "tb_empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_gerente",
                columns: table => new
                {
                    GerenteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Login = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_gerente", x => x.GerenteId);
                    table.ForeignKey(
                        name: "FK_tb_gerente_tb_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "tb_empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_vendedor",
                columns: table => new
                {
                    VendedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EmpresaId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cpf = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Login = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Senha = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_vendedor", x => x.VendedorId);
                    table.ForeignKey(
                        name: "FK_tb_vendedor_tb_empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "tb_empresa",
                        principalColumn: "EmpresaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_ordemdeservico",
                columns: table => new
                {
                    OrdemDeServicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TipoDeServico = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorarioDeEntrega = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_ordemdeservico", x => x.OrdemDeServicoId);
                    table.ForeignKey(
                        name: "FK_tb_ordemdeservico_tb_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tb_cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_ordemdeservico_tb_vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "tb_vendedor",
                        principalColumn: "VendedorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_venda",
                columns: table => new
                {
                    VendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    VendedorId = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<double>(type: "double", nullable: false),
                    Estado = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HorioRealizacao = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_venda", x => x.VendaId);
                    table.ForeignKey(
                        name: "FK_tb_venda_tb_cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "tb_cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_venda_tb_vendedor_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "tb_vendedor",
                        principalColumn: "VendedorId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_produto_ordemdeservico",
                columns: table => new
                {
                    ProdutoOrdemDeServicoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    OrdemDeServicoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_produto_ordemdeservico", x => x.ProdutoOrdemDeServicoId);
                    table.ForeignKey(
                        name: "FK_tb_produto_ordemdeservico_tb_ordemdeservico_OrdemDeServicoId",
                        column: x => x.OrdemDeServicoId,
                        principalTable: "tb_ordemdeservico",
                        principalColumn: "OrdemDeServicoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_produto_ordemdeservico_tb_produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "tb_produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tb_produto_venda",
                columns: table => new
                {
                    ProdutoVendaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    VendaId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_produto_venda", x => x.ProdutoVendaId);
                    table.ForeignKey(
                        name: "FK_tb_produto_venda_tb_produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "tb_produto",
                        principalColumn: "ProdutoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_produto_venda_tb_venda_VendaId",
                        column: x => x.VendaId,
                        principalTable: "tb_venda",
                        principalColumn: "VendaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_tb_caixa_EmpresaId",
                table: "tb_caixa",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_gerente_EmpresaId",
                table: "tb_gerente",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ordemdeservico_ClienteId",
                table: "tb_ordemdeservico",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_ordemdeservico_VendedorId",
                table: "tb_ordemdeservico",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_produto_ordemdeservico_OrdemDeServicoId",
                table: "tb_produto_ordemdeservico",
                column: "OrdemDeServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_produto_ordemdeservico_ProdutoId",
                table: "tb_produto_ordemdeservico",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_produto_venda_ProdutoId",
                table: "tb_produto_venda",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_produto_venda_VendaId",
                table: "tb_produto_venda",
                column: "VendaId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_veiculo_ClienteId",
                table: "tb_veiculo",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_venda_ClienteId",
                table: "tb_venda",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_venda_VendedorId",
                table: "tb_venda",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_tb_vendedor_EmpresaId",
                table: "tb_vendedor",
                column: "EmpresaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_caixa");

            migrationBuilder.DropTable(
                name: "tb_gerente");

            migrationBuilder.DropTable(
                name: "tb_produto_ordemdeservico");

            migrationBuilder.DropTable(
                name: "tb_produto_venda");

            migrationBuilder.DropTable(
                name: "tb_veiculo");

            migrationBuilder.DropTable(
                name: "tb_ordemdeservico");

            migrationBuilder.DropTable(
                name: "tb_produto");

            migrationBuilder.DropTable(
                name: "tb_venda");

            migrationBuilder.DropTable(
                name: "tb_cliente");

            migrationBuilder.DropTable(
                name: "tb_vendedor");

            migrationBuilder.DropTable(
                name: "tb_empresa");
        }
    }
}
