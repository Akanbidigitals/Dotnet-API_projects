using TempratureConverter.Interface;

namespace TempratureConverter.Repository
{
    public class Temprature : ITemprature
    {
        public string ConvertToCelcius(int temprature)
        {
            try
            {
                var result = (temprature - 32) * 5 / 9;

                return $"{result}^C";

            }
            catch(Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }

        public string ConvertToFahrenheit(int temprature)
        {
            try
            {
                var result = (9 / 5) * (temprature + 32);
                return $"{result}^F";

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
