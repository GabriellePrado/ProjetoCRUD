using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoVendas.Models;
using ProjetoVendas.Models.Enums;

namespace ProjetoVendas.Data
{
    public class SeedingService
    {
        private ProjetoVendasContext _context;

        public SeedingService(ProjetoVendasContext context)
        {
            _context = context;
        }

        public void PopulaBaseDados()
        {
            if(_context.Departamento.Any() || _context.Vendedor.Any() || _context.RegistroVendas.Any() || _context.Produto.Any())
            {
                return;//DB ja populado
            }

            Departamento d1 = new Departamento("Maquina");
            Departamento d2 = new Departamento("Token");
            Departamento d3 = new Departamento("Maquina");
            Departamento d4 = new Departamento("Token");

            Vendedor s1 = new Vendedor("Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Vendedor s2 = new Vendedor("Maria Green", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d2);
            Vendedor s3 = new Vendedor("Alex Grey", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Vendedor s4 = new Vendedor("Martha Red", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d4);
            Vendedor s5 = new Vendedor("Donald Blue", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d3);
            Vendedor s6 = new Vendedor("Alex Pink", "bob@gmail.com", new DateTime(1997, 3, 4), 3000.0, d2);

            Produto p1 = new Produto("Maquina PagSeguro", 49.90, "Maquina de boa qualidade a melhor do mercado!");
            Produto p2 = new Produto("Token", 229.90, "Token fisica de boa qualidade a melhor do mercado!");
            Produto p3 = new Produto("Maquina Taxa0", 49.90, "Maquina de boa qualidade a melhor do mercado!");

            RegistroVendas r1 = new RegistroVendas(1, new DateTime(2020, 09, 25), 11000.0, StatusVendas.Pendente, s1,p1);
            RegistroVendas r2 = new RegistroVendas(2, new DateTime(2020, 09, 4), 7000.0, StatusVendas.Pendente, s5, p2);
            RegistroVendas r3 = new RegistroVendas(3, new DateTime(2020, 09, 13), 4000.0, StatusVendas.Cancelado, s4, p1);
            RegistroVendas r4 = new RegistroVendas(4, new DateTime(2020, 09, 1), 8000.0, StatusVendas.Faturado, s1, p2);
            RegistroVendas r5 = new RegistroVendas(5, new DateTime(2020, 09, 21), 3000.0, StatusVendas.Faturado, s3, p1);
            RegistroVendas r6 = new RegistroVendas(6, new DateTime(2020, 09, 15), 2000.0, StatusVendas.Faturado, s1, p2);
            RegistroVendas r7 = new RegistroVendas(7, new DateTime(2020, 09, 28), 13000.0, StatusVendas.Faturado, s2, p1);
            RegistroVendas r8 = new RegistroVendas(8, new DateTime(2020, 09, 11), 4000.0, StatusVendas.Faturado, s4, p2);
            RegistroVendas r9 = new RegistroVendas(9, new DateTime(2020, 09, 14), 11000.0, StatusVendas.Pendente, s6, p1);
            RegistroVendas r10 = new RegistroVendas(10, new DateTime(2020, 09, 7), 9000.0, StatusVendas.Faturado, s6, p3);
            RegistroVendas r11 = new RegistroVendas(11, new DateTime(2020, 09, 13), 6000.0, StatusVendas.Faturado, s2, p3);
            RegistroVendas r12 = new RegistroVendas(12, new DateTime(2020, 09, 25), 7000.0, StatusVendas.Pendente, s3, p2);
            RegistroVendas r13 = new RegistroVendas(13, new DateTime(2020, 09, 29), 10000.0, StatusVendas.Faturado, s4, p1);
            RegistroVendas r14 = new RegistroVendas(14, new DateTime(2020, 09, 4), 3000.0, StatusVendas.Faturado, s5, p2);
            RegistroVendas r15 = new RegistroVendas(15, new DateTime(2020, 09, 12), 4000.0, StatusVendas.Faturado, s1, p2);
            RegistroVendas r16 = new RegistroVendas(16, new DateTime(2020, 10, 5), 2000.0, StatusVendas.Faturado, s4, p1);
            RegistroVendas r17 = new RegistroVendas(17, new DateTime(2020, 10, 1), 12000.0, StatusVendas.Faturado, s1, p2 );
            RegistroVendas r18 = new RegistroVendas(18, new DateTime(2020, 10, 24), 6000.0, StatusVendas.Faturado, s3, p3);
            RegistroVendas r19 = new RegistroVendas(19, new DateTime(2020, 10, 22), 8000.0, StatusVendas.Faturado, s5, p2);
            RegistroVendas r20 = new RegistroVendas(20, new DateTime(2020, 10, 15), 8000.0, StatusVendas.Faturado, s6, p1);
            RegistroVendas r21 = new RegistroVendas(21, new DateTime(2020, 10, 17), 9000.0, StatusVendas.Faturado, s2, p1);
            RegistroVendas r22 = new RegistroVendas(22, new DateTime(2020, 10, 24), 4000.0, StatusVendas.Faturado, s4, p2);
            RegistroVendas r23 = new RegistroVendas(23, new DateTime(2020, 10, 19), 11000.0, StatusVendas.Cancelado, s2, p1);
            RegistroVendas r24 = new RegistroVendas(24, new DateTime(2020, 10, 12), 8000.0, StatusVendas.Faturado, s5, p2);
            RegistroVendas r25 = new RegistroVendas(25, new DateTime(2020, 10, 31), 7000.0, StatusVendas.Faturado, s3, p1);
            RegistroVendas r26 = new RegistroVendas(26, new DateTime(2020, 10, 6), 5000.0, StatusVendas.Faturado, s4, p2);
            RegistroVendas r27 = new RegistroVendas(27, new DateTime(2020, 10, 13), 9000.0, StatusVendas.Pendente, s1, p1);
            RegistroVendas r28 = new RegistroVendas(28, new DateTime(2020, 10, 7), 4000.0, StatusVendas.Faturado, s3, p2);
            RegistroVendas r29 = new RegistroVendas(29, new DateTime(2020, 10, 23), 12000.0, StatusVendas.Faturado, s5, p1);
            RegistroVendas r30 = new RegistroVendas(30, new DateTime(2020, 10, 12), 5000.0, StatusVendas.Faturado, s2, p2);

            _context.Departamento.AddRange(d1, d2, d3, d4);

            _context.Vendedor.AddRange(s1, s2, s3, s4, s5, s6);

            _context.RegistroVendas.AddRange(
                r1, r2, r3, r4, r5, r6, r7, r8, r9, r10,
                r11, r12, r13, r14, r15, r16, r17, r18, r19, r20,
                r21, r22, r23, r24, r25, r26, r27, r28, r29, r30
            );
            _context.Produto.AddRange(p1, p2, p3);

            _context.SaveChanges();
        }
    }
}
