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
    public class AtendenteRepository : Repository<atendente>, IAtendenteRepository
    {
        public AtendenteRepository(RatContext context) : base(context)
        {
        }

        public List<atendente> ObterAtendentes(int id)
        {
            return Db.atendentes.Where(x => x.cod_ate == id).ToList();
        }

        public override atendente ObterPorId(int id)
        {
            //return base.ObterPorId(id);
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM atendente where cod_ate = @sid";
            var rat = cn.Query<atendente>(sql, new { sid = id });
            return rat.FirstOrDefault();
        }
    }
}
