using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class WorkOrderDetailDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<WorkOrderDetail> WorkOrderDetailDaoRepository;

        public WorkOrderDetailDao()
        {
            WorkOrderDetailDaoRepository = unitOfWork.Repository<WorkOrderDetail>();
        }

        public bool Validate(WorkOrderDetail _WorkOrderDetail, out List<string> lstMessages)
        {
            return WorkOrderDetailDaoRepository.Validate(_WorkOrderDetail, out lstMessages);
        }

        public int Insert(WorkOrderDetail _WorkOrderDetail)
        {
            return WorkOrderDetailDaoRepository.Insert(_WorkOrderDetail);
        }

        public int Update(WorkOrderDetail _WorkOrderDetail)
        {
            return WorkOrderDetailDaoRepository.Update(_WorkOrderDetail);
        }

        public int Delete(WorkOrderDetail _WorkOrderDetail)
        {
            return WorkOrderDetailDaoRepository.Delete(_WorkOrderDetail);
        }

        public async Task<WorkOrderDetail> GetById(int _id)
        {
            return await WorkOrderDetailDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<WorkOrderDetail>> GetAll()
        {
            return await WorkOrderDetailDaoRepository.GetAll();
        }

        public async Task<IEnumerable<WorkOrderDetail>> FindBy(Expression<Func<WorkOrderDetail, bool>> predicate)
        {
            return await WorkOrderDetailDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<WorkOrderDetail>> GetAllBy(Expression<Func<WorkOrderDetail, bool>> filter = null, Func<IEnumerable<WorkOrderDetail>, IOrderedEnumerable<WorkOrderDetail>> orderBy = null)
        {
            return await WorkOrderDetailDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
