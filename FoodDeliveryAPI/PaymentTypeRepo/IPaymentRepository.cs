using FoodDeliveryAPI.Models;

namespace FoodDeliveryAPI.PaymentTypeRepo
{
    public interface IPaymentRepository
    {
        public Task<PaymentType> AddPaymentType(PaymentType paymentType);
        public Task<PaymentType> UpdatePaymentType(PaymentType paymentType);
        public List<PaymentType> GetPaymentTypes();
        public PaymentType GetPaymentTypeById(int payment);
    }
}
