﻿using FirstSolution.Domain;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;

namespace FirstSolution.Tests
{
    [TestFixture]
    class GenerateSchema_Fixture
    {
        [Test]
        public void Can_generate_schema()
        {
            var cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(typeof (Product).Assembly);

            new SchemaExport(cfg).Execute(false, true, false);
        }
    }
}
