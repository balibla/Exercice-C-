using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solution_DemoEntities_
{
    public class DemoEntiyFramework
    {
        public void GetDataFromDataBase()
        {
            using(var context = new AvisFormationDBEntities())
            {
                var listView = context.Formation.ToList();
            }
        }
        public void InsertDataToDataBase()
        {
            Formation formation = new Formation();
            formation.Nom = "Formation C# ASP.Net MVC";
            formation.Description = "description de la formation c#";
            formation.Url = "url//c#";
            formation.NomSeo = "Formation_C#_ASP.Net_MVC";
            using(var context=new AvisFormationDBEntities())
            {
                context.Formation.Add(formation);
                context.SaveChanges();

            }
        }
        public void UpdateDataFromDataBase()
        {
            using ( var context = new AvisFormationDBEntities())
            {
                var entityFormation = context.Formation.FirstOrDefault(f=>f.NomSeo=="Asp.net");
                if (entityFormation!=null)
                {
                    entityFormation.Nom = "Formation jEE";
                }
                context.SaveChanges();

            }
        }

    }
}