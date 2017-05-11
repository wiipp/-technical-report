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
    public class GrupoRepository : Repository<grupo>, IGrupoRepository
    {
        public GrupoRepository(RatContext context) : base(context)
        {
        }

        public grupo ObterGrupos(int? id)
        {
            //return Db.grupos.Where(x => x.cod_gru == id).ToList();
            //return DbSet.Find(Convert.ToInt32(id));
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM grupo where cod_gru = @sid";
            var rat = cn.Query<grupo>(sql, new { sid = id });
            return rat.FirstOrDefault();


        }
    }
}
