using Digigraf.Rat.Dominio.Entidades.SIGA;
using Digigraf.Rat.Dominio.Interfaces.Repository.SIGA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digigraf.Rat.Infra.Dados.Context;
using Dapper;

namespace Digigraf.Rat.Infra.Dados.Repository.SIGA
{
    public class RatRepositorySIGA : RepositorySIGA<SA1110>, IRatRepositorySIGA
    {
        public RatRepositorySIGA(SIGAContext contextSIGA) : base(contextSIGA)
        {
        }

        public List<SA1110> ObterRatSIGA(string id)
        {
            // return DbSIGA.SA1110.Where(x => x.A1_COD == id).ToList();
            var cn = DbSIGA.Database.Connection;
            var sql = @"SELECT * FROM SA1110 where A1_COD = @sid";
            var rat = cn.Query<SA1110>(sql, new { sid = id });
            return rat.ToList();

        }

           public void PesquisarClienteSIGA(int id)
        {
            throw new NotImplementedException();
        }
    }
}
