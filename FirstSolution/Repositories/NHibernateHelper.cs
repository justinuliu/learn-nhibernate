using FirstSolution.Domain;
using NHibernate;
using NHibernate.Cfg;

namespace FirstSolution.Repositories
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessiongFactory
        {
            get
            {
                if(_sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(Product).Assembly);
                    _sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;

            }
        }

        public static ISession OpenSession()
        {
            return SessiongFactory.OpenSession();
        }
    }
}
