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

            builder.RegisterType<EfAimPropertyDal>().As<IAimPropertyDal>().SingleInstance();
            builder.RegisterType<EfAimDal>().As<IAimDal>().SingleInstance();
            builder.RegisterType<EfAimOperationDal>().As<IAimOperationDal>().SingleInstance();
            builder.RegisterType<EfAimPropertyOptionDal>().As<IAimPropertyOptionDal>().SingleInstance();
            builder.RegisterType<EfAimPropertyValueDal>().As<IAimPropertyValueDal>().SingleInstance();
            builder.RegisterType<EfExercisePropertyDal>().As<IExercisePropertyDal>().SingleInstance();
            builder.RegisterType<EfExerciseDal>().As<IExerciseDal>().SingleInstance();
            builder.RegisterType<EfExerciseOperationDal>().As<IExerciseOperationDal>().SingleInstance();
            builder.RegisterType<EfExercisePropertyOptionDal>().As<IExercisePropertyOptionDal>().SingleInstance();
            builder.RegisterType<EfExercisePropertyValueDal>().As<IExercisePropertyValueDal>().SingleInstance();

            #endregion

            #region Business

            builder.RegisterType<AimPropertyManager>().As<IAimPropertyService>().SingleInstance();
            builder.RegisterType<AimManager>().As<IAimService>().SingleInstance();
            builder.RegisterType<AimOperationManager>().As<IAimOperationService>().SingleInstance();
            builder.RegisterType<AimPropertyOptionManager>().As<IAimPropertyOptionService>().SingleInstance();
            builder.RegisterType<AimPropertyValueManager>().As<IAimPropertyValueService>().SingleInstance();
            builder.RegisterType<ExercisePropertyManager>().As<IExercisePropertyService>().SingleInstance();
            builder.RegisterType<ExerciseManager>().As<IExerciseService>().SingleInstance();
            builder.RegisterType<ExerciseOperationManager>().As<IExerciseOperationService>().SingleInstance();
            builder.RegisterType<ExercisePropertyOptionManager>().As<IExercisePropertyOptionService>().SingleInstance();
            builder.RegisterType<ExercisePropertyValueManager>().As<IExercisePropertyValueService>().SingleInstance();

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
