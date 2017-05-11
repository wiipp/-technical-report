using Digigraf.Rat.Dominio.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Digigraf.Rat.Dominio.Entidades;
using System.Linq.Expressions;
using Digigraf.Rat.Infra.Dados.Context;
using Dapper;

namespace Digigraf.Rat.Infra.Dados.Repository
{
    public class RatRepository : Repository<rat>, IRatRepository
    {
        public RatRepository( RatContext context)
            : base(context)
        {

        }

        public IEnumerable<rat> ObterPorData()
        {
            // var data = DateTime.Today.ToString();
            // var dataTrinta = DateTime.Now.Date.AddDays(-30).ToString();

            //var rat = Db.rats.Where(x => ( x.dt_rat >= dataTrinta && x.dt_rat <= data)).ToList(); // will

            var query = Db.rats.Distinct().ToList();  // traz os 10 ultimos registros.
            var rat = query.Skip(query.Count - 40).ToList();

            return rat;
        }

        public List<rat> ObterRats(int id)
        {
            // return Db.rats.Where(x => x.cod_rat == id ).ToList() ;
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM rat where cod_rat = @sid";
            var rat = cn.Query<rat>(sql, new { sid = id });
            return rat.ToList();

        }

        public sx5 ObterServicos(rat rats)
        {
            //return Db.sx5s.Where(x => x.campo == "severidade" && x.sistema == "rat" && x.valor.Contains(rats.severidade)).ToArray();                        

            return null;
        }

        public override rat ObterPorId(int id)
        {
           var cn = Db.Database.Connection;
           var sql = @"SELECT * FROM rat where cod_rat = @sid";
           var rat = cn.Query<rat>(sql,new { sid = id});
           return rat.FirstOrDefault();
        }

        
        
        public void RemoverRat(int id)
        {
            var rat = ObterPorId(id);
            //rat.Ativo = false;
            Atualizar(rat);
        }

   
    }
}
