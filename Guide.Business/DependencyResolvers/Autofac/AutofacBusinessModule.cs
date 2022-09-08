using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Features.Interceptors;
using Guide.Business.Abstract;
using Guide.Business.Concrete;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework;

namespace Guide.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region DataAccess

            builder.RegisterType<EfAimPropertyRepository>().As<IAimPropertyRepository>().SingleInstance();
            builder.RegisterType<EfAimRepository>().As<IAimRepository>().SingleInstance();
            builder.RegisterType<EfAimOperationRepository>().As<IAimOperationRepository>().SingleInstance();
            builder.RegisterType<EfAimPropertyOptionRepository>().As<IAimPropertyOptionRepository>().SingleInstance();
            builder.RegisterType<EfAimPropertyValueRepository>().As<IAimPropertyValueRepository>().SingleInstance();
            builder.RegisterType<EfExercisePropertyRepository>().As<IExercisePropertyRepository>().SingleInstance();
            builder.RegisterType<EfExerciseRepository>().As<IExerciseRepository>().SingleInstance();
            builder.RegisterType<EfExerciseOperationRepository>().As<IExerciseOperationRepository>().SingleInstance();
            builder.RegisterType<EfExercisePropertyOptionRepository>().As<IExercisePropertyOptionRepository>().SingleInstance();
            builder.RegisterType<EfExercisePropertyValueRepository>().As<IExercisePropertyValueRepository>().SingleInstance();

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
