using Core.Aspects.Autofac.Caching;
using Core.Business.Concrete;
using Core.Features.Results.Abstract;
using Core.Features.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimOperationManager : ManagerRepositoryBase<AimOperation, IAimOperationRepository>, IAimOperationService
    {
        private readonly IAimOperationRepository _aimOperationRepository;
        public AimOperationManager(IAimOperationRepository repository) : base(repository)
        {
            _aimOperationRepository = repository;
            base.SetValidator(new AimOperationValidator());
        }

        [CacheAspect]
        public IDataResult<List<AimOperation>> GetByAim(int aimId)
        {
            return new SuccessDataResult<List<AimOperation>>(_aimOperationRepository.GetAll(a => a.AimId == aimId), Messages.DataFound);
        }

        [CacheAspect]
        public IDataResult<List<AimOperation>> GetByDate(DateTime date)
        {
            return new SuccessDataResult<List<AimOperation>>(_aimOperationRepository.GetAll(a => a.CompleteDate == date), Messages.DataFound);
        }

        [CacheAspect]
        public IDataResult<List<AimOperation>> GetByDate(DateTime from, DateTime to)
        {
            return new SuccessDataResult<List<AimOperation>>(_aimOperationRepository.GetAll(a => a.CompleteDate >= from & a.CompleteDate <= to), Messages.DataFound);
        }
    }
}
