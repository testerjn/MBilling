using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class WorkOrderReceivedChallanDetailDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<WorkOrderReceivedChallanDetail> WorkOrderReceivedChallanDetailDaoRepository;

        public WorkOrderReceivedChallanDetailDao()
        {
            WorkOrderReceivedChallanDetailDaoRepository = unitOfWork.Repository<WorkOrderReceivedChallanDetail>();
        }

        public bool Validate(WorkOrderReceivedChallanDetail _WorkOrderReceivedChallanDetail, out List<string> lstMessages)
        {
            return WorkOrderReceivedChallanDetailDaoRepository.Validate(_WorkOrderReceivedChallanDetail, out lstMessages);
        }

        public int Insert(WorkOrderReceivedChallanDetail _WorkOrderReceivedChallanDetail)
        {
            return WorkOrderReceivedChallanDetailDaoRepository.Insert(_WorkOrderReceivedChallanDetail);
        }

        public int Update(WorkOrderReceivedChallanDetail _WorkOrderReceivedChallanDetail)
        {
            return WorkOrderReceivedChallanDetailDaoRepository.Update(_WorkOrderReceivedChallanDetail);
        }

        public int Delete(WorkOrderReceivedChallanDetail _WorkOrderReceivedChallanDetail)
        {
            return WorkOrderReceivedChallanDetailDaoRepository.Delete(_WorkOrderReceivedChallanDetail);
        }

        public async Task<WorkOrderReceivedChallanDetail> GetById(int _id)
        {
            return await WorkOrderReceivedChallanDetailDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanDetail>> GetAll()
        {
            return await WorkOrderReceivedChallanDetailDaoRepository.GetAll();
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanDetail>> FindBy(Expression<Func<WorkOrderReceivedChallanDetail, bool>> predicate)
        {
            return await WorkOrderReceivedChallanDetailDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanDetail>> GetAllBy(Expression<Func<WorkOrderReceivedChallanDetail, bool>> filter = null, Func<IEnumerable<WorkOrderReceivedChallanDetail>, IOrderedEnumerable<WorkOrderReceivedChallanDetail>> orderBy = null)
        {
            return await WorkOrderReceivedChallanDetailDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
