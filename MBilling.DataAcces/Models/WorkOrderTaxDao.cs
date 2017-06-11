using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class WorkOrderTaxDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<WorkOrderTax> WorkOrderTaxDaoRepository;

        public WorkOrderTaxDao()
        {
            WorkOrderTaxDaoRepository = unitOfWork.Repository<WorkOrderTax>();
        }

        public bool Validate(WorkOrderTax _WorkOrderTax, out List<string> lstMessages)
        {
            return WorkOrderTaxDaoRepository.Validate(_WorkOrderTax, out lstMessages);
        }

        public int Insert(WorkOrderTax _WorkOrderTax)
        {
            return WorkOrderTaxDaoRepository.Insert(_WorkOrderTax);
        }

        public int Update(WorkOrderTax _WorkOrderTax)
        {
            return WorkOrderTaxDaoRepository.Update(_WorkOrderTax);
        }

        public int Delete(WorkOrderTax _WorkOrderTax)
        {
            return WorkOrderTaxDaoRepository.Delete(_WorkOrderTax);
        }

        public async Task<WorkOrderTax> GetById(int _id)
        {
            return await WorkOrderTaxDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<WorkOrderTax>> GetAll()
        {
            return await WorkOrderTaxDaoRepository.GetAll();
        }

        public async Task<IEnumerable<WorkOrderTax>> FindBy(Expression<Func<WorkOrderTax, bool>> predicate)
        {
            return await WorkOrderTaxDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<WorkOrderTax>> GetAllBy(Expression<Func<WorkOrderTax, bool>> filter = null, Func<IEnumerable<WorkOrderTax>, IOrderedEnumerable<WorkOrderTax>> orderBy = null)
        {
            return await WorkOrderTaxDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
