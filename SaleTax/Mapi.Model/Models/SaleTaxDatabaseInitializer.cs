using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mapi.Models
{
    public class SaleTaxDatabaseInitializer  :  DropCreateDatabaseIfModelChanges<SaleTaxContext>
    {
        protected override void Seed(SaleTaxContext context)
        {
            base.Seed(context);
        }
    }
}