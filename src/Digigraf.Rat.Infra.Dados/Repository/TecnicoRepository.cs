using Digigraf.Rat.Dominio.Entidades;
using Digigraf.Rat.Dominio.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digigraf.Rat.Infra.Dados.Context;
using Dapper;

namespace Digigraf.Rat.Infra.Dados.Repository
{
    public class TecnicoRepository : Repository<tecnico>, ITecnicoRepository
    {
        public TecnicoRepository(RatContext context) : base(context)
        {
        }

        public tecnico ObterTecnicos(string id)
        {
            return DbSet.Find(Convert.ToInt32(id));
        }

        public override tecnico ObterPorId(int id)
        {

            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM tecnico where cod_tec = @sid";
            var rat = cn.Query<tecnico>(sql, new { sid = id });
            return rat.FirstOrDefault();

        }
    }
}
