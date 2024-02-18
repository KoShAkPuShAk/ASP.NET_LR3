namespace WebApplication3.Services
{
    public class CalcService: Interfeces.ICalcService
    {
        public Double Add(Double value1, Double value2)
        {
            return value1 + value2;
        }
        public Double Substract(Double value1, Double value2)
        {
            return value1 - value2;
        }
        public Double Multiply(Double value1, Double value2)
        {
            return value1 * value2;
        }
        public Double Divide(Double value1, Double value2)
        {
            return value1 / value2;
        }
    }
}
