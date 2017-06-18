using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class WorkOrderReceivedChallanTaxDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<WorkOrderReceivedChallanTax> WorkOrderReceivedChallanTaxDaoRepository;

        public WorkOrderReceivedChallanTaxDao()
        {
            WorkOrderReceivedChallanTaxDaoRepository = unitOfWork.Repository<WorkOrderReceivedChallanTax>();
        }

        public bool Validate(WorkOrderReceivedChallanTax _WorkOrderReceivedChallanTax, out List<string> lstMessages)
        {
            return WorkOrderReceivedChallanTaxDaoRepository.Validate(_WorkOrderReceivedChallanTax, out lstMessages);
        }

        public int Insert(WorkOrderReceivedChallanTax _WorkOrderReceivedChallanTax)
        {
            return WorkOrderReceivedChallanTaxDaoRepository.Insert(_WorkOrderReceivedChallanTax);
        }

        public int Update(WorkOrderReceivedChallanTax _WorkOrderReceivedChallanTax)
        {
            return WorkOrderReceivedChallanTaxDaoRepository.Update(_WorkOrderReceivedChallanTax);
        }

        public int Delete(WorkOrderReceivedChallanTax _WorkOrderReceivedChallanTax)
        {
            return WorkOrderReceivedChallanTaxDaoRepository.Delete(_WorkOrderReceivedChallanTax);
        }

        public async Task<WorkOrderReceivedChallanTax> GetById(int _id)
        {
            return await WorkOrderReceivedChallanTaxDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanTax>> GetAll()
        {
            return await WorkOrderReceivedChallanTaxDaoRepository.GetAll();
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanTax>> FindBy(Expression<Func<WorkOrderReceivedChallanTax, bool>> predicate)
        {
            return await WorkOrderReceivedChallanTaxDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanTax>> GetAllBy(Expression<Func<WorkOrderReceivedChallanTax, bool>> filter = null, Func<IEnumerable<WorkOrderReceivedChallanTax>, IOrderedEnumerable<WorkOrderReceivedChallanTax>> orderBy = null)
        {
            return await WorkOrderReceivedChallanTaxDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
