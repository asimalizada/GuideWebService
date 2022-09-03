using Autofac;
using Autofac.Extras.DynamicProxy;
using Guide.Business.Abstract;
using Guide.Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework;

namespace Guide.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region DataAccess

            builder.RegisterType<EfAimCategoryDal>().As<IAimCategoryDal>().SingleInstance();
            builder.RegisterType<EfAimDal>().As<IAimCategoryDal>().SingleInstance();
            builder.RegisterType<EfAimOperationDal>().As<IAimOperationDal>().SingleInstance();
            builder.RegisterType<EfExerciseCategoryDal>().As<IExerciseCategoryDal>().SingleInstance();
            builder.RegisterType<EfExerciseDal>().As<IExerciseDal>().SingleInstance();
            builder.RegisterType<EfExerciseOperationDal>().As<IExerciseOperationDal>().SingleInstance();

            #endregion

            #region Business



            #endregion

            #region Other

            //builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            #endregion

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
